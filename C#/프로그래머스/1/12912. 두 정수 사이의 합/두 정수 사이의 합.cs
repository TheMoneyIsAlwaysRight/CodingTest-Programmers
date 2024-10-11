public class Solution {
    public long solution(int a, int b)
    {
        long answer = 0;
        if(a<b)
        {
            for(int x=a;x<=b;x++)
            {
                answer += x;
            }
        }
        else if(a>b)
        {
            for(int x=b;x<=a;x++)
            {
                answer += x;
            }
            
        }
        else{
            return a;
        }
        
        
        return answer;
    }
}