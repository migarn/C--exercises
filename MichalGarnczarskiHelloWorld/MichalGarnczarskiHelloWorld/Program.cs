using System;

namespace MichalGarnczarskiHelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj pierwszą liczbę:");
            double firstNumber = double.Parse(Console.ReadLine());
            Console.WriteLine("Podaj drugą liczbę:");
            double secondNumber = double.Parse(Console.ReadLine());
            Console.WriteLine("Suma podanych liczb jest równa: " + (firstNumber + secondNumber));
            Console.ReadKey();            
        }
    }
}
