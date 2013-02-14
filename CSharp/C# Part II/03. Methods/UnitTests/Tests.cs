using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Occurrence;
using Hi;


namespace UnitTests
{
    [TestClass]
    public class Tests
    {
        [TestMethod]
        public void TestNumberOccurrences()
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 2, 3, 1, 3 };
            int real = NumberOccurrences.CountOccurrences(arr, 10);
            int expected = 0;
            Assert.AreEqual(real, expected);
        }

        [TestMethod]
        public void TestHello()
        {
            string name = "Pesho";
            string real = HelloTestProgram.Hello(name);
            string expected = "Hello, Pesho!";
            Assert.AreEqual(real, expected);
        }
    }
}