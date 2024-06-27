using Microsoft.AspNetCore.Mvc;
using CinemaMultisala.Models;
using System.Linq;

namespace CinemaMultisala.Controllers
{
    public class PrenotazioneController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Sale = DataStore.Sale.Values.ToList();
            return View();
        }

        public IActionResult Prenota()
        {
            ViewBag.Sale = DataStore.Sale.Values.ToList();
            return View();
        }

        [HttpPost]
        public IActionResult Prenota(string nome, string cognome, string sala, bool ridotto)
        {
            if (DataStore.Sale[sala].BigliettiVenduti < DataStore.Sale[sala].Capienza)
            {
                var utente = new Utente { Nome = nome, Cognome = cognome };
                var prenotazione = new Prenotazione { Utente = utente, Sala = sala, Ridotto = ridotto };
                DataStore.Prenotazioni.Add(prenotazione);
            }
            return RedirectToAction("Index");
        }
    }
}
