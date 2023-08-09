using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Book.Controllers
{
    public class BookController : Controller
    {
        private readonly DataBaseContext _baseContext;
        public BookController(DataBaseContext baseContext)
        {
            _baseContext = baseContext;
        }
        public async Task<IActionResult> Index()
        {
            var book = _baseContext.author.Include(c => c.Id);
            //return View("~/Views/Books/Index.cshtml", book.ToList());
            return View("~/Views/Books/Index.cshtml", await _baseContext.book.ToListAsync());
        }
    }
}
