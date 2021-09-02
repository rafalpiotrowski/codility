using System;
namespace Codility.OddOccurrencesInArray
{
    public class Solution {
        public int solution(int[] A) {
            Array.Sort(A, 0, A.Length);
            for(int i=0;i<A.Length-1; i=i+2)
            {
                if(A[i] != A[i+1]) return A[i];
            }
            return A[A.Length-1];
        }
    }
}