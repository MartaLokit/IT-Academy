using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Users.Models;

namespace Users.Controllers
{
    public class UserController : Controller
    {
        private readonly DBaseContext _dataBase;
        public UserController(DBaseContext dBase)
        {
            _dataBase = dBase;
        }
        public async Task<IActionResult> Index()
        {
            return View(await _dataBase.Users.ToListAsync());
        }
        public async Task AddCreate(User user)
        {
            await _dataBase.AddAsync(new User
            {
                Name = user.Name,
                LastName = user.LastName,
                Email = user.Email,
            });
            await _dataBase.SaveChangesAsync();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,LastName,Email")]User user)
        {
            if(ModelState.IsValid)
            {
                await AddCreate(user);
                return RedirectToAction(nameof(Index));
            }
            return View();
        }
    }
}
