using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Codility;

namespace Codility.Tests
{
    [TestClass]
    public class BinGapTests
    {
        /**
        number 9 has binary representation 1001 and contains a binary gap of length 2
        */
        [TestMethod]
        public void TestNumber9()
        {
            var c = new Codility.BinGap.Solution();
            Assert.AreEqual(2, c.solution(9));
        }

        /**
        number 529 has binary representation 1000010001 and contains two binary gaps: one of length 4 and one of length 3
        */
        [TestMethod]
        public void TestNumber529()
        {
            var c = new Codility.BinGap.Solution();
            Assert.AreEqual(4,c.solution(529));
        }

        /**
        number 20 has binary representation 10100 and contains one binary gap of length 1
        */
        [TestMethod]
        public void TestNumber20()
        {
            var c = new Codility.BinGap.Solution();
            Assert.AreEqual(1,c.solution(20));
        }

        /**
        number 15 has binary representation 1111 and has no binary gaps
        */
        [TestMethod]
        public void TestNumber15()
        {
            var c = new Codility.BinGap.Solution();
            Assert.AreEqual(0,c.solution(15));
        }

        /**
        number 32 has binary representation 100000 and has no binary gaps
        */
        [TestMethod]
        public void TestNumber32()
        {
            var c = new Codility.BinGap.Solution();
            Assert.AreEqual(0,c.solution(32));
        }
    }
}
