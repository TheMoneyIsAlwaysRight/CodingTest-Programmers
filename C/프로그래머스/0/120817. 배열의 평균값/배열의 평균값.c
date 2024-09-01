#include <stdio.h>
#include <stdbool.h>
#include <stdlib.h>

// numbers_len은 배열 numbers의 길이입니다.
double solution(int numbers[], size_t numbers_len)
{
    int sum = 0;
    for(int x=0;x<numbers_len;x++)
    {
        sum += numbers[x];
    }
    
    
    return (double)(sum/(double)numbers_len);
    
}