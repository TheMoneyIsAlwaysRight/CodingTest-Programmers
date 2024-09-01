using System;

public class Solution {
    public int[] solution(int start_num, int end_num) {
        
        int[] answer = new int[end_num-start_num+1];
        
        int c = 0;
        for(int x=start_num;x<=end_num;x++)
        {
            
            answer[c] = x;
            c++;
        }
        
        return answer;
    }
}