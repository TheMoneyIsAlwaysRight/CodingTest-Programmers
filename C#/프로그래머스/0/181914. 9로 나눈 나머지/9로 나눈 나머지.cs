using System;

public class Solution 
{
    public int solution(string number)
    {
        int result = 0;
        for(int x=0;x<number.Length;x++)
        {
            result += (int)number[x] - 48;
        }
        
        
        return result%9;
        
    }
}