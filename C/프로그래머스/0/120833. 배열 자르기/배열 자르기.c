#include <stdio.h>
#include <stdbool.h>
#include <stdlib.h>


int* solution(int numbers[], size_t numbers_len, int num1, int num2)
{
    int size = (num2 - num1) + 1;
    int* answer = (int*)malloc(sizeof(int) * size);
    
    int count = 0;
    for(int x=num1;x<=num2;x++)
    {
        answer[count] = numbers[x];
        count++;
    }
    
    return answer;
}