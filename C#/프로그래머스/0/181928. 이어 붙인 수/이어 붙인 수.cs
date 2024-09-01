using System;

public class Solution {
    public int solution(int[] num_list) {
        
        string even = ""; //짝수
        string odd = "";  //홀수
        
        for(int x=0;x<num_list.Length;x++)
        {
            if(num_list[x] % 2 == 0)
            { even += num_list[x];}
            else
            {
                odd += num_list[x];
            }
        }
        
        
        int answer = Int32.Parse(even) + Int32.Parse(odd);
        return answer;
    }
}