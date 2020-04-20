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

        public Task<UserInfo> Register(RegisterInfo registerInfo)
        {
            UserInfo.Create("", registerInfo.FirstName, )

            throw new NotImplementedException();
        }
    }
}