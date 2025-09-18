#include <stdio.h>
#include <stdbool.h>
#include <stdlib.h>

// 파라미터로 주어지는 문자열은 const로 주어집니다. 변경하려면 문자열을 복사해서 사용하세요.
int solution(int n, const char* control)
{
    int size = 0;
    
    while(true)
    {
        if(*(control+size) == '\0'){break;}
        switch(*(control+size))
        {
            case 'w':
                n++;
                break;
            case 's':
                n--;
                break;
            case 'd':
                n += 10;
                break;
            case 'a':
                n -= 10;
                break;
        }
        size++;
    }
    return n;
}