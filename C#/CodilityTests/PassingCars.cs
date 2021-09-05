using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Codility;

namespace Codility.Tests
{
    [TestClass]
    public class PassingCarsTests
    {
        [TestMethod]
        public void TestNumber1()
        {
            var c = new Codility.PassingCars.Solution();
            int[] A = { 0, 1, 0, 1, 1 };
            int result = c.solution(A);

            Assert.AreEqual(5, result);
        }
    }
}