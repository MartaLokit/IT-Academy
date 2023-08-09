using Microsoft.AspNetCore.Mvc;

namespace Lesson13.KnowledgeCheck.Controllers
{
	public class HomeController : Controller
	{
		public IActionResult Index()
		{
			return View("~Views/Product/MyIndex.cshtml");
		}
	}
}
