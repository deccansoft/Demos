using NUnit.Framework;

namespace HelloWorldApp.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
        [Test()]
        public void AddTest()
        {
            MathOperations bm = new MathOperations();
            double res = bm.Add(10, 10);
            Assert.AreEqual(res, 20);
        }

        [Test()]
        public void SubtractTest()
        {
            MathOperations bm = new MathOperations();
            double res = bm.Subtract(10, 10);
            Assert.AreEqual(res, 0);
        }

        [Test()]
        public void DivideTest()
        {
            MathOperations bm = new MathOperations();
            double res = bm.Divide(10, 5);
            Assert.AreEqual(res, 2);
        }

        [Test()]
        public void MultiplyTest()
        {
            MathOperations bm = new MathOperations();
            double res = bm.Multiply(10, 5);
            Assert.AreEqual(res, 50);
        }

        [TestCase(1, 1, 2)]
        [TestCase(12, 30, 42)]
        [TestCase(14, 1, 15)]
        public void Test_AddWithTestCase(int a, int b, int expected)
        {
            MathOperations obj = new MathOperations();
            var actual = obj.Add(a, b);
            Assert.AreEqual(expected, actual);
        }

    }
}