using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;
using CourseWork;

namespace Курсовая.Controllers
{
    public class AuthorizationController : Controller
    {
        private readonly DataBaseContext _baseContext;
        public AuthorizationController(DataBaseContext baseContext)
        {
            _baseContext = baseContext;
        }
        public async Task<IActionResult> Index()
        {
            var user = _baseContext.DataUsers.Include(c => c.ID);
            return View("~/Views/Authorization/Index.cshtml", await _baseContext.DataUsers.ToListAsync());
        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(string txtEmail, string txtNumberPhone)
        {
            if (txtEmail.ToLower() == "admin" && (txtNumberPhone == "123"))
            {
                var claims = new List<Claim>()
                {
                    new Claim(ClaimTypes.Name,txtEmail)
                };
                var identity = new ClaimsIdentity(
                    claims, CookieAuthenticationDefaults.AuthenticationScheme);
                var principal = new ClaimsPrincipal(identity);
                var props = new AuthenticationProperties();
                HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal, props).Wait();
                return RedirectToAction("Index", "Employee");
            }
            else
            {
                return View();
            }
            
        }
        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync();
            return RedirectToAction("Index");
        }
    }
}
