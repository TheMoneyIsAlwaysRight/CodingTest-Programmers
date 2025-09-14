#include <stdio.h>
#include <stdbool.h>
#include <stdlib.h>

// numLog_len은 배열 numLog의 길이입니다.
char* solution(int numLog[], size_t numLog_len)
{
    // return 값은 malloc 등 동적 할당을 사용해주세요. 할당 길이는 상황에 맞게 변경해주세요.
    char* answer = (char*)malloc((numLog_len+1) * sizeof(char));
    //NULL 문자 포함한 길이 동적 할당.

    for (int x = 0; x < numLog_len; x++)
    {
        if (x == 0) { continue; }
        int abs = numLog[x] - numLog[x - 1];

        switch (abs)
        {
        case 1:
            answer[x-1] = 'w';
            break;
        case -1:
            answer[x - 1] = 's';
            break;
        case 10:
            answer[x - 1] = 'd';
            break;
        case -10:
            answer[x - 1] = 'a';
            break;
        default:
            break;
        }
    }
    
    answer[numLog_len-1] = '\0';

    return answer;
}
