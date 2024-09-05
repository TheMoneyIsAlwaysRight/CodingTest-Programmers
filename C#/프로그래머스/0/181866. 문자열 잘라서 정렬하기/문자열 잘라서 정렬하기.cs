using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public string[] solution(string myString)
    {
        string[] answer = myString.Split('x');
        List<string> list = new List<string>();
        
        for(int x=0;x<answer.Length;x++)
        {
            if(answer[x] != "")
            {
                list.Add(answer[x]);
            }
        }
        
        answer = list.ToArray();
        
        Array.Sort(answer);
        
        return answer;
    }
}