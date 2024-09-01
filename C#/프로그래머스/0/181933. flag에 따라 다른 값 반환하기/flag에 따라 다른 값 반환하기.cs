using System;

public class Solution {
    public int solution(int a, int b, bool flag) {
        int answer = a+b;
        
        
        
        if(flag != true)
        {
            answer = a-b;    
        }
        
        return answer;
    }
}