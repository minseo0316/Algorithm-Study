using System;

public class Example
{
    public static void Main()
    {
      string[] s = Console.ReadLine().Split(' ');
        
      int a = Convert.ToInt32(s[0]);
      int b = Convert.ToInt32(s[1]);
        
      Console.WriteLine($"a = {a}\nb = {b}");
        
    }
}