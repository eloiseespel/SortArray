using System;

namespace ArraySorting
{
    class defaultSort
    {
        public static void Main()
        {
            String[] strArray = { "I", "Am", "Learning", "Array", "Sorting", "In", "C#" };
            int[] intArray = { 23, 76, 12, 43, 90, 30 };
            Array.Sort(strArray);
            Array.Sort(intArray);
            Console.WriteLine("Sorted String Array:\n");
            DisplayArray(strArray);
            Console.WriteLine("\n\n\nSorted Integer Array:\n");
            DisplayArray(intArray);
        }
        static void DisplayArray(string[] arr)
        {
            foreach (string a in arr)
            {
                Console.Write(a + "\t");
            }
        }
        static void DisplayArray(int[] arr)
        {
            foreach (int a in arr)
            {
                Console.Write(a + "\t");
            }
        }
    }
}
