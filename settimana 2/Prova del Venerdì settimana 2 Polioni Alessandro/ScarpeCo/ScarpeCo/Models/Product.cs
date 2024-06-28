using Microsoft.AspNetCore.Http;

namespace ScarpeCo.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public decimal Price { get; set; }
        public string? Description { get; set; }
        public string? CoverImageBase64 { get; set; }
        public string? Image1Base64 { get; set; }
        public string? Image2Base64 { get; set; }

        public IFormFile? CoverImageFile { get; set; }
        public IFormFile? Image1File { get; set; }
        public IFormFile? Image2File { get; set; }

       }
}
