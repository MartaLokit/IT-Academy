using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Курсовая;

namespace Bankk2.Controllers
{
    public class UserAccountController : Controller
    {
        private readonly DataBaseContext2 _baseContext;
        private readonly UserManager<IdentityUser> _userManager;
        public UserAccountController(DataBaseContext2 baseContext,
            UserManager<IdentityUser> userManager)
        {
            _baseContext = baseContext;
            _userManager = userManager;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult DataCard()
        {
            var user = _userManager.GetUserAsync(User);
            return View("~/Views/UserAccount/DataCard.cshtml", _baseContext.DataCard.Where(c=>c.UserEmail=="tom2@gmail.com".ToString()).ToList());
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
