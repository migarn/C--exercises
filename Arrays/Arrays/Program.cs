using System;
using System.Collections;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            GenerateArray();
        }

        private static void GenerateArray()
        {
            try
            {
                Console.WriteLine("Podaj rozmiar tablicy:");
                int arraySize = int.Parse(Console.ReadLine());
                Console.WriteLine("Podaj maksymalną wartość podaną w komórkach tablicy:");
                int maxValue = int.Parse(Console.ReadLine());
                int[] array = GenerateIntsArray(arraySize, maxValue);

                Console.WriteLine("\nTablica z nieposortowanymi wartościami:");
                PrintArray(array);

                Console.WriteLine("\nTablica z posortowanymi wartościami (sortowanie bąbelkowe):");
                BubbleSort(array);
                PrintArray(array);

                Console.WriteLine("\nTablica z posortowanymi wartościami (sortowanie przez wstawianie):");
                InsertSort(array);
                PrintArray(array);
            }
            catch (Exception e)
            {
                Console.WriteLine("Coś poszło nie tak...");
            }
        }

        private static int[] GenerateIntsArray(int arrayLength, int maxValue)
        {
            int[] array = new int[arrayLength];
            Random random = new Random();
            for (int i = 0; i < arrayLength; i++)
            {
                array[i] = random.Next(maxValue);
            }
            return array;
        }

        private static void PrintArray(int[] array)
        {
            foreach (int number in array)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
        }

        private static void BubbleSort(int[] array)
        {
            Boolean isSorting = true;
            while (isSorting)
            {
                isSorting = false;
                for (int i = 0; i < array.Length - 1; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        int auxiliaryVariable = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = auxiliaryVariable;
                        isSorting = true;
                    }
                }
            }
        }

        private static void InsertSort(int[] array)
        {
            ArrayList sortedArrayList = new ArrayList();
            sortedArrayList.Add(array[0]);

            for (int i = 1; i < array.Length; i++)
            {
                int currentElement = array[i];
                Boolean inserted = false;

                foreach (int j in sortedArrayList)
                {
                    if (currentElement <= j)
                    {
                        sortedArrayList.Insert(sortedArrayList.IndexOf(j), currentElement);
                        inserted = true;
                        return;
                    }
                }

                if (!inserted)
                {
                    sortedArrayList.Add(currentElement);
                }
            }

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = (int) sortedArrayList[i];
            }
        }
    }
}
