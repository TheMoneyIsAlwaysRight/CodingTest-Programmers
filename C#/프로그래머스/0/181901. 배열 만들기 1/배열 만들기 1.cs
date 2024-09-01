using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int n, int k)
    {
        List<int> list = new List<int>();
        
        for(int x=1;x<=n;x++)
        {   
            if(x%k == 0)
            {
                list.Add(x);
            }
        
        }
        int[] answer = list.ToArray();
        return answer;
    }
}