using System;

public class Solution {
    public string solution(string my_string, string alp) {
        string answer = "";
        
        char[] a = (my_string.Replace(alp,alp.ToUpper())).ToCharArray();
        
        for(int x=0;x<a.Length;x++)
        {
            answer += a[x];
        }
        return answer;
    }
}