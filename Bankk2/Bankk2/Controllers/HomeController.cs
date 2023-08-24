using Bankk2.Areas.Identity.Pages.Account;
using Bankk2.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using Курсовая;

namespace Bankk2.Controllers
{
    public class HomeController : Controller
    {
        UserManager<IdentityUser> userManager;
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly ILogger<Home1Controller> _logger;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly DataBaseContext _baseContext;
        public HomeController(ILogger<Home1Controller> logger, SignInManager<IdentityUser> signInManager,
            ILogger<LoginModel> logger2,
            UserManager<IdentityUser> userManager,
            RoleManager<IdentityRole> roleManager, DataBaseContext baseContext)
        {
            _signInManager = signInManager;
            _userManager = userManager;
            _logger = logger;
            _roleManager = roleManager;
            _baseContext = baseContext;
        }
        //"
        public void OnGet()
        {
            _logger.LogInformation("About page visited at {DT}",
                DateTime.UtcNow.ToLongTimeString());
        }
        public async Task<IActionResult> Index()
        {
            var user = await _userManager.GetUserAsync(User);
            if (user != null)
            {
                var roles2 = await _userManager.GetRolesAsync(user);
                var isAdmin = await _userManager.IsInRoleAsync(user, "Admin");
                var book = _baseContext.DataUsers.Where(c => c.Email == roles2.ToString()).Distinct();
               
                return View("~/Views/Home/Index1.cshtml", await _baseContext.DataUsers.Where(c => c.Email == user.ToString()).ToListAsync());
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