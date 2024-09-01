using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Solution {
    public string solution(string myString)
    {
        Char[] charArray = myString.ToCharArray();
        StringBuilder result = new StringBuilder();
        for(int x=0;x<charArray.Length;x++)
        {
            if((int)charArray[x] < (int)'l'){charArray[x] = 'l';}
            result.Append(charArray[x]);
        }
        
        return result.ToString();
    }
}