using System;
using System.Collections.Generic;

public class Solution {
    public string[] solution(string my_string) {
        
        List<string> a  = new List<string>();
        string b = "";
       
        
        for(int x=0;x<my_string.Length;x++)
        {
            if(my_string[x] != ' '){b += my_string[x];}
            
            if(my_string[x] == ' ' && b.Length != 0)
               {
                a.Add(b);
                b = "";
               }  
            
            if(x == my_string.Length-1 && my_string[x] != ' ')                
            {
                a.Add(b);
                b = "";
            }
        }
        
        string[] answer = a.ToArray();
        
        
        return answer;
    }
}