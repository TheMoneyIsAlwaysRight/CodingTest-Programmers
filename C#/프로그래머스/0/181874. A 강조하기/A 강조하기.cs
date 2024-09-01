using System;
using System.Text;

public class Solution {
    public string solution(string myString)
    {
        char[] charArray = myString.ToCharArray();
        StringBuilder result = new StringBuilder();
        for(int x=0;x<charArray.Length;x++)
        {
            if(charArray[x] == 'a')
            {
                charArray[x] = 'A';
                continue;
            }
            else if(charArray[x] > 65 && charArray[x] < 97)
            {
                charArray[x] = (char)((int)charArray[x] + 32);
            }
        }
        
        for(int x=0;x<charArray.Length;x++)
        {
            result.Append(charArray[x]);
        }
        
        return result.ToString();
    }
}