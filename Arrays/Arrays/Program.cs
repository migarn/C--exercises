using System;
using System.Collections;

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

                Console.WriteLine("Tablica z nieposortowanymi wartościami:");
                printArray(array);

                Console.WriteLine("Tablica z posortowanymi wartościami:");
                bubbleSort(array);
                printArray(array);

                Console.WriteLine("Tablica z posortowanymi wartościami:");
                insertSort(array);
                //printArray(array);
            }
            catch (Exception e)
            {
                Console.WriteLine("Coś poszło nie tak...");
            }
        }

        private static int[] generateIntsArray(int arrayLength, int maxValue)
        {
            int[] array = new int[arrayLength];
            Random random = new Random();
            for (int i = 0; i < arrayLength; i++)
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
            Console.WriteLine();
        }

        private static void bubbleSort(int[] array)
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

        private static void insertSort(int[] array)
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

            foreach (int i in sortedArrayList)
            {
                Console.WriteLine(i);
            }

            //for (int i = 1; i < array.Length; i++)
            //{
            //    array[i] = sortedArrayList.[i];
            //}
        }
    }
}
