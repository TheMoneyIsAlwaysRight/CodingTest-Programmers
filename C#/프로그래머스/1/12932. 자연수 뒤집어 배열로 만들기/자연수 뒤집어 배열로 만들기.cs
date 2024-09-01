using System;

public class Solution {
    public int[] solution(long n) 
    {
        
        string word = n.ToString();
        
        char[] array = word.ToCharArray();
        
        int[] answer = new int[array.Length];
        
        for(int x=0;x<array.Length;x++)
        {
            answer[x] = (int)(array[x]-48);
        }
        
        Array.Reverse(answer);
        
        return answer;
    }
}