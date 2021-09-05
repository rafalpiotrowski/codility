using System;

namespace Codility.GenomicRangeQuery
{
    public class Solution {

/*
N is an integer within the range [1..100,000];
M is an integer within the range [1..50,000];
each element of arrays P, Q is an integer within the range [0..N − 1];
P[K] ≤ Q[K], where 0 ≤ K < M;
string S consists only of upper-case English letters A, C, G, T.
*/
        public int[] solution(String S, int[] P, int[] Q) {
            int[] M = new int[P.Length];
            int[] S_int = convertToInts(S);
            int sum = 0;
            int x, y = 0;
            for(int i=0; i<M.Length; i++) {
                x = P[i];
                y = Q[i];
                
                M[i] = sum;
                sum = 0;
            }

            return M;
        }

        static int[] convertToInts(String S) {
            int[] list = new int[S.Length];
            int i = 0;
            foreach(char s in S.ToCharArray()) {
                if(s == 'A') {
                    list[i] = 1;
                } else if (s == 'C') {
                    list[i] = 2;
                } else if (s == 'G') {
                    list[i] = 3;
                } else if (s == 'T') {
                    list[i] = 4;
                }
                i++;
            }
            return list;
        }
    }
}