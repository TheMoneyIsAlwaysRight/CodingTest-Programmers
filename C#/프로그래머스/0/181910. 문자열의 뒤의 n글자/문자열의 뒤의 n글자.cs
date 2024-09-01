using System;

public class Solution {
    public string solution(string my_string, int n) {
        string answer1 = "";
        string answer = "";
        
        for(int x=0;x<n;x++)
        {
            answer1 += my_string[my_string.Length-(1+x)];
        }
        
        char[] array = answer1.ToCharArray();
        
        Array.Reverse(array);
        
        for(int x=0;x<array.Length;x++)
        {
            answer += array[x];
        }
        
        return answer;
    }
}