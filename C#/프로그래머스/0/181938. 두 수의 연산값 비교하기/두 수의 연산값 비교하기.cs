using System;

public class Solution {
    public int solution(int a, int b) {
        
        string a_ = a.ToString();
        string b_ = b.ToString();
        string c = (a_+ b_);
        int c_ = Int32.Parse(c);
        
        if(c_ > 2*a*b)
        { return c_;}
        else if(c_ == 2*a*b)
        {
            return c_;
        }
        return 2*a*b;
    }
}