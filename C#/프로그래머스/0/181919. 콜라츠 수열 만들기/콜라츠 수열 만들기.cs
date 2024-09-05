using System;
using System.Collections.Generic;

public class Solution 
{
    public int[] solution(int n)
    {
        List<int> list = new List<int>();
        
        do
        {
            list.Add(n);
            //짝수면
            if( (n % 2) == 0)
            {
                n = n/2;
            }
            //홀수면
            else
            {
                n = (3 * n) + 1;
            }
            
            if(n == 1){list.Add(n); break;}
        }while(n >= 1);
            
        return list.ToArray();
    }
}