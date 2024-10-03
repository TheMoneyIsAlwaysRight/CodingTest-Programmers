using System;

public class Solution {
    public int solution(int[,] arr) 
    {
        for(int y=0;y<arr.GetLength(1);y++)
        {
            for(int x=0;x<arr.GetLength(0);x++)
            {
                if(arr[x,y] != arr[y,x])
                {
                    return 0;
                }
            }
        }
        return 1;
    }
}