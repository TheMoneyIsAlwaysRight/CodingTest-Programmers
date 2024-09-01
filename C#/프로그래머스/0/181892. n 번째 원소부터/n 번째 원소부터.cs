using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] num_list, int n) {
        List<int> list = new List<int>();
        
        for(int x=n-1;x<num_list.Length;x++)
        {
            list.Add(num_list[x]);
        }
        
        int[] answer = list.ToArray();
        
        return answer;
    }
}