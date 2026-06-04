using System;

public class Example
{
    public static void Main()
    {
       string str = Console.ReadLine();
       
       foreach(char c in str){
           if(char.IsUpper(c))
              {
                  Console.Write(char.ToLower(c));
              }
              else
              {
                  Console.Write(char.ToUpper(c));
              }
       }
              
}
              }