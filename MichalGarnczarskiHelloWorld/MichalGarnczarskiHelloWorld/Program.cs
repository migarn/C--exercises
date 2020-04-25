using System;

namespace MichalGarnczarskiHelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Podaj pierwszą liczbę:");
                double firstNumber = double.Parse(Console.ReadLine());
                Console.WriteLine("Podaj drugą liczbę:");
                double secondNumber = double.Parse(Console.ReadLine());
                Console.WriteLine("Suma podanych liczb jest równa: " + (firstNumber + secondNumber));
            }
            catch (Exception e)
            {
                Console.WriteLine("Coś poszło nie tak...");
            }
            Console.ReadKey();            
        }
    }
}
