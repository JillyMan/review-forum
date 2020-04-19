using AccessManagement.Api.Models;
using AccessManagement.Api.Services;
using AccessManagement.App.Models;
using AccessManagement.App.Services.User;
using AccessManagement.Domain.Entities;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace AccessManagement.Api.Controllers
{
    [Route("/api/users")]
    public class UserApiController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IUserService _userService;
        private readonly TokenProvider _tokenProvider;

        public UserApiController(IUserService userService, IMapper mapper, TokenProvider tokenProvider)
        {
            _mapper = mapper;
            _userService = userService;
            _tokenProvider = tokenProvider;
        }

        [HttpPost("authenticate")]
        public async Task<IActionResult> Authenticate([FromBody]AuthenticateInfoModel model)
        {
            var authorizeInfo = _mapper.Map<AuthenticateInfo>(model);
            
            var userInfo = await _userService.Authenticate(authorizeInfo);

            return Ok(GetIdentityWithToken(userInfo));
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody]RegisterInfoModel model)
        {
            var registerInfo = _mapper.Map<RegisterInfo>(model);

            var identityInfo = await _userService.Register(registerInfo);

            return Ok(GetIdentityWithToken(identityInfo));
        }

        public async Task<IActionResult> UpdateToken([FromBody]RefreshTokentModel refreshToken)
        {
            throw new System.NotImplementedException();
        }

        private IdentityInfoModel GetIdentityWithToken(UserInfo userInfo)
        {
            var payload = _mapper.Map<PayloadInfo>(userInfo);

            var token = _tokenProvider.GetToken(payload);

            return new IdentityInfoModel
            {
                Id = userInfo.Id,
                AccessToken = token.access,
                RefreshToken = token.access
            };
        }
    }
}
