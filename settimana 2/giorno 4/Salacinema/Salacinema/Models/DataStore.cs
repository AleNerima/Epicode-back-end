using System.Collections.Generic;

namespace CinemaMultisala.Models
{
    public static class DataStore
    {
        public static List<Prenotazione> Prenotazioni = new List<Prenotazione>();
        public static Dictionary<string, Sala> Sale = new Dictionary<string, Sala>
        {
            { "SALA NORD", new Sala { Nome = "SALA NORD", Capienza = 120 } },
            { "SALA EST", new Sala { Nome = "SALA EST", Capienza = 120 } },
            { "SALA SUD", new Sala { Nome = "SALA SUD", Capienza = 120 } }
        };
    }
}
