using System;
using System.Linq;

namespace MichalGarnczarskiEF
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj nazwę produktu:");
            string productName = Console.ReadLine();
            Product product = new Product { Name = productName };
            ProdContext prodContext = new ProdContext();
            prodContext.Products.Add(product);
            prodContext.SaveChanges();

            var query = from p in prodContext.Products
                        select p.Name;

            foreach (var item in query)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
