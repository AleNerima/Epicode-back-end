using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using Cinema.Models;

namespace Cinema.Controllers
{
    public class BigliettiController : Controller
    {
        private static List<Biglietto> biglietti = new List<Biglietto>();
        private static List<Sala> sale = new List<Sala>
        {
            new Sala { Nome = "SALA NORD", CapienzaMassima = 120 },
            new Sala { Nome = "SALA EST", CapienzaMassima = 60 },
            new Sala { Nome = "SALA SUD", CapienzaMassima = 20 }
        };

        public IActionResult Index()
        {
            return View(sale);
        }

        public IActionResult Crea()
        {
            ViewBag.Sale = sale;
            return View();
        }

        [HttpPost]
        public IActionResult Crea(Biglietto biglietto)
        {
            var sala = sale.FirstOrDefault(s => s.Nome == biglietto.Sala);
            if (sala != null && sala.BigliettiVenduti < sala.CapienzaMassima)
            {
                biglietti.Add(biglietto);
                sala.BigliettiVenduti++;
                if (biglietto.Ridotto)
                {
                    sala.BigliettiRidottiVenduti++;
                }
                return RedirectToAction("Index");
            }
            else
            {
                // Gestisco il caso in cui la sala dovesse aver esaurito i posti
                ModelState.AddModelError(string.Empty, "Sala piena");
                ViewBag.Sale = sale;
                return View(biglietto);
            }
        }
    }
}
