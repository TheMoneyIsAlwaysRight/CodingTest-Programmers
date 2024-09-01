using System;
using System.Collections.Generic;

public class Solution {
    public string[] solution(string[] todo_list, bool[] finished)
    {
        List<string> result = new List<string>();
    
        for(int x=0;x<finished.Length;x++)
        {
           if(!finished[x]){result.Add(todo_list[x]);} 
        }
        
        return result.ToArray();
    }
}