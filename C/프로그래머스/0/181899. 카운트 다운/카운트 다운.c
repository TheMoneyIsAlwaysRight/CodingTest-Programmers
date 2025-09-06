#include <stdio.h>
#include <stdbool.h>
#include <stdlib.h>

int* solution(int start_num, int end_num) {
    // return 값은 malloc 등 동적 할당을 사용해주세요. 할당 길이는 상황에 맞게 변경해주세요.
    
    int size = start_num - end_num;
    int* answer = (int*)malloc(sizeof(int) * size);
    
    for(int x=0;x<=size;x++)
    {
        *(answer + x) = start_num - x;
    }
    
    return answer;
}