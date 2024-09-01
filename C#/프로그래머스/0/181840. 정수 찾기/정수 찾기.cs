using System;

public class Solution {
    public int solution(int[] num_list, int n)
    {
        int result = Array.IndexOf(num_list,n);
        
        if(result != -1){return 1;}
        else{return 0;}
    }
}