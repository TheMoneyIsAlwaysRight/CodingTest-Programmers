using System;

public class Solution {
    public int solution(string s) {
        int answer = 0;
        char[] a = s.ToCharArray();
        if(a[0] == '-')
        {
            answer = Int32.Parse(s);
        }
        else
        {
            answer = Int32.Parse(s);
        }
        
        return answer;
    }
}