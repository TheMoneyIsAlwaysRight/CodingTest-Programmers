using System;
using System.Linq;
using System.Collections.Generic;

public class Solution {
    public int solution(string my_string, string is_prefix)
    {
        char[] array = my_string.ToCharArray();
        List<string> list = new List<string>();
        
        for(int x=0;x<my_string.Length;x++)
        {
            string word = "";
            for(int y=0;y<=x;y++)
            {
                word += array[y];
            }
            if(word != "")
            {
                list.Add(word);
            }
        }
        if(list.Contains(is_prefix))
        {
            return 1;
        }
        else
        {
            return 0;
        }
    }
}