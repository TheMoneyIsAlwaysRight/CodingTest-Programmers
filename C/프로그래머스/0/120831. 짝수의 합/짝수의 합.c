#include <stdio.h>
#include <stdbool.h>
#include <stdlib.h>

int solution(int n) {
        int answer = 0;
        int a=0;
        int sum=0;
        
        while(a<=n)
        {
            if(a%2 == 0)
            {
              sum += a;  
                
            }
            a++;
            
        }
        answer =sum;
        return answer;
}