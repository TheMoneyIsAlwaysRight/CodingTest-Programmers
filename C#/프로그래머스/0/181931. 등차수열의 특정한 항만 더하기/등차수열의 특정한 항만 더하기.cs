using System;

public class Solution {
    public int solution(int a, int d, bool[] included)
    {
        int answer = 0;
        
        int q = 0;
        foreach(bool x in included)
        {
            
            if(x == false)
            {
                q++;
                continue;
            }
            
            answer += a+(d*q);
            q++;
                   
        }        
        return answer;        
    }
}