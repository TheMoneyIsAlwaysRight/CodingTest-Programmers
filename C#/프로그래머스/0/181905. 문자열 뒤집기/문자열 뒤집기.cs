using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Solution {
    public string solution(string my_string, int s, int e)
    {
        StringBuilder result = new StringBuilder();
            
        char[] array = my_string.ToCharArray();
        
        for(int x=0;x<array.Length;x++)
        {
           if(x == s)
           {
               for(int y=e; y>=s; y--)
               {
                  result.Append(array[y]);
               }
               x = e;
               continue;
           }
           result.Append(array[x]);
        }
        return result.ToString();
    }
}