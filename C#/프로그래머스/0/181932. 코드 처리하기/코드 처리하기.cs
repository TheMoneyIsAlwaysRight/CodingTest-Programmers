using System;
using System.Collections.Generic;
using System.Linq;

public class Solution
{
    public string solution(string code) 
    { 
        bool Ismode = false;
        string result = "";
        List<char> list = code.ToCharArray().ToList<char>();
        
        for(int x=0;x<list.Count;x++)
        {
            if(list[x] == '1')
            { 
                    Ismode = !Ismode;
                    continue; 
            }                            
            else if(list[x] != '1')
            {
                if((Ismode == false) && ( (x%2)   ==  0   ))
                {
                    result += list[x];
                }
                else if((Ismode == true) && (x%2)   !=  0  )
                {
                    result += list[x];
                }  
            }
        }    
        if(result == ""){return $"EMPTY";}
        
        return result;
        
    }
}