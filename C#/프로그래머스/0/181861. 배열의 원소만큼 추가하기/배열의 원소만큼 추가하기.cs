using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] arr)
    {
        List<int> result = new List<int>();
        List<int> list = null;
        
        for(int x=0;x<arr.Length;x++)
        {
            list = new List<int>();
            for(int y=0;y<arr[x];y++)
            {
                list.Add(arr[x]);
            }            
            result.AddRange(list);
            list.Clear();
        }
        
        return result.ToArray();
    }
}