using System;

public class Example
{
    public static void Main()
    {
        String s;

        Console.Clear();
        s = Console.ReadLine();
        
        for(int x=0;x<s.Length;x++)
        {
            Console.WriteLine(s[x]);
        }

    }
}