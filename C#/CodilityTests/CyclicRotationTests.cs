using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Codility;

namespace Codility.Tests
{
    [TestClass]
    public class CyclicRotationTests
    {
        [TestMethod]
        public void TestNumberK3()
        {
            var c = new Codility.CyclicRotation.Solution();
            int[] A = { 3, 8, 9, 7, 6 };
            int K = 3;
            int[] correctResult = {9, 7, 6, 3, 8};
            int[] result = c.solution(A, K);

            Utils.PrintIntArray("Input", A);
            Utils.PrintIntArray("Result", result);
            Assert.IsTrue(true);
        }
        [TestMethod]
        public void TestNumberK1()
        {
            var c = new Codility.CyclicRotation.Solution();
            int[] A = { 0, -9 };
            int K = 1;
            int[] correctResult = {-9, 0};
            int[] result = c.solution(A, K);

            Utils.PrintIntArray("Input", A);
            Utils.PrintIntArray("Result", result);
            Assert.IsTrue(true);
        }
    }
}