using System;
using System.Linq;

namespace Codility.PassingCars
{
    /*
    Analysis summary
The solution obtained perfect score.

Analysis
Detected time complexity:
O(N)
    */
    public class Solution {
        public int solution(int[] A) {
            int maxPairs = 1000000000;
            int count = 0;
            int N = A.Length;
            int nrOfOnesVisited = 0;
            int totalNrOfOnes = A.Count(x => x == 1);

            for(int i=0; i<A.Length; i++) {
                int P = A[i];
                if(P == 1) { 
                    nrOfOnesVisited++;
                }
                if(P == 0) {
                    count = count + (totalNrOfOnes - nrOfOnesVisited);
                }
                if(count > maxPairs) return -1;
            }
            return count;
        }
    }
}