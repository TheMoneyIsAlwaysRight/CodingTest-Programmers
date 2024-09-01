using System;
using System.Collections.Generic;

public class Solution
{
    public int[] solution(int[] num_list, int n)
    {
        List<int> result = new List<int>();
        for(int x=0;x<num_list.Length;x++)
        {
            if(x%n != 0){continue;}
            
            result.Add(num_list[x]);
        }
        
        return result.ToArray();
    }
}