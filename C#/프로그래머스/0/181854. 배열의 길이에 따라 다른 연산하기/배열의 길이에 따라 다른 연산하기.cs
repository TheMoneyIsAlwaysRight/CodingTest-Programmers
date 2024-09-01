using System;

public class Solution {
    public int[] solution(int[] arr, int n)
    {
        if(arr.Length % 2 != 0)
        {
            for(int x=0;x<arr.Length;x++)
            {
                if(x % 2 == 0)
                {
                    arr[x] += n;
                }
            }
        }
        else
        {
            for(int x=0;x<arr.Length;x++)
            {
                if(x % 2 != 0)
                {
                    arr[x] += n;
                }
            }   
        }
        
        return arr;
    }
}