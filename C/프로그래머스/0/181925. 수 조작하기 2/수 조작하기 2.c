#include <stdio.h>
#include <stdbool.h>
#include <stdlib.h>

char* solution(int numLog[], size_t numLog_len)
{
    // return 값은 malloc 등 동적 할당을 사용해주세요. 할당 길이는 상황에 맞게 변경해주세요.
    char* answer = (char*)malloc((numLog_len) * sizeof(char));

    for (int x = 0; x <= numLog_len; x++)
    {
        if (x == 0) { continue; }

        int abs = numLog[x] - numLog[x - 1];

        switch (abs)
        {
        case 1:
            answer[x-1] = 'w';
            break;
        case -1:
            answer[x-1] = 's';
            break;
        case 10:
            answer[x-1] = 'd';
            break;
        case -10:
            answer[x-1] = 'a';
            break;
        default:
            continue;
        }
    }
    
    return answer;
}