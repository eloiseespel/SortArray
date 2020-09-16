using System;
using System.Collections.Generic;
using System.Text;

namespace ArraySorting
{
    class customeSort : System.Collections.IComparer
    {
        public int Compare(Object a, Object b)
        {
            return (new System.Collections.CaseInsensitiveComparer()).Compare(b, a);
        }
    }
    public class Program
    {
        public static void Main()
        {
            String[] strArray = { "I", "Am", "Learning", "Array", "Sorting", "In", "C#" };
            int[] intArray = { 23, 76, 12, 43, 90, 30 };
            Array.Sort(strArray, new DescendingComparer());
            Array.Sort(intArray, new DescendingComparer());
            Console.WriteLine("Sorted String Array in Descending Order:\n");
            DisplayArray(strArray);
            Console.WriteLine("\n\n\nSorted Integer Array in Desc Order:\n");
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
