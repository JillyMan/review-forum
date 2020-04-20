using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AccessManagement.Api.Controllers
{
    [Authorize]
    public class UserController : Controller
    {
    }
}
