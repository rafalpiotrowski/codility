using System;
using System.Linq;

namespace Codility.MaxCounters
{
    /**
    Analysis summary
The solution obtained perfect score.

Analysis
Detected time complexity:
O(N + M)
    */
    public class Solution {
        public int[] solution(int N, int[] A) {
            int[] counters = new int[N];
            int maxCounterValue = 0;
            int currentMaxCounter = 0;

            foreach(int command in A) {
                if( command >= 1 && command <= N) {
                    int counterIndex = command - 1;
                    //increase command
                    if( maxCounterValue > counters[counterIndex] ) {
                        counters[counterIndex] = maxCounterValue;
                    }
                    counters[command-1] += 1;
                    if( currentMaxCounter < counters[counterIndex] ) {
                        currentMaxCounter = counters[counterIndex];
                    }
                } else { // set all to max -- layzy write
                    maxCounterValue = currentMaxCounter;
                }
            }

            int index = 0;
            foreach(int counter in counters) {
                if( maxCounterValue > counter ) {
                    counters[index] = maxCounterValue;
                }
                index++;
            }

            return counters;
        }
    }
}