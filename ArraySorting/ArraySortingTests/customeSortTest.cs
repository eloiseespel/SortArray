using System;
using System.Collections.Generic;
using System.Text;

namespace ArraySortingTests
{
    class customeSortTest
    {
        int[] intArray = { 23, 76, 12, 43, 90, 30 };
        int[] outArray = { 12, 23, 30, 43, 76, 90 };
        Array.Sort(intArray, new DescendingComparer());
        AreEqual(inArray, outArray);
    }
}
