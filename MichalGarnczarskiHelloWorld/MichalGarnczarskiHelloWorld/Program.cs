using System;

namespace MichalGarnczarskiHelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Boolean inLoop = true;
            while (inLoop) {
                operateOnTwoDoubles();
                Console.WriteLine("Jeśli chcesz przerwać wpisz \"n\", jeśli chcesz kontynuować wpisz dowolny inny ciąg znaków.");
                string insertedString = Console.ReadLine();
                if (insertedString.Equals("n"))
                {
                    inLoop = false;
                    Console.WriteLine("Program przerwany.");
                }
            }
            Console.ReadKey();
        }

        private static void operateOnTwoDoubles()
        {
            try
            {
                Console.WriteLine("Wpisz pierwszą liczbę:");
                double firstNumber = double.Parse(Console.ReadLine());
                Console.WriteLine("Wpisz drugą liczbę:");
                double secondNumber = double.Parse(Console.ReadLine());
                Console.WriteLine("Wpisz znak działania (\"+\" albo \"-\" albo \"*\" albo \":\"):");
                string operation = Console.ReadLine();

                switch (operation)
                {
                    case "+":
                        Console.WriteLine("Suma podanych liczb jest równa: " + (firstNumber + secondNumber));
                        break;
                    case "-":
                        Console.WriteLine("Różnica podanych liczb jest równa: " + (firstNumber - secondNumber));
                        break;
                    case "*":
                        Console.WriteLine("Iloczyn podanych liczb jest równy: " + (firstNumber * secondNumber));
                        break;
                    case ":":
                        Console.WriteLine("Iloraz podanych liczb jest równa: " + (firstNumber / secondNumber));
                        break;
                    default:
                        throw new Exception();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Coś poszło nie tak...");
            }
        }
    }
}
