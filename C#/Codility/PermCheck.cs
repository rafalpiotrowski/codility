using System;

namespace Codility.PermCheck
{
    /**

*/
    public class Solution {
        public int solution(int[] A) {
            if(A.Length == 0) return 0;
            if(A.Length == 1 ) {
                if (A[0] == 1) return 1;
                return 0;
            };
            int sum = 0;
            //do sum to get max number
            for(int i=1; i<=A.Length; i++) {
                sum = sum + i;
            }
            Console.WriteLine("sum = {0}", sum);
            Console.WriteLine("A.Length = {0}", A.Length);
            int maxNr = 0;
            for(int i=0; i<A.Length; i++) {
                sum = sum - A[i];
                if(maxNr < A[i]) maxNr = A[i];
                if(sum == 0 && maxNr > A.Length) {
                    return 0;
                }
            }
            Console.WriteLine("max nr = {0}", maxNr);
            if(maxNr > A.Length) {
                return 0;
            } else if(sum == 0) {
                 return 1;
            }
            return 0;
        }
    }
}