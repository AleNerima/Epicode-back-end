using System.Collections.Generic;

namespace RistoranteApp.Models
{
    public class Menu
    {
        public List<MenuItem> Items { get; set; }
        public List<MenuItem> SelectedItems { get; set; }
        public double ServiceCharge { get; set; } = 3.00;

        public Menu()
        {
            Items = new List<MenuItem>
            {
                new MenuItem { Id = 1, Name = "Coca Cola 150 ml", Price = 2.50 },
                new MenuItem { Id = 2, Name = "Insalata di pollo", Price = 5.20 },
                new MenuItem { Id = 3, Name = "Pizza Margherita", Price = 10.00 },
                new MenuItem { Id = 4, Name = "Pizza 4 Formaggi", Price = 12.50 },
                new MenuItem { Id = 5, Name = "Pz patatine fritte", Price = 3.50 },
                new MenuItem { Id = 6, Name = "Insalata di riso", Price = 8.00 },
                new MenuItem { Id = 7, Name = "Frutta di stagione", Price = 5.00 },
                new MenuItem { Id = 8, Name = "Pizza fritta", Price = 5.00 },
                new MenuItem { Id = 9, Name = "Piadina vegetariana", Price = 6.00 },
                new MenuItem { Id = 10, Name = "Panino Hamburger", Price = 7.90 }
            };
            SelectedItems = new List<MenuItem>();
        }

        public void AddItem(int itemId)
        {
            var item = Items.Find(i => i.Id == itemId);
            if (item != null)
            {
                SelectedItems.Add(item);
            }
        }

        public double CalculateTotal()
        {
            double total = ServiceCharge;
            foreach (var item in SelectedItems)
            {
                total += item.Price;
            }
            return total;
        }
    }
}
