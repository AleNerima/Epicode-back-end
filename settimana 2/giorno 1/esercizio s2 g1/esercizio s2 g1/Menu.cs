using System;
using System.Collections.Generic;

namespace ConsoleMenuApp
{
    public class Menu
    {
        public List<MenuItem> Items { get; set; }
        public List<MenuItem> SelectedItems { get; set; }
        public double ServiceCharge { get; set; }

        public Menu()
        {
            Items = new List<MenuItem>
            {
                new MenuItem("Coca Cola 150 ml", 2.50),
                new MenuItem("Insalata di pollo", 5.20),
                new MenuItem("Pizza Margherita", 10.00),
                new MenuItem("Pizza 4 Formaggi", 12.50),
                new MenuItem("Pz patatine fritte", 3.50),
                new MenuItem("Insalata di riso", 8.00),
                new MenuItem("Frutta di stagione", 5.00),
                new MenuItem("Pizza fritta", 5.00),
                new MenuItem("Piadina vegetariana", 6.00),
                new MenuItem("Panino Hamburger", 7.90)
            };
            SelectedItems = new List<MenuItem>();
            ServiceCharge = 3.00;
        }

        public void DisplayMenu()
        {
            Console.WriteLine("==============MENU==============");
            for (int i = 0; i < Items.Count; i++)
            {
                Console.WriteLine($"{i + 1}:  {Items[i].Name} (€ {Items[i].Price:F2})");
            }
            Console.WriteLine("11: Stampa conto finale e conferma");
            Console.WriteLine("==============MENU==============");
        }

        public void AddItem(int itemNumber)
        {
            if (itemNumber >= 1 && itemNumber <= Items.Count)
            {
                SelectedItems.Add(Items[itemNumber - 1]);
                Console.WriteLine($"{Items[itemNumber - 1].Name} aggiunto al carrello.");
            }
            else
            {
                Console.WriteLine("Opzione non valida. Riprova.");
            }
        }

        public void PrintReceipt()
        {
            Console.WriteLine("\n=============CONTO==============");
            double total = 0;
            foreach (var item in SelectedItems)
            {
                Console.WriteLine($"{item.Name} (€ {item.Price:F2})");
                total += item.Price;
            }
            total += ServiceCharge;
            Console.WriteLine($"Servizio al tavolo (€ {ServiceCharge:F2})");
            Console.WriteLine($"Totale: \u20AC  {total:F2}");
            Console.WriteLine("================================");
        }

        public void StartOrdering()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            while (true)
            {
                DisplayMenu();
                Console.Write("Seleziona un'opzione: ");
                if (int.TryParse(Console.ReadLine(), out int choice))
                {
                    if (choice == 11)
                    {
                        PrintReceipt();
                        break;
                    }
                    else
                    {
                        AddItem(choice);
                    }
                }
                else
                {
                    Console.WriteLine("Inserisci un numero valido.");
                }
            }
        }
    }
}
