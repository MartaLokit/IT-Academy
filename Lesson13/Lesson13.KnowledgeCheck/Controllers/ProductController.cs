using Lesson13.KnowledgeCheck.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Lesson13.KnowledgeCheck.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        private readonly DataBaseContext _dataBase;
        public ProductController(DataBaseContext dataBase)
        {
            _dataBase = dataBase;
        }
        public async Task<IActionResult> Index()
        {
            
            //return View(products);
             return View(await _dataBase.products.ToListAsync());
        }

        // GET: Product/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Product/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Description,Price")] Product product)
        {
            if (ModelState.IsValid)
            {
                // TODO: IMPLEMENT. SAVE PRODUCT IN THE DATABASE (repository)
                return RedirectToAction(nameof(Index));
            }
            return View();
        }

        // GET: Product/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            
            Product product = new Product(); // TODO: REPLACE IT. FIND IT IN THE DATABASE (repository)
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        // POST: Product/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            // TODO: IMPLEMENT. ADD REMOVING LOGIC FROM THE DB (repository)
            return RedirectToAction(nameof(Index));
        }
    }
}
