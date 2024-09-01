using System;
using System.Linq;
using System.Collections.Generic;

public class Solution {
    public int solution(string my_string, string is_suffix)
    { 
        char[] charArray = my_string.ToCharArray();
        List<string> list = new List<string>();
        string result = "";
        for(int x=0;x<charArray.Length;x++)
        {

            for(int y=x;y<charArray.Length;y++)
            {
                result += charArray[y];
            }
            list.Add(result);
            result = "";



        }
        if(list.Contains(is_suffix)){return 1;}
        
        return 0;
    }
}