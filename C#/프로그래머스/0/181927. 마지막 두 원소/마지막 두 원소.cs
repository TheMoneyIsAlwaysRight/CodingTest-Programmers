using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int[] solution(int[] num_list)
    {
        List<int> list = num_list.ToList<int>();
        int[] result;
        
        if(num_list[num_list.Length -1] > num_list[num_list.Length -2 ])
        {
            list.Add(num_list[num_list.Length -1] - num_list[num_list.Length -2 ]);
        }
        else
        {
           list.Add(2* num_list[num_list.Length-1]);
        }
        
        result = list.ToArray<int>();
        
        return result;
    }
}