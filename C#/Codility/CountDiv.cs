using System;

namespace Codility.CountDiv
{
    public class Solution {
        public int solution(int A, int B, int K) {
            int currentNr = A;
            int count = 0;
            while(currentNr <= B) {
                //Console.WriteLine("{0} & {1} = {2}", currentNr, (K-1), (currentNr & (K-1)));
                
                if( currentNr < 1000000 ) {
                    if (currentNr % K == 0) {
                        count++;
                    }
                } else {
                    //do mod for big number
                    if(mod(currentNr.ToString(), K) == 0) {
                        count++;
                    }
                }
                currentNr++;
            }
            return count;
        }

        // Function to compute num (mod a)
        static int mod(String num, int a)
        {
            // Initialize result
            int res = 0;
    
            // One by one process all
            // digits of 'num'
            for (int i = 0; i < num.Length; i++)
                res = (res * 10 + (int)num[i] - '0') % a;
    
            return res;
        }
    }
}