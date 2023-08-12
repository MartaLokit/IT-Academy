using Bankk2.Areas.Identity.Pages.Account;
using Bankk2.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Bankk2.Controllers
{
    public class HomeController : Controller
    {
        UserManager<IdentityUser> userManager;
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly ILogger<Home1Controller> _logger;
        private readonly RoleManager<IdentityRole> _roleManager;
        public HomeController(ILogger<Home1Controller> logger, SignInManager<IdentityUser> signInManager,
            ILogger<LoginModel> logger2,
            UserManager<IdentityUser> userManager,
            RoleManager<IdentityRole> roleManager)
        {
            _signInManager = signInManager;
            _userManager = userManager;
            _logger = logger;
            _roleManager = roleManager;
        }
        public async Task<IActionResult> Index()
        {
            var user = await _userManager.GetUserAsync(User);
            if (user != null)
            {
                var roles2 = await _userManager.GetRolesAsync(user);
                var isAdmin = await _userManager.IsInRoleAsync(user, "Admin");
            }
            var roles = _roleManager.Roles;
            return View();
        }
        [Authorize(Roles = "Admin")]
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