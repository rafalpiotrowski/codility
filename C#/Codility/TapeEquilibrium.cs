using System;

namespace Codility.TapeEquilibrium
{
    //Detected time complexity: O(N * N)  53% correct failed on large data set
    public class Solution {
        public int solution(int[] A) {
            int smallestSum = -1;
            int maxSum = 0;
            for(int i=0; i<A.Length; i++) {
                maxSum += A[i];
            }

            for(int p=0; p<A.Length-1; p++)
            {
                int left = SumPartition(A, p);
                int right = maxSum - left;
                int x = Math.Abs(left - right);
                Console.WriteLine("{0} - {1} = {2}", left, right, x);
                if(smallestSum != -1) {
                    if (x < smallestSum) {
                        smallestSum = x;
                    }
                } else smallestSum = x;
            }
            return smallestSum;
        }

        private static int SumPartition(int[] A, int p) {
            if (p == 0) return A[p];
            int l = 0;
            for(int i=0; i<p; i++) l += A[i];
            return l;
        }
    }
}