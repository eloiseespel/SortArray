using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ArraySortingTests
{
    [TestClass]
    public class defaultSortTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            String[] strArray = { "I", "Am", "Learning", "Array", "Sorting", "In", "C#" };
            int[] intArray = { 23, 76, 12, 43, 90, 30 };
            int[] outArray = { 12, 23, 30, 43, 76, 90};
            Array.Sort(strArray);
            Assert.AreEqual(intArray, outArray);
        }
    }
}
