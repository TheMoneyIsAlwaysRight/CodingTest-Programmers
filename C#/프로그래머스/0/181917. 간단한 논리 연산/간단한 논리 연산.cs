using System;

public class Solution {
    public bool solution(bool x1, bool x2, bool x3, bool x4) 
    {
        
        //v는 ||와 같으므로
        bool first = (x1 || x2) ? true : false;
        bool second = (x3 || x4) ? true : false;
        
        
        bool result = first && second ? true : false;
        
        
        return result;
    }
}