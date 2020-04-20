using AccessManagement.App;
using AccessManagement.App.Models;
using AccessManagement.App.Services.User;
using AccessManagement.App.Utils;
using AccessManagement.Domain.Entities;
using AccessManagement.Tests.Utils;
using Dasync.Collections;
using FluentAssertions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using Moq;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using Xunit;

namespace AccessManagement.Tests
{
    public class UserServiceTest
    {
        private IAccessManagementContext _dbMock;

        private readonly IQueryable<UserInfo> _mockedUsers;

        public UserServiceTest()
        {
            PasswordHelper.CreatePasswordHash("pass", out var hash, out var salt);

            _mockedUsers = new Utils.AsyncEnumerable<UserInfo>(
                new List<UserInfo>
                {
                    UserInfo.Create("1", "Artsiom", "Dub", "login", hash, salt, true),
                    UserInfo.Create("2", "sadkljasd", "dsadad", "login2", hash, salt, true)
                });

            SetUpDatabaseMock();
        }

        [Fact]
        public void GivenLoginAndPass_CallAuthorize_ReturnAuthorizeUserInfo()
        {
            var service = new UserService(_dbMock);
            var user = service.Authenticate(new AuthenticateInfo() { Login = "login", Password = "pass" }).Result;

            user.Should().NotBeNull();
            user.Id.Should().Be("1");
        }

        private void SetUpDatabaseMock()
        {
            var usersMock = new Mock<DbSet<UserInfo>>();

            usersMock.As<IQueryable<UserInfo>>().Setup(m => m.Provider).Returns(_mockedUsers.Provider);
            usersMock.As<IQueryable<UserInfo>>().Setup(m => m.Expression).Returns(_mockedUsers.Expression);
            usersMock.As<IQueryable<UserInfo>>().Setup(m => m.ElementType).Returns(_mockedUsers.ElementType);
            usersMock.As<IQueryable<UserInfo>>().Setup(m => m.GetEnumerator()).Returns(_mockedUsers.GetEnumerator());

            var dbMock = new Mock<IAccessManagementContext>();
            dbMock.SetupGet(x => x.Users).Returns(usersMock.Object);
            _dbMock = dbMock.Object;
        }
    }
}
