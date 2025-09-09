#include <stdio.h>
#include <stdbool.h>
#include <stdlib.h>

// 파라미터로 주어지는 문자열은 const로 주어집니다. 변경하려면 문자열을 복사해서 사용하세요.
int solution(const char* my_string, const char* is_prefix) 
{
    //is_prefix의 (문자열+NULL)의 길이 알아내기
    int count = 0;
    for (int x = 0;;x++)
    {
        if (is_prefix[x] == NULL)
        {
            count = x;
            break; 
        }
    }
    
    
    bool isCorrect = true;
    
    for(int x=0;x<count;x++) //NULL문자 제외
    {
        if((my_string[x] == NULL && is_prefix[x] != NULL)) //비교할 문자열이 더 긴 경우 제외.  
        {
            isCorrect = false;
            break;
        }  
        if(my_string[x] != is_prefix[x])
        {
            isCorrect = false;
            break;
        }
    }
    
    return isCorrect;
}
