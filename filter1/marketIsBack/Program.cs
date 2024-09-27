using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _323_matvelickov_marketIsBack
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Product> products = new List<Product>
{
    new Product { Location = 1, Producer = "Bornand", ProductName = "Pommes", Quantity = 20,Unit = "kg", PricePerUnit = 5.50 },
    new Product { Location = 1, Producer = "Bornand", ProductName = "Poires", Quantity = 16,Unit = "kg", PricePerUnit = 5.50 },
    new Product { Location = 1, Producer = "Bornand", ProductName = "Pastèques", Quantity = 14,Unit = "pièce", PricePerUnit = 5.50 },
    new Product { Location = 1, Producer = "Bornand", ProductName = "Melons", Quantity = 5,Unit = "kg", PricePerUnit = 5.50 },
    new Product { Location = 2, Producer = "Dumont", ProductName = "Noix", Quantity = 20,Unit = "sac", PricePerUnit = 5.50 },
    new Product { Location = 2, Producer = "Dumont", ProductName = "Raisin", Quantity = 6,Unit = "kg", PricePerUnit = 5.50 },
    new Product { Location = 2, Producer = "Dumont", ProductName = "Pruneaux", Quantity = 13,Unit = "kg", PricePerUnit = 5.50 },
    new Product { Location = 2, Producer = "Dumont", ProductName = "Myrtilles", Quantity = 12,Unit = "kg", PricePerUnit = 5.50 },

};
            var i18n = new Dictionary<string, string>()
            {
                { "Pommes","Apples"},
                { "Poires","Pears"},
                { "Pastèques","Watermelons"},
                { "Melons","Melons"},
                { "Noix","Nuts"},
                { "Raisin","Grapes"},
                { "Pruneaux","Plums"},
                { "Myrtilles","Blueberries"},
                { "Groseilles","Berries"},
                { "Tomates","Tomatoes"},
                { "Courges","Pumpkins"},
                { "Pêches","Peaches"},
                { "Haricots","Beans"}
            };

            var name = products.Select(a => a.Producer.Remove(a.Producer.Length - 4) + "..." + a.Producer[a.Producer.Length - 1]);
            var englishProduct = products.Select(a => a.ProductName = i18n[a.ProductName]);
            var price = products.Select(a => a.PricePerUnit *= a.Quantity);
            
            foreach (var a in name)
            {
                Console.Write($"{a}  ");
            }
            Console.WriteLine();
            foreach (var b in englishProduct)
            {
                Console.Write($"{b}  ");
            }
            Console.WriteLine();
            foreach (var c in price)
            {
                Console.Write($"{c}  ");
            }
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
