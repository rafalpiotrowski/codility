using System;
using System.Linq;

namespace Codility.PermMissingElem
{
    //still working on it got 50%
    public class Solution {
        public int solution(int[] A) {
            if (A == null || A.Length < 2) throw new Exception("incorrect input");

            Array.Sort(A);
            for(int i=0; i<A.Length; i++)
            {
                if(i < A.Length-1) {
                    if(A[i]+1 != A[i+1]) {
                        return A[i]+1;
                    }
                }
            }
            throw new Exception("number not found");
        }
    }
}