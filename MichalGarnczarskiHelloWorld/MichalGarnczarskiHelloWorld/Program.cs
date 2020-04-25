using System;

namespace MichalGarnczarskiHelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wpisz coś...");
            int userValue = int.Parse(Console.ReadLine());
            Console.WriteLine($"Wartość int wpisana przez użytkownika to: \"{userValue}\".");
            Console.ReadKey();
        }
    }
}
