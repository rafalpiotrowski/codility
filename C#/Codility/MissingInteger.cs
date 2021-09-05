using System;

namespace Codility.MissingInteger
{
    /**
Analysis summary
The solution obtained perfect score.

Analysis
Detected time complexity:
O(N) or O(N * log(N))
    */
    public class Solution {
        public int solution(int[] A) {
            if(A == null || A.Length == 0) return 0;
            Array.Sort(A);
            int startIndex = Array.FindIndex(A, n => n > 0);
            if(startIndex == -1) return 1;
            int max = A[A.Length-1]; //the biggest number
            int first = A[startIndex];
            if (first > 1) return 1;
            int x, y = 0;
            //loop and check pairs {1, 2, 4} -> 1+1 == 2 -> 2+1 != 4 -> we have missing number
            for(int i = startIndex; i<A.Length-1; i++) {
                x = A[i];
                y = A[i+1];
                if( x == y ) continue;
                if( (x+1) != y ) return x+1;
            }
            return max+1;
        }
    }
}