using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;

namespace Cashe.Controllers
{
    public class CasheController : Controller
    {
        private const string KeyName = "CasheKeyName";
        private readonly IMemoryCache _memory;
        public CasheController(IMemoryCache memory)
        {
            _memory = memory;
        }
        [HttpGet("[action]")]
        public IActionResult SetCache(string? data, int second=10)
        {
            data ??= DateTime.Now.ToString("F");//формат времени   
            _memory.Set(KeyName, data, DateTime.Now.AddSeconds(second));
            return Ok($"Data in cache for {second}");
        }
        [HttpGet("[action]")]
        public IActionResult GetCache()
        {
            var isExsists= !_memory.TryGetValue(KeyName, out string? value);
            var message = isExsists
                ? "No data in cache"
                : $"Data in cache {value}";
            return Ok(message);
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
