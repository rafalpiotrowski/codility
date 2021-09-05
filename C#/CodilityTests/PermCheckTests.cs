using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Codility;

namespace Codility.Tests
{
    [TestClass]
    public class PermCheckTests
    {
        [TestMethod]
        public void TestNumber1()
        {
            var c = new Codility.PermCheck.Solution();
            int[] A = { 4, 1, 3, 2 };
            int result = c.solution(A);

            Assert.AreEqual(1, result);
        }
        [TestMethod]
        public void TestNumber2()
        {
            var c = new Codility.PermCheck.Solution();
            int[] A = { 4, 1, 3 };
            int result = c.solution(A);

            Assert.AreEqual(0, result);
        }
        [TestMethod]
        public void TestNumber3()
        {
            var c = new Codility.PermCheck.Solution();
            int[] A = { 4 };
            int result = c.solution(A);

            Assert.AreEqual(0, result);
        }
        [TestMethod]
        public void TestNumber4()
        {
            var c = new Codility.PermCheck.Solution();
            int[] A = {  };
            int result = c.solution(A);

            Assert.AreEqual(0, result);
        }
        [TestMethod]
        public void TestNumber5()
        {
            var c = new Codility.PermCheck.Solution();
            int[] A = { 1, 4, 1 };
            int result = c.solution(A);

            Assert.AreEqual(0, result);
        }
    }
}