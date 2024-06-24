using Microsoft.AspNetCore.Mvc;
using RistoranteApp.Models;

namespace RistoranteApp.Controllers
{
    public class MenuController : Controller
    {
        private static Menu _menu = new Menu();

        public IActionResult Index()
        {
            return View(_menu);
        }

        [HttpPost]
        public IActionResult AddItem(int itemId)
        {
            _menu.AddItem(itemId);
            return RedirectToAction("Index");
        }

        public IActionResult Receipt()
        {
            ViewBag.Total = _menu.CalculateTotal();
            return View(_menu);
        }
    }
}
