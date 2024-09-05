using System;
using System.Collections.Generic;
using System.Text;

public class Solution
{
    public int solution(string str1,string str2)
    {
        StringBuilder result = new StringBuilder();
        List<string> list = new List<string>();
        StringBuilder sb = new StringBuilder();
        
        
        for (int x = 0; x < str2.Length; x++)
        {
            for(int y=x;y < str2.Length;y++)
            {
                sb.Append(str2[y]);
                list.Add(sb.ToString());
            }
            sb = new StringBuilder();
        }
        
        if(list.Contains(str1))
        {
            return 1;
        } 
        return 0;
    }
}