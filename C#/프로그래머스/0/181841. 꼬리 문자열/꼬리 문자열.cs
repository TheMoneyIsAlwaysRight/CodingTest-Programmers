using System;
using System.Collections.Generic;
using System.Text;

public class Solution {
    public string solution(string[] str_list, string ex)
    {
        List<string> list = new List<string>();
        StringBuilder sb = new StringBuilder();
        
        StringBuilder result = new StringBuilder();
    
        
        foreach(string word in str_list)
        {
            //String 문자열의 Char 요소 순회
            for(int x=0;x<word.Length;x++)
            {
                //부분 문자열을 만들어가면서 List에 저장.
                for(int y=x; y < word.Length; y++)
                {
                     sb.Append(word[y]);
                     list.Add(sb.ToString());
                }
                sb = new StringBuilder();
            }
            // 부분문자열 List가 ex를 미포함 여부 확인.
            if(!list.Contains(ex))
            {
                result.Append(word);          
            }
            list.Clear();
        }
        
        return result.ToString();
    
    }
}