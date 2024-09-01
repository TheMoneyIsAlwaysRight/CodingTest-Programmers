using System;
using System.Collections.Generic;
public class Solution {
    public string[] solution(string[] names)
    {
        List<string> result = new List<string>();
        
        for(int x=0;x<names.Length;x++)
        {
            if(x%5 == 0){result.Add(names[x]);}
        }
        
        return result.ToArray();
    }
}