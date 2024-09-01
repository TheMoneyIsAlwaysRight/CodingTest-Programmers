using System;

public class Solution {
    public string solution(string my_string, int k) {
        string answer = "";
        
        int a=0;
            
        while(a<k)
        {
            answer += my_string;
            a++;
        }
        
        return answer;
    }
}