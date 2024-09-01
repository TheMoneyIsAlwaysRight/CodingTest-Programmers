using System;

public class Example
{
    public static void Main()
    {
        String s;
        string word ="";

        Console.Clear();
        s = Console.ReadLine();
        
        for(int x=0;x<s.Length;x++)
        {
            if(65<=s[x] && 90>=s[x])
            {
                word += (char)(s[x] +32);
            }
            else
            {
                word += (char)(s[x] - 32);
            }
        }
        
        Console.WriteLine(word);

    }
}