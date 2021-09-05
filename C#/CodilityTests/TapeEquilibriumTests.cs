using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Codility;

namespace Codility.Tests
{
    [TestClass]
    public class TapeEquilibriumTests
    {
        [TestMethod]
        public void TestNumber4()
        {
            var c = new Codility.TapeEquilibrium.Solution();
            int[] A = { 3, 1, 2, 4, 3 };
            int result = c.solution(A);

            Utils.PrintIntArray("Input", A);
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void TestNumber2()
        {
            var c = new Codility.TapeEquilibrium.Solution();
            int[] A = { 3, 1 };
            int result = c.solution(A);

            Utils.PrintIntArray("Input", A);
            Assert.AreEqual(2, result);
        }

    }
}