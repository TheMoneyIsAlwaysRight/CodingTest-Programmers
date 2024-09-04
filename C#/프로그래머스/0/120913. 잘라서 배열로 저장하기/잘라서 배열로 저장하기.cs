using System;
using System.Collections.Generic;
using System.Text;

public class Solution {
    public string[] solution(string my_str, int n)
    {
        StringBuilder word = new StringBuilder();
        List<string> list = new List<string>();
        int count = 0;
        
        for(int x=0;x<my_str.Length;x++)
        {
            word.Append(my_str[x]);
            if(word.Length == n || ((my_str.Length - 1 - x) <= 0))
            {
                list.Add(word.ToString());
                word = new StringBuilder();
            }
        }
        
        return list.ToArray();
    }
}