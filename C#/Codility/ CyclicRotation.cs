using System;

namespace Codility.CyclicRotation {
    public class Solution {
        public int[] solution(int[] A, int K) {
            if(K == 0) return A;
            if(A.Length < 2) return A;
            if(A.Length == 2) {
                int[] newA = new int[2];
                newA[0] = A[1];
                newA[1] = A[0];
                return solution(newA, --K);
            } else {
                int[] newA = new int[A.Length];
                newA[0] = A[A.Length-1];
                for(int i=1; i<=A.Length-1; i++) {
                    newA[i] = A[i-1];
                }

                return solution(newA, --K);
            }
        }
    }
}