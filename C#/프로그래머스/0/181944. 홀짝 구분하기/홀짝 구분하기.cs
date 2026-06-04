using System;

public class Example
{
    public static void Main()
    {
       int n = Convert.ToInt32(Console.ReadLine());
       string result = (n % 2 == 0) ? "even" : "odd";
       Console.WriteLine($"{n} is {result}");
    }
}