#include <stdio.h>
#include <stdbool.h>
#include <stdlib.h>

int solution(int num1,int num2)
{
    float a = num1;
    float b = num2; 
    
	float result = a / b;

	return (int)(result * 1000);
}