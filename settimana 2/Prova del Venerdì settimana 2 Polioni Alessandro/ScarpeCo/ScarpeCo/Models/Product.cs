using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace ScarpeCo.Models
{
    public class Product
    {
        // ho aggiunto che i dati siano required per provare se fuzionava
        public int Id { get; set; }

        [Required(ErrorMessage = "Nome obbligatorio")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "prezzo obbligatorio")]
        [Range(0.01, double.MaxValue, ErrorMessage = "il prezzo deve essere superiore a 0")]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "è richiesta una descrizione")]
        //Ho aggiunto dei controlli anche alla lunghezza del testo della descrizione.
        [MinLength(10, ErrorMessage = "La descrizione è troppo corta")]
        [MaxLength(1000, ErrorMessage = "La descrrizione è troppo lunga")]
        public string? Description { get; set; }

        // gestisco le immagini in formato base64
        public string? CoverImageBase64 { get; set; }
        public string? Image1Base64 { get; set; }
        public string? Image2Base64 { get; set; }

        // gestisco i file delle immagini che verranno caricate alla creazione del nuovo prodotto
        [Required(ErrorMessage = "Immagine di Cover obbligatoria")]
        public IFormFile? CoverImageFile { get; set; }

        [Required(ErrorMessage = "immagine obbligatoria")]
        public IFormFile? Image1File { get; set; }

        [Required(ErrorMessage = "immagine obbligatoria")]
        public IFormFile? Image2File { get; set; }
    }
}
