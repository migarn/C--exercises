using System;

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
        }
    }
}
