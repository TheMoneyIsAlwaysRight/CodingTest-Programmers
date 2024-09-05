using System;

public class Solution {
    public int[] solution(int[] arr, int k)
    {
        if((k%2) != 0)
        {
            for(int x=0;x<arr.Length;x++)
            {
                arr[x] *= k;
            }
        }
        else
        {
            for(int x=0;x<arr.Length;x++)
            {
                arr[x] += k;
            }
        }
        
        return arr;
    }
}