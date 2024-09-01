using System;
using System.Collections.Generic;
public class Solution {
    public int[] solution(int start, int end_num)
    {
        List<int> list = new List<int>();
        while(start >= end_num)
        {
            list.Add(start--);
        }
        int[] answer = list.ToArray();
        return answer;
    }
}