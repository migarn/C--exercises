using System;
using System.Collections;
using System.Diagnostics;

namespace Arrays
{
    class Program
    {
        static Stopwatch stopwatch = new Stopwatch();

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

                //Console.WriteLine("\nTablica z wartościami posortowanymi metodą sortowania bąbelkowego (sortowanie zajęło " + BubbleSort(array) + "):");
                //PrintArray(array);

                Console.WriteLine("\nTablica z wartościami posortowanymi metodą sortowania przez wstawianie (sortowanie zajęło " + InsertSort(array) + "):");
                PrintArray(array);

                //Console.WriteLine("\nTablica z wartościami posortowanymi metodą sortowania przez wybieranie (sortowanie zajęło " + SelectionSort(array) + "):");
                //PrintArray(array);
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

        private static TimeSpan BubbleSort(int[] array)
        {
            stopwatch.Start();
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
            stopwatch.Stop();
            return stopwatch.Elapsed;
        }

        private static TimeSpan InsertSort(int[] array)
        {
            stopwatch.Start();
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
                        break;
                    }
                }

                if (!inserted)
                {
                    sortedArrayList.Add(currentElement);
                }
            }

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = (int)sortedArrayList[i];
            }
            stopwatch.Stop();
            return stopwatch.Elapsed;
        }

        private static TimeSpan SelectionSort(int[] array)
        {
            stopwatch.Start();

            for (int i = 0; i < array.Length - 1; i++)
            {
                int[] minimumValueAndIndex = FindMinimumInRange(array, i + 1);
                int minimum = minimumValueAndIndex[0];
                int minimumIndex = minimumValueAndIndex[1];

                if (minimum < i)
                {
                    int auxiliaryVariable = array[i];
                    array[i] = minimum;
                    array[minimumIndex] = auxiliaryVariable;
                }
            }
            stopwatch.Stop();
            return stopwatch.Elapsed;
        }

        private static int[] FindMinimumInRange(int[] array, int firstIndex)
        {
            int[] result = new int[2];
            int minimum = array[firstIndex];
            int minimumIndex = firstIndex;

            for (int i = firstIndex; i < array.Length; i++)
            {
                if (array[i] < minimum)
                {
                    minimum = array[i];
                    minimumIndex = i;
                }
            }

            result[0] = minimum;
            result[1] = minimumIndex;

            return result;
        }
    }
}
