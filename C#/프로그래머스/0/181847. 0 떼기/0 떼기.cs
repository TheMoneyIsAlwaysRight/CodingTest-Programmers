using System;
using System.Text;

public class Solution
{
    public string solution(string n_str)
    {
        StringBuilder result = new StringBuilder();

        for (int x = 0; x < n_str.Length; x++)
        {
            if(result.Length == 0 && n_str[x] == '0'){continue;}
            result.Append(n_str[x]);
        }

        return result.ToString();
    }
}