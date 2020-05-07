using Microsoft.EntityFrameworkCore;
using ReviewManagement.App.Infrastructure;
using ReviewManagement.App.Exceptions;
using ReviewManagement.App.Models;
using ReviewManagement.App.Utils;
using ReviewManagement.Domain.Entities;
using ReviewManagement.Domain.Entities.Security;
using System;
using System.Threading.Tasks;

namespace ReviewManagement.App.Services.User
{
    public class UserService : IUserService
    {
        public IReviewManagementContext _context;

        public UserService(IReviewManagementContext context)
        {
            _context = context;
        }

        public async Task<UserInfo> Authenticate(AuthenticateInfo authorizeInfo)
        {
            if (string.IsNullOrEmpty(authorizeInfo.Login) || string.IsNullOrEmpty(authorizeInfo.Password))
            {
                throw new ArgumentException($"The argument: {nameof(authorizeInfo)} has null props.");
            }

            var user = await _context.Users
                .Include(x => x.UserSettingInfo)
                .SingleOrDefaultAsync(x => x.UserSettingInfo.Login == authorizeInfo.Login);

            if (user != null && PasswordHelper.VerifyPasswordHash(
                authorizeInfo.Password,
                user.UserSettingInfo.PasswordHash,
                user.UserSettingInfo.PasswordSalt))
            {
                return user;
            }

            throw new UserNotFoundException($"The user was not found.");
        }

        public async Task<UserInfo> GetById(int id)
        {
            return await _context.Users.SingleOrDefaultAsync(x => x.Id == id);
        }

        public async Task<UserInfo> Register(RegisterInfo registerInfo)
        {
            var user = await _context.Users.FirstOrDefaultAsync(x => x.UserSettingInfo.Login == registerInfo.Login);
            if (user != null)
            {
                throw new UserAlreadyExistException();
            }

            PasswordHelper.CreatePasswordHash(registerInfo.Password, out var hash, out var salt);

            var settingInfo = new UserSettingInfo()
            {
                Login = registerInfo.Login,
                PasswordHash = hash,
                PasswordSalt = salt,
            };

            var newUser = UserInfo.Create(
                registerInfo.FirstName,
                registerInfo.LastName,
                Domain.Enums.Role.User,
                settingInfo);

            using var transaction = _context.BeginTransaction();

            try
            {
                var entity = _context.Users.Add(newUser);
                await _context.SaveChangesAsync();
                await transaction.CommitAsync();
                return entity.Entity;
            }
            catch (Exception e)
            {
                await transaction.RollbackAsync();
                throw e;
            }
        }
    }
}