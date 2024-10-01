using System;

public class Solution {
    public long solution(long n)
    {
        bool isCorrect = false;
        int result = 0;
        for(int x=1;x<=n;x++)
        {
            if(Math.Pow(x,2) == n)
            {
                result = x;
                isCorrect = true;
                break;
            }
        }
        
        if(isCorrect)
        {
            return (long)Math.Pow(result+1,2);
        }
        else
        {
           return -1; 
        }
    }
}