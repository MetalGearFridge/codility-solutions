using System;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution {
    public int solution(int N) {
        // Implement your solution here
        string binaryN = Convert.ToString(N, 2).Trim('0');

        bool gapStart = false;
        int gapCount = 0;
        int maxCount = 0;

        for(int i = 0; i < binaryN.Length; i++){
            if(binaryN[i] == '1'){
                maxCount = Math.Max(maxCount, gapCount);
                gapStart = true;
                gapCount = 0;
            }
            else if(gapStart){
                gapCount++;
            }
        }
        return maxCount;
    }
}
