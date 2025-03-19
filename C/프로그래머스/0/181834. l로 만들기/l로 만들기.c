#include <stdio.h>
#include <stdbool.h>
#include <stdlib.h>

char* solution(const char* myString)
{
    int size = 0;
    char* answer;
    for (int i = 0;; i++)
    {
        if (*(myString + i) != '\0')
        {
            size++;
        }
        else
        {
            break;
        }
    }

    answer = (char*)malloc(size * sizeof(char) + 1);

    for (int i = 0; i <= size; i++)
    {
        if (i == size) { *(answer + i) = '\0'; }

        *(answer + i) = *(myString + i);
        if (*(answer + i) < 'l' && *(answer + i) != '\0')
        {
            *(answer + i) = 'l';
        }
    }
    return answer;
}