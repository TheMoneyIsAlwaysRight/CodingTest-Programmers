#include <stdio.h>
#include <stdbool.h>
#include <stdlib.h>

int* solution(int n) 
{
    int size = 1; //n부터 시작해야하므로 n 본인을 포함한 배열 크기 초기값 설정.
    int cpyN = n;
    int* answer;
    do
    {
        if((n%2) == 0)
        {
            n = n/2;
        }
        else
        {
            n = (3*n) + 1;
        }
        
        size++;
    }while(n != 1);    
    answer = (int*)malloc(sizeof(int) * size);
    size = 0; //인덱스 역할을 하도록 0으로 설정.
    
    do
    {
        answer[size] = cpyN;
        if(cpyN == 1) { break;}
        else if((cpyN%2) == 0)
        {
            cpyN = cpyN/2;
        }
        else
        {
            cpyN = (3*cpyN) + 1;
        }
        size++;
    }while(true);

    return answer;
}