using System.Linq;

namespace CinemaMultisala.Models
{
    public class Sala
    {
        public string? Nome { get; set; }
        public int Capienza { get; set; }
        public int BigliettiVenduti
        {
            get
            {
                return DataStore.Prenotazioni.Count(p => p.Sala == Nome);
            }
        }
        public int BigliettiRidotti
        {
            get
            {
                return DataStore.Prenotazioni.Count(p => p.Sala == Nome && p.Ridotto);
            }
        }
    }
}
