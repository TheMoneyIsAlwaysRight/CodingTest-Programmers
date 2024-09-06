using System;
using System.Collections.Generic;
using System.Text;

public class Solution
{
    public int solution(int[] date1, int[] date2)
    {
        StringBuilder sb = new StringBuilder();
        int a = 0;
        int b = 0;
        
        for(int x=0;x<date1.Length;x++)
        {
            sb.Append(date1[x].ToString());
        }
        a = Int32.Parse(sb.ToString());
        sb = new StringBuilder();
        for(int x=0;x<date2.Length;x++)
        {
            sb.Append(date2[x].ToString());
        }
        b = Int32.Parse(sb.ToString());
        
        if(a < b)
        {
            return 1;
        }
        
        return 0;
    }
}