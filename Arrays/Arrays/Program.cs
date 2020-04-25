using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            generateArray();
        }

        private static void generateArray()
        {
            try
            {
                Console.WriteLine("Podaj rozmiar tablicy:");
                int arraySize = int.Parse(Console.ReadLine());
                Console.WriteLine("Podaj maksymalną wartość podaną w komórkach tablicy:");
                int maxValue = int.Parse(Console.ReadLine());
                int[] array = generateIntsArray(arraySize, maxValue);
                printArray(array);
            }
            catch (Exception e)
            {
                Console.WriteLine("Coś poszło nie tak...");
            }
        }

        private static int[] generateIntsArray(int arraySize, int maxValue)
        {
            int[] array = new int[arraySize];
            Random random = new Random();
            for (int i = 0; i < arraySize; i++)
            {
                array[i] = random.Next(maxValue);
            }
            return array;
        }

        private static void printArray(int[] array)
        {
            foreach (int number in array)
            {
                Console.Write(number + " ");
            }
        }
    }
}
