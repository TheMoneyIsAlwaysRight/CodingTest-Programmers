using System;

public class Solution {
    public string[] solution(string[] strArr)
    {
        for(int x=0;x<strArr.Length;x++)
        {
            if(x % 2 == 0)
            {
               strArr[x] = strArr[x].ToLower(); 
            }
            else
            {
               strArr[x] = strArr[x].ToUpper();
            }
        }
        return strArr;
    }
}