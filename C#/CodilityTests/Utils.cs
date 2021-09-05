using System;
using System.Collections.Generic;

namespace Codility.Tests
{
    public static class Utils {
        public static void PrintIntArray(String txt, int[] array) {
            Console.Write(txt);
            Console.Write(" = { ");
            for(int i = 0; i<array.Length; i++) {
                Console.Write("{0}, ", array[i]);
            }
            Console.WriteLine("}");
        }

        public static bool ArraysAreSame(int[] a1, int[] a2) {
            if(a1 != null && a2 != null) {
                if(a1.Length == a2.Length) {
                    for(int i=0; i<a1.Length; i++) {
                        if(a1[i] != a2[i]) return false;
                    }
                    return true;
                }
                return false;
            }
            return true;
        }

        private static int[] GetArray(int n, int lower, int upper)
        {
            Random rnd = new Random();
            List<int> list = new List<int>();
            for (int ctr = 1; ctr <= n; ctr++)
                list.Add(rnd.Next(lower, upper + 1));

            return list.ToArray();
        }
    }
}