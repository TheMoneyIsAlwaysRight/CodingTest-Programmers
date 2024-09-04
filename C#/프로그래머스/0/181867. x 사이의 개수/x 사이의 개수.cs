using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(string myString)
    {
        List<int> list = new List<int>();
        string[] stArray = myString.Split('x');
        
        for(int x=0;x<stArray.Length;x++)
        {
            list.Add(stArray[x].Length);
        }
        
        return list.ToArray();
    }
}