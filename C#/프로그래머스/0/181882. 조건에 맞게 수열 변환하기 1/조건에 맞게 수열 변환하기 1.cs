using System;

public class Solution {
    public int[] solution(int[] arr)
    {
        for(int x=0;x<arr.Length;x++)
        {
            if(arr[x] >= 50 && arr[x]%2 == 0)
            {
                arr[x] = arr[x]/2;
            }
            else if(arr[x] < 50 && arr[x]%2 != 0)
            {
                arr[x] = arr[x]*2;
            }
        }
        
        return arr;
    }
}