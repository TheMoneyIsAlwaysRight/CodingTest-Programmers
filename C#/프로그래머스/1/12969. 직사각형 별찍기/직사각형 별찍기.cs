using System;

public class Example
{
    public static void Main()
    {
        String[] s;

        Console.Clear();
        s = Console.ReadLine().Split(' ');

        int a = Int32.Parse(s[0]);
        int b = Int32.Parse(s[1]);

        for(int x=0;x<b;x++)
        {
            for(int y=0;y<a;y++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}