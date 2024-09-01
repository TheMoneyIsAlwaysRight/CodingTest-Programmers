using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public string solution(string my_string, int n)
    {
        string answer = "";
        
        List<char> list = my_string.ToCharArray().ToList<char>();
        
        for(int x=0;x<my_string.Length;x++)
        {
            if(x < n)
            {
                answer += list[0];
                list.RemoveAt(0);
            }
        }
        return answer;
    }
}