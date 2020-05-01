using System;
using System.Collections;
using System.Diagnostics;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            launch();
        }

        private static void launch()
        {
            try
            {
                int[] array = GenerateArray();
                Console.WriteLine("\nTablica z nieposortowanymi wartościami:");
                PrintArray(array);
                Console.WriteLine("\nWybierz:" +
                    "\n1 - sortowanie bąbelkowe" +
                    "\n2 - sortowanie przez wstawianie" +
                    "\n3 - sortowanie przez wybieranie" +
                    "\n4 - quick sort" +
                    "\n5 - wszystkie powyższe + pomiar czasu sortowania");

                int choice = int.Parse(Console.ReadLine());

                if (choice > 5 || choice < 1)
                {
                    throw new Exception("Wrong value.");
                }

                int[] clonedArray = (int[])array.Clone();

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("\nTablica z wartościami posortowanymi metodą sortowania bąbelkowego (sortowanie zajęło " + MeasureTime(() => BubbleSort(clonedArray)) + "):");
                        PrintArray(clonedArray);
                        break;
                    case 2:
                        Console.WriteLine("\nTablica z wartościami posortowanymi metodą sortowania przez wstawianie (sortowanie zajęło " + MeasureTime(() => InsertSort(clonedArray)) + "):");
                        PrintArray(clonedArray);
                        break;
                    case 3:
                        Console.WriteLine("\nTablica z wartościami posortowanymi metodą sortowania przez wybieranie (sortowanie zajęło " + MeasureTime(() => SelectionSort(clonedArray)) + "):");
                        PrintArray(clonedArray);
                        break;
                    case 4:
                        Console.WriteLine("\nTablica z wartościami posortowanymi metodą Quick Sort (sortowanie zajęło " + MeasureTime(() => QuickSort(clonedArray)) + "):");
                        PrintArray(clonedArray);
                        break;
                    case 5:
                        int[] clonedArray2 = (int[])array.Clone();
                        int[] clonedArray3 = (int[])array.Clone();
                        int[] clonedArray4 = (int[])array.Clone();
                        Console.WriteLine("\nTablica z wartościami posortowanymi metodą sortowania bąbelkowego (sortowanie zajęło " + MeasureTime(() => BubbleSort(clonedArray)) + "):");
                        PrintArray(clonedArray);
                        Console.WriteLine("\nTablica z wartościami posortowanymi metodą sortowania przez wstawianie (sortowanie zajęło " + MeasureTime(() => InsertSort(clonedArray2)) + "):");
                        PrintArray(clonedArray2);
                        Console.WriteLine("\nTablica z wartościami posortowanymi metodą sortowania przez wybieranie (sortowanie zajęło " + MeasureTime(() => SelectionSort(clonedArray3)) + "):");
                        PrintArray(clonedArray3);
                        Console.WriteLine("\nTablica z wartościami posortowanymi metodą Quick Sort (sortowanie zajęło " + MeasureTime(() => QuickSort(clonedArray4)) + "):");
                        PrintArray(clonedArray4);
                        break;
                }

                Console.WriteLine("\nWybierz:" +
                    "\n1 - aby wyszukać zadaną liczbę w tablicy" +
                    "\n2 - aby zakończyć");

                try
                {
                    choice = int.Parse(Console.ReadLine());

                    if (choice > 2 || choice < 1)
                    {
                        throw new Exception("Wrong value.");
                    }

                    if (choice == 1)
                    {
                        Console.WriteLine("\nWpisz liczbę do wyszukania:");

                        try
                        {
                            int number = int.Parse(Console.ReadLine());
                            Boolean inArray = BinarySearch(clonedArray, number);

                            if (inArray)
                            {
                                Console.WriteLine("\nLiczba znajduje się w tablicy");
                            }
                            else
                            {
                                Console.WriteLine("\nLiczba nie znajduje się w tablicy");
                            }
                        }
                        catch (Exception e)
                        {
                            throw new Exception("Wrong value.");
                        }
                    }
                }
                catch (Exception e)
                {
                    throw new Exception("Wrong value.");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Coś poszło nie tak...");
            }
        }

        private static int[] GenerateArray()
        {
            try
            {
                Console.WriteLine("Podaj rozmiar tablicy:");
                int arraySize = int.Parse(Console.ReadLine());
                Console.WriteLine("\nPodaj maksymalną wartość podaną w komórkach tablicy:");
                int maxValue = int.Parse(Console.ReadLine());
                return GenerateIntsArray(arraySize, maxValue);
            }
            catch (Exception e)
            {
                throw new Exception("Wrong value.");
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

            for (i = begin; i < end; i++)
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

        private static Boolean BinarySearch(int[] array, int numberToFind)
        {
            return BinarySearchRecursion(array, numberToFind, 0, array.Length - 1);
        }

        private static Boolean BinarySearchRecursion(int[] array, int numberToFind, int begin, int end)
        {
            if (begin == end)
            {
                if (array[begin] == numberToFind)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            int number = array[(end + begin) / 2];        

            if (numberToFind > number)
            {
                return BinarySearchRecursion(array, numberToFind, (end + begin) / 2 + 1, end);
            }

            else if (numberToFind < number)
            {
                return BinarySearchRecursion(array, numberToFind, begin, (end + begin) / 2 - 1);
            }

            else
            {
                return true;
            }
        }
    }
}
