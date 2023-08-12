using Bankk2.Areas.Identity.Pages.Account;
using Bankk2.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Bankk2.Controllers
{
    public class Home1Controller : Controller
    {
        UserManager<IdentityUser> userManager;
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly ILogger<Home1Controller> _logger;
        public Home1Controller(ILogger<Home1Controller> logger, SignInManager<IdentityUser> signInManager,
            ILogger<LoginModel> logger2,
            UserManager<IdentityUser> userManager)
        {
            _signInManager = signInManager;
            _userManager = userManager;
            _logger = logger;
        }

        public IActionResult Index()
        {
            var user = User;
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}