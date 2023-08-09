using _MaksKorz.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace _MaksKorz.Controllers
{
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;
		private readonly DataBaseContext _dataBase;

        public HomeController(DataBaseContext dataBase, ILogger<HomeController> logger)
        {
            _dataBase= dataBase;
            _logger = logger;
        }
        public async Task<IActionResult> Index()
        {
            return View(await _dataBase.albums.ToListAsync());
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