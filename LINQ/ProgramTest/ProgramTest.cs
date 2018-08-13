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

        [TestMethod]
        public void AnyTest()
        {
            //arrange
            string s1 = "Hello World!";
            string s2 = "hello world!";

            //act
            var actual1 = LINQ.Program.AnyCapitals(s1);
            var actual2 = LINQ.Program.AnyCapitals(s2);

            //assert
            Assert.IsFalse(actual2);
            Assert.IsTrue(actual1);

        }


        [TestMethod]
        public void AllTest()
        {
            //arrange
            var s1 = "HELLO WORLD";
            var s2 = "Hello World!";

            //act
            var actual1 = LINQ.Program.AllCapitals(s1);
            var actual2 = LINQ.Program.AllCapitals(s2);

            //assert
            Assert.IsFalse(actual2);
            Assert.IsTrue(actual1);

        }

        [TestMethod]
        public void NumPairsTest()
        {
            //arrange

            var dict = new Dictionary<int, string>();
            

            dict.Add(9, "Value");
            dict.Add(92, "Value2");
            var expected = 2;
            //act
            var actual = LINQ.Program.NumPairs(dict);
            //assert
            Assert.AreEqual(actual, expected);
        }


        [TestMethod]
        public void NumPairsWithKeyValueTest()
        {
            //arrange

            var dict = new Dictionary<int, string>();

            dict.Add(0, "hello");
            dict.Add(1, "there");
            dict.Add(2, "yooo");
            var minKey = 0;
            var ValLenght = 10;
            var expected = 2;
            //act
            var actual = LINQ.Program.NumPairsWithKeyValue(dict, minKey, ValLenght);
            //assert
            Assert.AreEqual(actual, expected);
        }

        [TestMethod]

        public void GetDistinctWithValue()
        {
            var list = new List<double> { 1, 2, 3, 4, 5, 10, 11 };
            int x = 8;

            var expected = new List<double> { 1, 2, 3, 4, 5};

            //act

            var actual = LINQ.Program.GetDistinctWithValue(list, x);

            //assert
            CollectionAssert.AreEqual(actual, expected);
        }


        /*
        [TestMethod]

        public void FindFirstArrayWithLength()
        {
            List<int[]> arrList = new List<int[]>();
            int[] ArrayOfInts = new int[10];
            int[] ArrayOfInt2 = new int[10];
            arrList.Add(ArrayOfInts);
            arrList.Add(ArrayOfInt2);
            var x = 8;



        }

        */

        [TestMethod]

        public void GetLastOddElementTest()
        {
            int[] scores = new int[] { 97, 92, 81, 60 };

            var expected = 81;

            //act

            var actual = LINQ.Program.GetLastOddElement(scores);

            //assert
            Assert.AreEqual(actual, expected);
        }


        }

    }

