using System;

public class Solution {
    public int solution(string ineq, string eq, int n, int m) 
    // ineq : < or > , eq : = or !
    {
        int result;
        if(ineq == "<")
        {
            if(eq == "=")
            {
                result = (n<=m) ? 1 : 0;
            }
            else
            {
                result = (n<m) ? 1 : 0;
            }
        }
        else
        {

            if(eq == "=")
            {
                result = (n>=m) ? 1 : 0;
            }
            else
            {
                result = (n>m) ? 1 : 0;
            }
        }
        
        return result;
    }
}