using System;

namespace MichalGarnczarskiHelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj liczbę:");
            try
            {
                int userValue = int.Parse(Console.ReadLine());
                Console.WriteLine($"Wartość int wpisana przez użytkownika to: \"{userValue}\".");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Podana wartość jest nieprawidłowa!");
            }
            Console.ReadKey();
        }
    }
}
