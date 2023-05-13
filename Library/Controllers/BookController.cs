using Bogus;
using Library.DataBase;
using Library.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace Library.Controllers
{
    public class BookController : Controller
    {
        //Add for git
        private AddNewBook book=new AddNewBook();
        private Realization realization = new Realization();
        public IActionResult Index(int? id, int? testId)
        {
            string res = "";
            SelectData strings = new SelectData();
            foreach (var item in strings)
            {
                res += item;
            }
            return View("~/Views/Books/Index.cshtml", strings.datas);
        }
        /*public IActionResult Index(int? id, int? testId)
        {
            return View("~/Views/Books/Index.cshtml",realization.book);
        }*/
        [HttpPost]
        public void Index(string LFName, string NameBook,string GenreBook)
        {
            book.AddDataAuthor(LFName);
            
        }
        public string Welcome()
        {
            int i = 0;
            for (i = 0; i < 6; i++)
            {
                return i.ToString();
            }
            return i.ToString();
        }
    }
}
