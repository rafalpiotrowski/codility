using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Codility;

namespace Codility.Tests
{
    [TestClass]
    public class TemplateSolutionTests
    {
        [TestMethod]
        public void TestNumber1()
        {
            var c = new Codility.TemplateSolution.Solution();
            int[] A = { 4, 1, 3, 2 };
            int result = c.solution(A);

            Assert.AreEqual(1, result);
        }
    }
}