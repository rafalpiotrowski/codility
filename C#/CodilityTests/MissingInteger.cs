using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Codility;

namespace Codility.Tests
{
    [TestClass]
    public class MissingIntegerTests
    {
        [TestMethod]
        public void TestNumber1()
        {
            var c = new Codility.MissingInteger.Solution();
            int[] A = { 4, 1, 3, 2 };
            int result = c.solution(A);

            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void TestNumber2()
        {
            var c = new Codility.MissingInteger.Solution();
            int[] A = { 4, 1, 5, 3, 2 };
            int result = c.solution(A);

            Assert.AreEqual(6, result);
        }
        [TestMethod]
        public void TestNumber3()
        {
            var c = new Codility.MissingInteger.Solution();
            int[] A = { 1, 3, 6, 4, 1, 2 };
            int result = c.solution(A);

            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void TestNumber4()
        {
            var c = new Codility.MissingInteger.Solution();
            int[] A = { -4, 0, -1, -5  };
            int result = c.solution(A);

            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void TestNumber5()
        {
            var c = new Codility.MissingInteger.Solution();
            int[] A = { 1  };
            int result = c.solution(A);

            Assert.AreEqual(2, result);
        }

                [TestMethod]
        public void TestNumber6()
        {
            var c = new Codility.MissingInteger.Solution();
            int[] A = { 1, 1, 1  };
            int result = c.solution(A);

            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void TestNumber7()
        {
            var c = new Codility.MissingInteger.Solution();
            int[] A = { 100  };
            int result = c.solution(A);

            Assert.AreEqual(1, result);
        }
    }
}