using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Codility;

namespace Codility.Tests
{
    [TestClass]
    public class MaxCountersTests
    {
        [TestMethod]
        public void TestNumber1()
        {
            var c = new Codility.MaxCounters.Solution();
            int[] A = { 3, 4, 4, 6, 1, 4, 4};
            int[] result = c.solution(5, A);
            Utils.PrintIntArray("result", result);
            int[] expected = { 3,2,2,4,2};
            Assert.IsTrue(Utils.ArraysAreSame(expected, result));
        }
    }
}