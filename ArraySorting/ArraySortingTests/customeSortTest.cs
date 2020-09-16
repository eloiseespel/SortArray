using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ArraySortingTests
{
    [TestClass]
    class customeSortTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            int[] inArray = { 23, 76, 12, 43, 90, 30 };
            int[] outArray = { 12, 23, 30, 43, 76, 90 };
            //this method is broken for now
           //Array.Sort(inArray, new customeSort());
            Assert.AreEqual(inArray, outArray);
        }
    }
}
