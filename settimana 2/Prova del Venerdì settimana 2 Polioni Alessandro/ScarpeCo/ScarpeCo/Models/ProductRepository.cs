using System.Collections.Generic;

namespace ScarpeCo.Models
{
    public static class ProductRepository
    {
        private static List<Product> products = new List<Product>
        {
            new Product
            {
                Id = 1,
                Name = "Tennis Shoe 1",
                Price = 99.99m,
                Description = "A high-quality tennis shoe.",
                CoverImageBase64 = GetBase64DefaultImage("nike.jpg"),
                Image1Base64 = GetBase64DefaultImage("scarpa1.jpg"),
                Image2Base64 = GetBase64DefaultImage("scarpa2.jpg")
            },
            
        };
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
