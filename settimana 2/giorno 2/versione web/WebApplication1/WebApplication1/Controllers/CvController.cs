using Microsoft.AspNetCore.Mvc;
using CVWebApp.Models;

namespace CVWebApp.Controllers
{
    public class CVController : Controller
    {
        public IActionResult Index()
        {
            // Popolamento di un CV di esempio
            var cv = new CV
            {
                InformazioniPersonali = new InformazioniPersonali
                {
                    Nome = "Mario",
                    Cognome = "Rossi",
                    Telefono = "1234567890",
                    Email = "mario.rossi@example.com"
                },
                StudiEffettuati = new List<Studi>
                {
                    new Studi
                    {
                        Qualifica = "Laurea in Informatica",
                        Istituto = "Università degli Studi",
                        Tipo = "Laurea",
                        Dal = new DateTime(2010, 9, 1),
                        Al = new DateTime(2013, 7, 15)
                    }
                },
                EsperienzeLavorative = new List<Esperienza>
                {
                    new Esperienza
                    {
                        Azienda = "Tech S.p.A.",
                        JobTitle = "Software Developer",
                        Dal = new DateTime(2015, 1, 1),
                        Al = new DateTime(2020, 12, 31),
                        Descrizione = "Sviluppo di applicazioni web",
                        Compiti = "Analisi, progettazione, sviluppo e manutenzione di applicazioni"
                    }
                }
            };

            return View(cv);
        }
    }
}
