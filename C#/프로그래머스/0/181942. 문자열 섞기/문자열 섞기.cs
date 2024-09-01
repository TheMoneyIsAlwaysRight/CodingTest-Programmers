using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public string solution(string str1, string str2) {
        string answer = "";
        
        List<char> str1_List = str1.ToCharArray().ToList<char>();
        List<char> str2_List = str2.ToCharArray().ToList<char>();
        
        while(str1_List.Count > 0 || str2_List.Count > 0)
        {
            if(str1_List.Count > 0)
            {
                answer += str1_List[0];
                str1_List.RemoveAt(0);
            }
            
            if(str2_List.Count > 0)
            {
                answer += str2_List[0];
                str2_List.RemoveAt(0);
            }
           
        }
        return answer;
        
        
        
        
        
        return answer;
    }
}