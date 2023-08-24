using Bankk2.DataBase;
using Bankk2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Data;
using System.Net;
using System.Xml.Linq;
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
        public async Task<IActionResult> DataCard()
        {
            return View("~/Views/Admin/DataCard.cshtml", await _baseContext.DataCard.ToListAsync());
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
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Index3(DataUserS dataUser)
        {
            var foo = _baseContext.DataUsers.FirstOrDefault(w => w.Email == dataUser.Email);
            if (foo == null)
            {
                _baseContext.Add(dataUser);
                _baseContext.SaveChanges();
                return RedirectToAction("AddNewUser");
               
            }
            return RedirectToAction("UserContains",new { email = dataUser.Email});
        }
        public IActionResult Index2(string email, DaraCard daraCard) 
        { 
            DateTime dateTime = DateTime.Now;
            CreateNumberCard numberCard = new CreateNumberCard();
            var data = new DaraCard()
            {
                CVV = Int32.Parse(numberCard.securitycode),
                CardNumber = numberCard.numbercard,
                BeforeDate = dateTime.AddYears(4).ToString(),
                UserEmail=email
            };
            _baseContext.Add(data);
            _baseContext.SaveChanges();
            return RedirectToAction("AddNewUser");
            //return $"Add card for'{email}',\nNumber card {numberCard.numbercard},\nSecurity code {numberCard.securitycode}";

        }
        //[HttpPost]
        //public ActionResult Create(DataCard dataCard)
        //{
        //    _baseContext.DataCard.Add(dataCard);
        //    _baseContext.SaveChanges();
        //    return RedirectToAction("Index2");
        //}
        //public IActionResult UserContains()
        //{
        //    //добавить представлениеж
        //}
        [HttpGet]
        public ActionResult UserContains(string email)
        {
            ViewBag.Message = email;
            return View();
        }
        [HttpGet]
        public ActionResult Delete(string? Email)
        {
            if (Email == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Movie movie = db.Movies.Find(Email);
            if (movie == null)
            {
                return HttpNotFound();
            }
            return View(movie);
        }
    }
}
