using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Codility;

namespace Codility.Tests
{
    [TestClass]
    public class CountDivTests
    {
        [TestMethod]
        public void TestNumber1()
        {
            var c = new Codility.CountDiv.Solution();
            int result = c.solution(6, 11, 2); // 6, 7, 8 , 9 , 10 , 11

            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void TestNumber2()
        {
            var c = new Codility.CountDiv.Solution();
            int result = c.solution(1, 1, 11); 

            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void TestNumber3()
        {
            var c = new Codility.CountDiv.Solution();
            int result = c.solution(11, 345, 17); 

            Assert.AreEqual(20, result);
        }
    }
}