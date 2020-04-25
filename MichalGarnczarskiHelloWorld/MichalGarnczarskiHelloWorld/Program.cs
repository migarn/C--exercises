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
            Console.WriteLine("Wartość stringa wpisana na stałe to: \"{0}\", a wartość wprowadzona przez użytkownika to: \"{1}\".", helloMessage, userValue);
            Console.ReadKey();
        }
    }
}
