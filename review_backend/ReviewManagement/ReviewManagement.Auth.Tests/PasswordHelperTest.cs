using FluentAssertions;
using ReviewManagement.App.Utils;
using Xunit;

namespace ReviewManagement.Tests
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
