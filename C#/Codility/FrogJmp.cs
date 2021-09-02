using System;
namespace Codility.FrogJump {
    /**
    Analysis summary
The solution obtained perfect score.

Analysis
Detected time complexity:
O(1)
    */
    public class Solution {
        public int solution(int X, int Y, int D) {
            int x = Y-X;
            int r = Math.Abs(x/D);
            if(x%D == 0) return r; 
            return r+1;
        }        
    }
}