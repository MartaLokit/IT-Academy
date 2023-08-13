using Bankk2.DataBase;
using Bankk2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Банковская_система.DataBase;
using Курсовая;

namespace Bankk2.Controllers
{
    public class AdminController : Controller
    {
        private readonly DataBaseContext _baseContext;
        public AdminController(DataBaseContext baseContext)
        {
            _baseContext = baseContext;
        }
        [HttpPost]
        public async Task<IActionResult> Index(string searchString, bool notUsed)
        {
            //return "From [HttpPost]Index: filter on " + searchString;
            return View("~/Views/Admin/DataUser.cshtml", await _baseContext.DataUsers.Where(c => c.Surname == searchString.ToString()).ToListAsync());
        }
        public async Task<IActionResult> DataUser()
        {
            return View("~/Views/Admin/DataUser.cshtml", await _baseContext.DataUsers.ToListAsync());
        }
        public IActionResult DataCard()
        {
            return View();
        }
        public IActionResult AddNewUser()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        
        public string Index2(string email) 
        {
            CreateNumberCard numberCard = new CreateNumberCard();
            StaticDataCard.CVV = Int32.Parse(numberCard.securitycode);
            StaticDataCard.CardNumber = numberCard.numbercard;
            StaticDataCard.UserEmail = email;
            AddDataCard addData = new AddDataCard();
            addData.Registration();
            return $"Add card for'{StaticDataCard.UserEmail}',\nNumber card {StaticDataCard.CardNumber},\nSecurity code {StaticDataCard.CVV}";
            //var contact = _baseContext.DataCard.ToList();
            //return View(contact);
        }
        //[HttpPost]
        //public ActionResult Create(DataCard dataCard)
        //{
        //    _baseContext.DataCard.Add(dataCard);
        //    _baseContext.SaveChanges();
        //    return RedirectToAction("Index2");
        //}

    }
}
