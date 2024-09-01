using System;

public class Solution {
    public int[] solution(int[] num_list) {
        
        Array.Sort(num_list);
        
        int[] answer = new int[5] {num_list[0],num_list[1],num_list[2],num_list[3],num_list[4]};
        return answer;
    }
}