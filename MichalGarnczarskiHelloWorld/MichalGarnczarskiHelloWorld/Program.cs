using System;

namespace MichalGarnczarskiHelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wpisz coś...");
            string userValue = Console.ReadLine();
            Console.WriteLine("Wartość wpisana przez użytkownika to: \"" + userValue + "\"");
            Console.ReadKey();
        }
    }
}
