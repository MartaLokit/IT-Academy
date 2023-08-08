using Microsoft.AspNetCore.Mvc;

namespace Курсовая.Controllers
{
    public class UserAccountController : Controller
    {
        public IActionResult Operation()
        {
            return View("~/Views/UserAccount/Operation.cshtml");
        }
        public IActionResult Payment()
        {
            return View("~/Views/UserAccount/Payment.cshtml");
        }
        public IActionResult Translation()
        {
            return View("~/Views/UserAccount/Translation.cshtml");
        }
    }
}
