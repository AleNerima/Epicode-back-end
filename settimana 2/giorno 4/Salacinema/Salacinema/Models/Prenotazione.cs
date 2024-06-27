namespace CinemaMultisala.Models
{
    public class Prenotazione
    {
        public Utente? Utente { get; set; }
        public string? Sala { get; set; }
        public bool Ridotto { get; set; }
    }
}
