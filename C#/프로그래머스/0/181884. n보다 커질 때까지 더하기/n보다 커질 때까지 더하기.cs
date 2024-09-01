using System;

public class Solution
{
    public int solution(int[] numbers, int n)
    {
        int result = 0;
        for(int x=0;x<numbers.Length;x++)
        {
            result += numbers[x];
            
            if(result > n)
            {break;}
        }
        
        return result;
    }
}