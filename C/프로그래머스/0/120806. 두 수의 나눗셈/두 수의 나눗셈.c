#include <stdio.h>
#include <stdbool.h>
#include <stdlib.h>

int solution(int num1,int num2)
{
    double a = num1;
    double b = num2; 
    
	double result = a / b;

	return (int)(result * 1000);
}