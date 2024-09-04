using System;
using System.Text;

public class Solution {
     public int solution(string binomial){
        StringBuilder first = new StringBuilder();
        StringBuilder second = new StringBuilder();

        string[] array = null;
        //char 초기화.
        char oper = '0'; 

        //연산 방법 알아내기
        for (int x = 0; x < binomial.Length; x++)
        {
            if ((binomial[x] == '+' ||
               binomial[x] == '-') ||
               (binomial[x] == '*')
              )
            {
                oper = binomial[x];
                break;
            }
        }
        //연산 기호를 기준으로 나누기
        array = binomial.Split(oper);

        //첫번째 항 구하기
        for (int x = 0; x < array[0].Length; x++)
        {
            if (array[0][x] != ' ')
            {
                first.Append(array[0][x]);
            }
        }
        //두번째 항 구하기
        for (int x = 0; x < array[1].Length; x++)
        {
            if (array[1][x] != ' ') 
            {
                second.Append(array[1][x]);
            }
        }

        int first_ = Int32.Parse(first.ToString());
        int second_ = Int32.Parse(second.ToString());

        if (oper == '+')
        {
            return first_ + second_;
        }
        else if (oper == '-')
        {
            return first_ - second_;
        }
        else
        {
            return first_ * second_;
        }

    }
}