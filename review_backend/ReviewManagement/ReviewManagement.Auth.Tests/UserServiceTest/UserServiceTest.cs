using FluentAssertions;
using Microsoft.EntityFrameworkCore;
using Moq;
using ReviewManagement.App.Infrastructure;
using ReviewManagement.App.Models;
using ReviewManagement.App.Services.User;
using ReviewManagement.App.Utils;
using ReviewManagement.Domain.Entities;
using ReviewManagement.Domain.Entities.Security;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace ReviewManagement.Tests
{
    public class UserServiceTest
    {
        private IReviewManagementContext _dbMock;

        private readonly IQueryable<UserInfo> _mockedUsers;

        public UserServiceTest()
        {
            PasswordHelper.CreatePasswordHash("pass", out var hash, out var salt);

            _mockedUsers = new Utils.AsyncEnumerable<UserInfo>(
                new List<UserInfo>
                {
                    new UserInfo() {
                        Id = 1,
                        FirstName = "Artsiom",
                        LastName = "Dub",
                        UserSettingInfo = new UserSettingInfo()
                        {
                            Login = "login",
                            PasswordHash = hash,
                            PasswordSalt = salt
                        },
                    },
                    new UserInfo() {
                        Id = 1,
                        FirstName = "sadkljasd",
                        LastName = "dsadad",
                        UserSettingInfo = new UserSettingInfo()
                        {
                            Login = "login2",
                            PasswordHash = hash,
                            PasswordSalt = salt
                        }
                    }
                });

            SetUpDatabaseMock();
        }

        [Fact]
        public void GivenLoginAndPass_CallAuthorize_ReturnAuthorizeUserInfo()
        {
            var service = new UserService(_dbMock);
            var user = service.Authenticate(new AuthenticateInfo() { Login = "login", Password = "pass" }).Result;

            user.Should().NotBeNull();
            user.Id.Should().Be(1);
        }

        private void SetUpDatabaseMock()
        {
            var usersMock = new Mock<DbSet<UserInfo>>();
            usersMock.As<IQueryable<UserInfo>>().Setup(m => m.Provider).Returns(_mockedUsers.Provider);
            usersMock.As<IQueryable<UserInfo>>().Setup(m => m.Expression).Returns(_mockedUsers.Expression);
            usersMock.As<IQueryable<UserInfo>>().Setup(m => m.ElementType).Returns(_mockedUsers.ElementType);
            usersMock.As<IQueryable<UserInfo>>().Setup(m => m.GetEnumerator()).Returns(_mockedUsers.GetEnumerator());

            var dbMock = new Mock<IReviewManagementContext>();
            dbMock.SetupGet(x => x.Users).Returns(usersMock.Object);
            _dbMock = dbMock.Object;
        }
    }
}
