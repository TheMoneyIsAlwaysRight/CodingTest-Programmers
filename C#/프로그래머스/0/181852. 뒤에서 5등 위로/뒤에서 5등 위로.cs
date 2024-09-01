using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] num_list) 
    {
        List<int> result = new List<int>();
        
        Array.Sort(num_list);
        
        for(int x=0;x<num_list.Length;x++)
        {
            if(x<=4){continue;}
            
            result.Add(num_list[x]);
        }
        
        return result.ToArray();
    }
}