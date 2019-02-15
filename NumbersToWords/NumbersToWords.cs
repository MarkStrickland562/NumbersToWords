using System;
using NumbersToWords.Models;

namespace NumbersToWords
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Enter an integer between 1 and 999 to convert:");

      string myString = Console.ReadLine();

      if (NumsToWords.Validate(myString))
      {
        string myResponse = NumsToWords.ConvertNumber(myString);

        Console.WriteLine("Converted Number: " + myResponse);
      }
      else
      {
        Console.WriteLine("Invalid integer (must be 1-999)");
      }
    }
  }
}
