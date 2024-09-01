using System;

public class Solution {
    public int solution(int[] num_list)
    {
        int oddSum = 0; // 홀수합
        int evenSum = 0; //짝수합
        
        for(int x=0;x<num_list.Length;x++)
        {
            if(x % 2 == 0){oddSum += num_list[x];}
            else{
                evenSum += num_list[x];
            }
            
        }
        
        if(oddSum > evenSum)
        {
            return oddSum;
        }
        else if(oddSum < evenSum)
        {
            return evenSum;
        }
        else{
            return evenSum;
        }
              
    }
}