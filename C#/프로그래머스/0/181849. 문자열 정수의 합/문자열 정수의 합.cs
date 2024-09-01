using System;

public class Solution {
    public int solution(string num_str)
    {
        int result = 0;
        
        for(int x=0;x<num_str.Length;x++)
        {
            result += num_str[x] - 48;
        }
        
        return result;
    }
}