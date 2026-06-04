using System;

public class Example
{
    public static void Main()
    {
        String[] str = Console.ReadLine().Split();
        int a = Convert.ToInt32(str[0]);
        int b = Convert.ToInt32(str[1]);
        int c = a+b;
        Console.WriteLine($"{a} + {b} = {c}");
    }
}