using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ReviewManagement.Api.Models;
using ReviewManagement.Api.Models.Create;
using ReviewManagement.App.Infrastructure.Token;
using ReviewManagement.App.Models;
using ReviewManagement.App.Services.User;
using ReviewManagement.Domain.Entities;
using ReviewManagement.Domain.Entities.Security;
using ReviewManagement.Domain.Enums;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace ReviewManagement.Api.Controllers
{
    [Route("/api/users")]
    public class UserApiController : BaseController
    {
        private readonly IUserService _userService;
        private readonly ITokenService _tokenProvider;

        public UserApiController(IUserService userService, ITokenService tokenProvider)
        {
            _userService = userService;
            _tokenProvider = tokenProvider;
        }

        [HttpPost("auth")]
        public async Task<IActionResult> PostAuthenticate([FromBody]AuthenticateInfoModel model)
        {
            var authorizeInfo = Mapper.Map<AuthenticateInfo>(model);

            var userInfo = await _userService.Authenticate(authorizeInfo);

            return Ok(await GetIdentityWithToken(userInfo));
        }

        [HttpPost("registration")]
        public async Task<IActionResult> PostRegister([FromBody]UserCreateModel model)
        {
            var registerInfo = Mapper.Map<RegisterInfo>(model);

            var identityInfo = await _userService.Register(registerInfo);

            return Ok(await GetIdentityWithToken(identityInfo));
        }

        [HttpPost("token_update")]
        public async Task<IActionResult> PostUpdateToken([FromBody]AuthTokenResponse refreshToken)
        {
            throw new System.NotImplementedException();
        }

        [HttpGet("test")]
        [Authorize(Roles = "User")]
        public IActionResult Test()
        {
            var identity = HttpContext.User.Identity as ClaimsIdentity;
            return Ok(new { message = "Hi user by id: " + identity.Name });
        }

        private async Task<TokenInfo> GetIdentityWithToken(UserInfo userInfo)
        {
            var token = await _tokenProvider.CreateToken(userInfo);
            return token;
        }
    }
}
