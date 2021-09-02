using System;

namespace Codility.BinGap
{
    public class Solution 
    {
        public int solution(int N) {
            int maxGap = 0;
            int currentGap = 0;
            bool foundFirstBinary1 = false;

            while(N != 0)
            {
                if(!foundFirstBinary1) { // this will eliminate front trailing zeros 
                    if ((N & 1) == 1) { // found 1
                        foundFirstBinary1 = true;
                    }
                } else { 
                    if ((N & 1) == 1) { // found 1 - reset counter
                        if (currentGap > maxGap) maxGap = currentGap;
                        currentGap = 0;
                    } else { // still counting
                        currentGap++;
                    }
                }
                N >>= 1;
            }
            return maxGap;
        }
    }
}
