using Bankk2.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Курсовая;
using Bankk2.UpData;

namespace Bankk2.Controllers
{
    public class UserAccountController : Controller
    {
        private readonly DataBaseContext _baseContext;
        private readonly UserManager<IdentityUser> _userManager;
        public static string temp;
        public UserAccountController(DataBaseContext baseContext,
            UserManager<IdentityUser> userManager)
        {
            _baseContext = baseContext;
            _userManager = userManager;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult DataCard()
        {
            var user = _userManager.GetUserAsync(User);
            return View("~/Views/UserAccount/DataCard.cshtml", _baseContext.DataCard.Where(c=>c.UserEmail== user.Result.ToString()).ToList());
        }
        public IActionResult DataUsers()
        {
            return View();
        }
        public IActionResult Translation(DataUserS dataUser,
            string NumberPhone,
            string amount,
            DaraCard daraCard)
        {
            var user = _userManager.GetUserAsync(User);
            DateTime dateTime = DateTime.Now;
            var foo = _baseContext.DataUsers.FirstOrDefault(w => w.NumberPhone == dataUser.NumberPhone);
            var numberPhone = NumberPhone;
            var _amout = amount;
            var email = user.Result;
            var foo2 = _baseContext.DataCard.FirstOrDefault(w => w.UserEmail == user.Result.Email);
            double balance= foo2.Balance;
            if (foo == null)
            {
                //вернет страцику с ошибкой
            }
            else
            {
                if (balance >= float.Parse(amount))
                {
                    var data = new Tranzaction()
                    {
                        EmailSender = user.Result.ToString(),
                        EmailRecipient = foo.Email,
                        DateTime = dateTime,
                        Balance = amount                       
                    };
                    new UpDataTransaction(amount, email.ToString(), foo.Email);
                    _baseContext.Add(data);
                    _baseContext.SaveChanges();
                    return View("~/Views/UserAccount/TransactionTRUE.cshtml");
                }
                else
                {

                }
            }
            return View("~/Views/UserAccount/Translation.cshtml",_baseContext.Tranzaction.Where(w=>w.EmailSender == user.Result.ToString()));
        }
    }
}
