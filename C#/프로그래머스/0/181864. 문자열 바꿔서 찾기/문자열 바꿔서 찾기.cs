using System;
using System.Collections.Generic;
using System.Text;

public class Solution {
    public int solution(string myString, string pat)
    {
        List<string> list = new List<string>();
        StringBuilder word = new StringBuilder();
        
        string backup1 = myString.Replace('A','a');
        string backup2 = backup1.Replace('B','A');
        string backup3 = backup2.Replace('a','B');
        
        char[] array = backup3.ToCharArray();
        
        for(int x=0;x<array.Length;x++)
        {
            for(int y=x;y<array.Length;y++)
            {
                word.Append(array[y].ToString());
                list.Add(word.ToString());
            }
            word.Length = 0;
        } 
        
        if(list.Contains(pat)){return 1;}
        
        return 0;
    }
}