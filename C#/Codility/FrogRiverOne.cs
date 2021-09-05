using System;

namespace Codility.FrogRiverOne
{
    /**
    Analysis summary
The solution obtained perfect score.

Analysis
Detected time complexity:
O(N)
*/
    public class Solution {
        public int solution(int X, int[] A) {
            if(X == 0) return -1;
            if(A.Length < X) return -1;
            int steps = X;
            bool[] mem = new bool[X];
            for(int i=0; i<A.Length; i++)
            {
                if(A[i] <= X) {
                    //check memory
                    if(!mem[A[i]-1]) {
                        //one step covered
                        steps--;
                        mem[A[i]-1] = true;
                        if (steps == 0) return i;
                    }
                    //else this step is already covered
                }
            }
            return -1;
        }
    }
}