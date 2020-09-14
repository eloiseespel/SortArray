using System;

namespace ArraySorting
{
    class defaultSort
    {
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
