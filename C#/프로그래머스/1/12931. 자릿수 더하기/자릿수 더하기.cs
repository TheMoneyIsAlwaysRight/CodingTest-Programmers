using System;

public class Solution {
    public int solution(int n) {
        int answer = 0;
        string word = n.ToString();
        char[] array = word.ToCharArray();
        foreach(char a in array)
        {
            answer += (int)(a-48);
        }
        return answer;
    }
}