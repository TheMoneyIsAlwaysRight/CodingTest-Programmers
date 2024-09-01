using System;

public class Solution {
    public int[,] solution(int n) 
    {
        int[,] answer = new int[n,n];
        
        for(int x=0;x<answer.GetLength(0);x++)
        {
            for(int y=0;y<answer.GetLength(1);y++)
            {
                if(x == y){answer[y,x] = 1;}
                else{ answer[y,x] = 0;}
            }
        }
        
        return answer;
    }
}