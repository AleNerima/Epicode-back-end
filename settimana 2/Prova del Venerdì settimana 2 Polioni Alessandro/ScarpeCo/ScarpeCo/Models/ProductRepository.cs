using System.Collections.Generic;

namespace ScarpeCo.Models
{
    public static class ProductRepository
    {
        private static List<Product> products = new List<Product>
        {
            //creo una lista statica di prodotti 
            new Product
            {
                Id = 1,
                Name = "Scarpe Nike",
                Price = 99.99m,
                Description = "Scarpe di alta qualità, da usare tutti i giorni, comode anche per fare sport.",
                CoverImageBase64 = GetBase64DefaultImage("nike.jpg"),//recupero le immagini dalla cartella img e le trasformo in formato base
                Image1Base64 = GetBase64DefaultImage("scarpa1.jpg"),
                Image2Base64 = GetBase64DefaultImage("scarpa2.jpg")
            },
            
        };

        //metodo per convertire le immagini in wwwroot in base64
        private static string GetBase64DefaultImage(string fileName)
        {
            string imagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "img", fileName);
            byte[] imageBytes = System.IO.File.ReadAllBytes(imagePath);
            return Convert.ToBase64String(imageBytes);
        }

        public static List<Product> GetProducts()
        {
            return products;
        }

        public static Product? GetProductById(int id)
        {
            return products.Find(p => p.Id == id);
        }
    }
}
