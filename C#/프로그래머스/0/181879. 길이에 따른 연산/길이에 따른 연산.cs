using System;
using System.Linq;

public class Solution {
    public int solution(int[] num_list)
    {
        int result = 1;
        
        if(num_list.Length >= 11)
        {
            return num_list.Sum();    
        }
        else
        {
            for(int x=0;x<num_list.Length;x++)
            {
                result *= num_list[x];
            }
            
            return result;
        }
    }
}