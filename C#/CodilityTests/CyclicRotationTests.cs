using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Codility;

namespace CodilityTests
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

            PrintIntArray("Input", A);
            PrintIntArray("Result", result);
            Assert.IsTrue(result == correctResult);
        }
        [TestMethod]
        public void TestNumberK1()
        {
            var c = new Codility.CyclicRotation.Solution();
            int[] A = { 0, -9 };
            int K = 1;
            int[] correctResult = {-9, 0};
            int[] result = c.solution(A, K);

            PrintIntArray("Input", A);
            PrintIntArray("Result", result);
            Assert.IsTrue(result == correctResult);
        }

        private void PrintIntArray(String txt, int[] array) {
            Console.Write(txt);
            Console.Write(" = { ");
            for(int i = 0; i<array.Length; i++) {
                Console.Write("{0}, ", array[i]);
            }
            Console.WriteLine("}");
        }
    }
}