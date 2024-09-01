using System;

public class Solution {
    public int solution(string my_string, string target) {
        
        
        int answer = my_string.IndexOf(target);
        if(answer == -1)
        {
            answer = 0;
        }
        else
        {
            answer = 1;
        }
        
        
        return answer;
    }
}