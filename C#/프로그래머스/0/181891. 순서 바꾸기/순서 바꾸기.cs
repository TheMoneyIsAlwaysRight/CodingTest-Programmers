using System;
using System.Collections.Generic;

public class Solution
{
    public int[] solution(int[] num_list, int n) 
    {
        List<int> front = new List<int>();
        List<int> back = new List<int>();
        
        for(int x = 0;x<num_list.Length;x++)
        {
            
            if(x <= n - 1)
            {
                front.Add(num_list[x]);
            }
            else
            {
                back.Add(num_list[x]);
            }
        }
        
        for(int x=0;x<front.Count;x++)
        {
            back.Add(front[x]);
        }
        
        return back.ToArray();
    }
}