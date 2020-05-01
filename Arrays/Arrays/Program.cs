using System;
using System.Collections;
using System.Diagnostics;

namespace Arrays
{
    class Program
    {
        

        static void Main(string[] args)
        {
            int[] array = GenerateArray();

            int[] array2 = (int[])array.Clone();
            int[] array3 = (int[])array.Clone();
            int[] array4 = (int[])array.Clone();
            int[] array5 = (int[])array.Clone();

            Console.WriteLine("\nTablica z nieposortowanymi wartościami:");
            PrintArray(array);

            //Console.WriteLine("\nTablica z wartościami posortowanymi metodą sortowania bąbelkowego (sortowanie zajęło " + MeasureTime(() => BubbleSort(array2)) + "):");
            //PrintArray(array2);

            //Console.WriteLine("\nTablica z wartościami posortowanymi metodą sortowania przez wstawianie (sortowanie zajęło " + MeasureTime(() => InsertSort(array3)) + "):");
            //PrintArray(array3);

            //Console.WriteLine("\nTablica z wartościami posortowanymi metodą sortowania przez wybieranie (sortowanie zajęło " + MeasureTime(() => SelectionSort(array4)) + "):");
            //PrintArray(array4);

            Console.WriteLine("\nTablica z wartościami posortowanymi metodą Quick Sort (sortowanie zajęło " + MeasureTime(() => QuickSort(array5)) + "):");
            PrintArray(array5);
        }

        private static int[] GenerateArray()
        {
            try
            {
                Console.WriteLine("Podaj rozmiar tablicy:");
                int arraySize = int.Parse(Console.ReadLine());
                Console.WriteLine("Podaj maksymalną wartość podaną w komórkach tablicy:");
                int maxValue = int.Parse(Console.ReadLine());
                return GenerateIntsArray(arraySize, maxValue);
            }
            catch (Exception e)
            {
                Console.WriteLine("Coś poszło nie tak...");
                return null;
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
        }

        private static void SelectionSort(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                int[] minimumValueAndIndex = FindMinimumInRange(array, i + 1);
                int minimum = minimumValueAndIndex[0];
                int minimumIndex = minimumValueAndIndex[1];

                if (minimum < array[i])
                {
                    int auxiliaryVariable = array[i];
                    array[i] = minimum;
                    array[minimumIndex] = auxiliaryVariable;
                }
            }
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

        private static void QuickSort(int[] array)
        {
            QuickSortRecursion(array, 0, array.Length - 1);
        }

        private static void QuickSortRecursion(int[] array, int begin, int end)
        {
            int i = (begin + end) / 2;
            int pivot = array[i];
            array[i] = array[end];
            int j = begin;

            for (i = begin; i < end - 1; i++)
            {
                if (array[i] < pivot)
                {
                    int auxiliaryVariable = array[i];
                    array[i] = array[j];
                    array[j] = auxiliaryVariable;
                    j++;
                }
            }

            array[end] = array[j];
            array[j] = pivot;

            if (begin < j - 1)
            {
                QuickSortRecursion(array, begin, j - 1);
            }

            if (end > j + 1)
            {
                QuickSortRecursion(array, j + 1, end);
            }
        }

        private static TimeSpan MeasureTime(Action action)
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            action();
            stopwatch.Stop();
            return stopwatch.Elapsed;
        }
    }
}
