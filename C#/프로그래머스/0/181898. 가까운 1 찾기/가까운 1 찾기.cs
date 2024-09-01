using System;

public class Solution {
    public int solution(int[] arr, int idx)
    {
        int answer = 0;
        
        for(int x = idx;x<arr.Length;x++)
        {
            if(arr[x] == 1){ return x;}
        }
        
        return -1;
    }
}