using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Курсовая.Controllers
{
    [Authorize]
    public class TransitionController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
