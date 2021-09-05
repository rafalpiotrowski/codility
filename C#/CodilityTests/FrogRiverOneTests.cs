using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Codility;

namespace Codility.Tests
{
    [TestClass]
    public class FrogRiverOneTests
    {
        [TestMethod]
        public void TestNumber1()
        {
            var c = new Codility.FrogRiverOne.Solution();
            int[] A = { 1, 3, 1, 4, 2, 3, 5, 4 };
            int result = c.solution(5, A);

            Assert.AreEqual(6, result);
        }
        [TestMethod]
        public void TestNumber2()
        {
            var c = new Codility.FrogRiverOne.Solution();
            int[] A = { 1, 3, 1, 4, 2, 3, 6, 5 };
            int result = c.solution(5, A);

            Assert.AreEqual(7, result);
        }
    }
}