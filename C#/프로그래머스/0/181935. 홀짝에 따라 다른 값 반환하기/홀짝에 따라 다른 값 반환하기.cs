using System;

public class Solution {
    public int solution(int n) {
        int answer = 0;
        
        if(n%2 != 0 ) //n이 홀수면
        {
            for(int x=0;x<=n;x++)
            {
                if(x%2 == 0)
                {
                    continue;
                }
                answer += x;
            }
        }
        else if(n%2 == 0) //짝수면
        {
          for(int x=0;x<=n;x++)
            {
                if(x == 0 || x%2 !=0)
                {
                    continue;
                }
                answer += x*x;
            }
        }
        
        return answer;
    }
}