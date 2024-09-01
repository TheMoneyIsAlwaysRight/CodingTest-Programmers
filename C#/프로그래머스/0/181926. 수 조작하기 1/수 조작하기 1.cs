using System;

public class Solution {
    public int solution(int n, string control) {
        
        char[] array = control.ToCharArray();
        
        foreach(char a in array)
        {
            switch(a)
            {
                case 'w':
                    n++;
                    continue;
                case 's':
                    n--;
                    continue;
                case 'd':
                    n += 10;
                    continue;
                case 'a':
                    n -= 10;
                    continue;
            }
        }
        int answer = n;
        return answer;
    }
}
