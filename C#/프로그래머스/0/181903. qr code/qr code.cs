using System;

public class Solution {
    public string solution(int q, int r, string code) {
        string answer = ""; ///code의 각 인덱스 번호를 q로 나누고 나머지가 r인 
        
        for(int x=0;x<code.Length;x++)
        {
            if(x%q == r){answer += code[x];}
        }

        
        
        
        return answer;
    }
}