using System;
using System.Collections.Generic;

public class Solution {
    public string[] solution(string[] strArr)
    {
        List<string> list = new List<string>();        
        for(int x=0;x<strArr.Length;x++)
        {
            if(!strArr[x].Contains("ad"))
            {
                list.Add(strArr[x]);
            }
        }
        
        return list.ToArray();
    }
}