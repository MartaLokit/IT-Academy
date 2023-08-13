using Microsoft.AspNetCore.Mvc;

namespace Bankk2.Controllers
{
    public class UserAccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult DataCard()
        {
            return View("~/Views/UserAccount/DataCard.cshtml");
        }
        public IActionResult DataUsers()
        {
            return View();
        }
        public IActionResult Translation()
        {
            return View("~/Views/UserAccount/Translation.cshtml");
        }
    }
}
