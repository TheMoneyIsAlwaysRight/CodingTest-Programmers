public class Solution {
    public bool solution(int x) 
    {
        string xString = x.ToString();
        int sum = 0;
        
        for(int z=0;z<xString.Length;z++)
        {
           sum += (int)(xString[z] - 48); 
        }
        
        if(x % sum == 0)
        {
           return true;   
        }
        
        return false;   
    }
}