using System;
using System.Linq;
using System.Collections.Generic;

public class Solution {
    public string[] solution(string my_string)
    { 
        char[] charArray = my_string.ToCharArray();
        List<string> list = new List<string>();
        string result = "";
        string[] rArray;
        for(int x=0;x<charArray.Length;x++)
        {

            for(int y=x;y<charArray.Length;y++)
            {
                result += charArray[y];
            }
            list.Add(result);
            result = "";



        }

        
        rArray = list.ToArray();
        
        Array.Sort(rArray);
        
        return rArray;

    }
}






