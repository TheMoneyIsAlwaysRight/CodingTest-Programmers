#include <stdio.h>
#include <stdbool.h>
#include <stdlib.h>

// num_list_len은 배열 num_list의 길이입니다.
int* solution(int num_list[], size_t num_list_len) {
    // return 값은 malloc 등 동적 할당을 사용해주세요. 할당 길이는 상황에 맞게 변경해주세요.
    int a = 0; //짝수
    int b = 0; //홀수
    
    for(int x=0;x<num_list_len;x++)
    {
        if((num_list[x] % 2) != 0) //홀수면
        {
            b++;
        }
        else //짝수면
        {
            a++;
        }
    }
    
    int* answer = (int*)malloc(2 * sizeof(int));
    answer[0] = a;
    answer[1] = b;
    
    return answer;
}