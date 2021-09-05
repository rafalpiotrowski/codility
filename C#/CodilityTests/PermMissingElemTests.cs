using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Codility;

namespace Codility.Tests
{
    [TestClass]
    public class PermMissingElemTests
    {
        [TestMethod]
        public void TestNumber4()
        {
            var c = new Codility.PermMissingElem.Solution();
            int[] A = { 2, 3, 1, 5 };
            int result = c.solution(A);

            Utils.PrintIntArray("Input", A);
            Assert.IsTrue(result == 4);
        }

        [TestMethod]
        public void TestNumber10()
        {
            var c = new Codility.PermMissingElem.Solution();
            int[] A = { 2, 3, 1, 5, 8, 6, 7, 9, 11, 4 };
            int result = c.solution(A);

            Utils.PrintIntArray("Input", A);
            Assert.IsTrue(result == 10);
        }


    }
}