using System;
using System.Linq;

namespace Codility.PermMissingElem
{
    //still working on it
    public class Solution {
        public int solution(int[] A) {
            if (A.Length == 0) return 0;

            Array.Sort(A);
            for(int i=0; i<=A.Length-1; i++)
            {
                if(i < A.Length) {
                    if(A[i]+1 != A[i+1]) {
                        return A[i]+1;
                    }
                }
            }
            return 0;
        }
    }
}