using AccessManagement.Api.Models;
using AccessManagement.App.Infrastructure.Token;
using AccessManagement.App.Models;
using AccessManagement.App.Services.User;
using AccessManagement.App.Utils;
using AccessManagement.Domain.Entities;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace AccessManagement.Api.Controllers
{
    [Route("/api/users")]
    public class UserApiController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IUserService _userService;
        private readonly ITokenService _tokenProvider;

        public UserApiController(IUserService userService, IMapper mapper, ITokenService tokenProvider)
        {
            _mapper = mapper;
            _userService = userService;
            _tokenProvider = tokenProvider;
        }

        [Authorize]
        [HttpPost("authenticate")]
        public async Task<IActionResult> PostAuthenticate([FromBody]AuthenticateInfoModel model)
        {
            var authorizeInfo = _mapper.Map<AuthenticateInfo>(model);

            var userInfo = await _userService.Authenticate(authorizeInfo);

            return Ok(GetIdentityWithToken(userInfo));
        }

        [HttpPost("register")]
        public async Task<IActionResult> PostRegister([FromBody]RegisterInfoModel model)
        {
            var registerInfo = _mapper.Map<RegisterInfo>(model);

            var identityInfo = await _userService.Register(registerInfo);

            return Ok(GetIdentityWithToken(identityInfo));
        }

        [HttpPost("token_update")]
        public async Task<IActionResult> PostUpdateToken([FromBody]RefreshTokentModel refreshToken)
        {
            throw new System.NotImplementedException();
        }

        private async Task<TokenInfo> GetIdentityWithToken(UserInfo userInfo)
        {
            var payload = _mapper.Map<PayloadInfo>(userInfo);

            var token = await _tokenProvider.CreateToken(payload);

            return token;
        }
    }
}
