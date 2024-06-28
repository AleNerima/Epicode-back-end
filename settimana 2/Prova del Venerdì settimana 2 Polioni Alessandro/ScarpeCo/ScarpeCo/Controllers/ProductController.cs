using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using ScarpeCo.Models;
using System;
using System.IO;
using System.Linq;

namespace ScarpeCo.Controllers
{
    public class ProductController : Controller
    {
        private readonly IWebHostEnvironment _hostEnvironment;

        public ProductController(IWebHostEnvironment hostEnvironment)
        {
            _hostEnvironment = hostEnvironment;
        }

        public IActionResult Index()
        {
            var products = ProductRepository.GetProducts();
            return View(products);
        }

        public IActionResult Details(int id)
        {
            var product = ProductRepository.GetProductById(id);
            if (product == null)
            {
                return NotFound();
            }
            return View(product);
        }

        public IActionResult Create()
        {
            return View();
        }
        //gestisco il form di creazione dei prodotti che vengono aggiunti
        [HttpPost]
        
        public IActionResult Create(Product product)
        {
            if (ModelState.IsValid)
            {
                if (product.CoverImageFile != null)
                {
                    product.CoverImageBase64 = ConvertToBase64(product.CoverImageFile);
                }
                if (product.Image1File != null)
                {
                    product.Image1Base64 = ConvertToBase64(product.Image1File);
                }
                if (product.Image2File != null)
                {
                    product.Image2Base64 = ConvertToBase64(product.Image2File);
                }

                product.Id = ProductRepository.GetProducts().Any() ? ProductRepository.GetProducts().Max(p => p.Id) + 1 : 1;
                ProductRepository.GetProducts().Add(product);
                return RedirectToAction(nameof(Index));
            }
            return View(product);
        }
        //converto i file immagine aggiunti in base64
        private string ConvertToBase64(Microsoft.AspNetCore.Http.IFormFile file)
        {
            // Utilizzo di MemoryStream per leggere i dati da IFormFile in un array di byte,
            // necessario per la conversione in una rappresentazione Base64 tramite Convert.ToBase64String.

            using (var memoryStream = new MemoryStream())
            {
                file.CopyTo(memoryStream); // i dati vengono copiati da file a memoryStream.
                var fileBytes = memoryStream.ToArray(); // si ottiene un array di byte dal memoryStream.
                return Convert.ToBase64String(fileBytes); // viene convertito l'array di byte in Base64.
            }
        }

    }
}
