using System;
using System.Collections.Generic;

public class Solution
{
    public int solution(int[] num_list)   
    {
        if(!Array.Exists(num_list,(item => item< 0)))
        {
            return -1;
        }
             
        for(int x=0;x<num_list.Length;x++)
        {
            if(num_list[x] < 0)
            {
                return x;
            }
        }
        return -1;
    }
}