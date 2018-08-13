using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ProgramTest
{
    [TestClass]
    public class ProgramTest
    {
        [TestMethod]
        public void SelectTest()
        {
            //arrange
            var list = new List<int> { 1, 2, 3 };
            var expected = new List<int> { 2, 3, 4 };

            //act
            var actual = LINQ.Program.Increment(list);

            //assert
            CollectionAssert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void WhereTest()
        {
            //arrange
            var list = new List<int> { 1, 2, 3, 4, 5};
            int x = 2;
            var expected = new List<int> { 2, 4 };

            //act
            var actual = LINQ.Program.GetWhereDivisibleBy(list, x);

            //assert
            CollectionAssert.AreEqual(expected, actual);

        }

    }
}
