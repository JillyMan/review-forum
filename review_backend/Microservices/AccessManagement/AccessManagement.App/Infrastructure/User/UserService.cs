using AccessManagement.App.Exceptions;
using AccessManagement.App.Models;
using AccessManagement.App.Utils;
using AccessManagement.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;

namespace AccessManagement.App.Services.User
{
    public class UserService : IUserService
    {
        public IAccessManagementContext _context;

        public UserService(IAccessManagementContext context)
        {
            _context = context;
        }

        public async Task<UserInfo> Authenticate(AuthenticateInfo authorizeInfo)
        {
            if (string.IsNullOrEmpty(authorizeInfo.Login) || string.IsNullOrEmpty(authorizeInfo.Password))
            {
                throw new ArgumentException($"The argument: {nameof(authorizeInfo)} has null props.");
            }

            var user = await _context.Users.SingleOrDefaultAsync(x => x.Login == authorizeInfo.Login);

            if (user != null && PasswordHelper.VerifyPasswordHash(authorizeInfo.Password, user.PasswordHash, user.PasswordSalt))
            {
                return user;
            }

            throw new UserNotFoundException($"The user was not found.");
        }

        public async Task<UserInfo> GetById(string id)
        {
            return await _context.Users.SingleOrDefaultAsync(x => x.Id == id);
        }

        public async Task<UserInfo> Register(RegisterInfo registerInfo)
        {
            var user = await _context.Users.FirstOrDefaultAsync(x => x.Login == registerInfo.Login);
            if (user != null)
            {
                throw new UserAlreadyExistException();
            } 

            PasswordHelper.CreatePasswordHash(registerInfo.Password, out var hash, out var salt);

            var newUser = UserInfo.Create("",
                registerInfo.FirstName,
                registerInfo.LastName,
                registerInfo.Login,
                hash,
                salt,
                true);

            using var transaction = _context.BeginTransaction();
            try
            {
                var entity = _context.Users.Add(newUser);
                await _context.SaveChangesAsync();
                await transaction.CommitAsync();
                return entity.Entity;
            }
            catch(Exception e)
            {
                await transaction.RollbackAsync();
                throw e;
            }
        }
    }
}