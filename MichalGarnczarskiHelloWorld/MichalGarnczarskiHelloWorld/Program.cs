using System;

namespace MichalGarnczarskiHelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wpisz coś...");
            string userValue = Console.ReadLine();
            string helloMessage = "Cała naprzód!";
            Console.WriteLine($"Wartość stringa wpisana na stałe to: \"{helloMessage}\", a wartość wprowadzona przez użytkownika to: \"{userValue}\".");
            Console.ReadKey();
        }
    }
}
