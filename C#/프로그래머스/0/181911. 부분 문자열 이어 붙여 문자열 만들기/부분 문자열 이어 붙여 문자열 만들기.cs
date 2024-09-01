using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public string solution(string[] my_strings, int[,] parts)
    {
        int s,e;
        string result = "";
        
        //part의 행의 개수
        for(int x=0;x<parts.GetLength(0);x++)
        {
            // [s,e] 꼴
            s = parts[x,0];
            e = parts[x,1];
            for(int y=0;y<my_strings[x].Length;y++)
            {
                   if(s <= y && y <= e)
                   {
                      result += my_strings[x][y];  
                   }
            }
        }
        
        return result;
    }
}