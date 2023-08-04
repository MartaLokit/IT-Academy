using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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
    }
}
