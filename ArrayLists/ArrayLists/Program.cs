using System;
using System.Collections;

namespace ArrayLists
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList firstList = new ArrayList();
            ArrayList secondList = new ArrayList();
            fillInList(firstList, 10);
            Console.WriteLine("Lista wyjściowa:");
            printList(firstList);
            separateArraysValues(firstList, secondList);
            Console.WriteLine("Lista pierwsza:");
            printList(firstList);
            Console.WriteLine("Lista druga:");
            printList(secondList);
        }

        private static void fillInList(ArrayList arrayList, int length)
        {
            for (int i = 0; i < length; i++)
            {
                Console.WriteLine("Wprowadź liczbę numer " + (i + 1) + ":");
                int.TryParse(Console.ReadLine(), out int readNumber);
                arrayList.Add(readNumber);
            }
        }

        private static void separateArraysValues(ArrayList filledList, ArrayList emptyList)
        {
            int currentIndex = 0;
            int length = filledList.Count;
            while (currentIndex < length) {
                int currentItem = (int) filledList[currentIndex];
                if (currentItem < 2)
                {
                    filledList.Remove(currentItem);
                    length = filledList.Count;
                }
                else
                {
                    emptyList.Add(currentItem);
                    currentIndex++;
                }
            }
        }

        private static void printList(ArrayList arrayList)
        {
            foreach (var item in arrayList)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}
