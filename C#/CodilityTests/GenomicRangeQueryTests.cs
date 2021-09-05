using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Codility;

namespace Codility.Tests
{
    [TestClass]
    public class GenomicRangeQueryTests
    {
        [TestMethod]
        public void TestNumber1()
        {
            var c = new Codility.GenomicRangeQuery.Solution();
            var S = "CAGCCTA"; // {2, 1, 3, 2, 2, 4, 1} 
            int[] P = { 2, 5, 0 };
            int[] Q = { 4, 5, 6 };
            int[] result = c.solution(S, P, Q);
            int[] expected = {2, 4, 1};

            Assert.AreEqual(true, Utils.ArraysAreSame(result, expected));
        }
    }
}