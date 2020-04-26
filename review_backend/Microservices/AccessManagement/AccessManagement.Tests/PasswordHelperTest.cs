using AccessManagement.App.Utils;
using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace AccessManagement.Tests
{
    public class PasswordHelperTest
    {
        [Fact]
        public void GivenPass_Check_ReturnValidHash()
        {
            PasswordHelper.CreatePasswordHash("passssss", out var hash, out var salt);

            PasswordHelper.VerifyPasswordHash("passssss", hash, salt).Should().BeTrue();
        }
    }
}
