using Microsoft.VisualStudio.TestTools.UnitTesting;
using HelloWorldApp;
using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorldApp.Tests
{
    [TestClass()]
    public class MathOperationsTests
    {
        [TestMethod()]
        public void AddTest()
        {
            MathOperations bm = new MathOperations();
            double res = bm.Add(10, 10);
            Assert.AreEqual(res, 20);
        }

        [TestMethod()]
        public void SubtractTest()
        {
            MathOperations bm = new MathOperations();
            double res = bm.Subtract(10, 10);
            Assert.AreEqual(res, 0);
        }

        [TestMethod()]
        public void DivideTest()
        {
            MathOperations bm = new MathOperations();
            double res = bm.Divide(10, 5);
            Assert.AreEqual(res, 2);
        }

        [TestMethod()]
        public void MultiplyTest()
        {
            MathOperations bm = new MathOperations();
            double res = bm.Multiply(10, 5);
            Assert.AreEqual(res, 50);
        }
        [DataTestMethod]
        [DataRow(1, 1, 2)]
        [DataRow(12, 30, 42)]
        [DataRow(14, 1, 15)]
        public void Test_AddWithDataRow(int a, int b, int expected)
        {
            MathOperations obj = new MathOperations();
            var actual = obj.Add(a, b);
            Assert.AreEqual(expected, actual);
        }

    }
}