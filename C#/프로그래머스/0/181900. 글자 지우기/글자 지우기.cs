using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

public class Solution {
    public string solution(string my_string, int[] indices)
    {
        char[] array= my_string.ToCharArray();
        StringBuilder result = new StringBuilder();
        
        for(int x=0;x<indices.Length;x++)
        {
            array[indices[x]] = ']';
        }
        for(int x=0;x<array.Length;x++)
        {   if(array[x] != ']')
                result.Append(array[x].ToString());
        }
        return result.ToString();
    }
}