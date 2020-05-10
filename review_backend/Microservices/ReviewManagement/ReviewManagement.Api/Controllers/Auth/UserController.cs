using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ReviewManagement.Api.Controllers
{
    [Authorize]
    public class UserController : Controller
    {
    }
}
