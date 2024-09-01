using System;

public class Solution {
    public int solution(int a, int b) {
        int answer = 0;
        string A = "";
        string B = "";
        int a1 = 0;
        int b1 = 0;
        
        A += a.ToString();
        B += b.ToString();
        A += b.ToString();
        B += a.ToString(); // A -> a b   B  -> b a
        
        a1 = Int32.Parse(A);
        b1 = Int32.Parse(B);
        
        if(a1 > b1){ answer = a1;}
        else if(a1 == b1){ answer = a1;}
        else { answer = b1;}
        
        
        
        
        
        return answer;
    }
}