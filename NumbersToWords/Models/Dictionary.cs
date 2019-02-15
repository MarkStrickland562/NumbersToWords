using System;
using System.Collections.Generic;
using System.Linq;

namespace NumbersToWords.Models
{
  public class NumsToWords
  {
    Dictionary<string, string> myDictionary1to19 = new Dictionary<string, string>() {
      {1, "One"}, {2, "Two"}, {3, "Three"}, {4, "Four"}, {5, "Five"},
      {6, "Six"}, {7, "Seven"}, {8, "Eight"}, {9, "Nine"}, {10, "Ten"},
      {11, "Eleven"}, {12, "Twelve"}, {13, "Thirteen"}, {14, "Fourteen"}, {15, "Fifteen"},
      {16, "Sixteen"}, {17, "Seventeen"}, {18, "Eighteen"}, {19, "Nineteen"}
    };

    Dictionary<string, string> myDictionary20to90 = new Dictionary<string, string>() {
      {20, "Twenty"}, {30, "Thirty"}, {40, "Forty"}, {50, "Fifty"}, {60, "Sixty"},
      {70, "Seventy"}, {80, "Eighty"}, {90, "Ninety"}
    };

    public static bool CheckInt(string myString)
    {
      try
      {
        int.Parse(myString);
      }
      catch (Exception)
      {
        return false;
      }
      return true;
    }

    public static bool Validate(string myString)
    {
      bool isInt = CheckInt(myString);

      return isInt;
    }

    public static string ConvertNumber(string myString)
    {
      char[] myStringArray = myString.ToCharArray();
      List<string> myDigits = myStringArray.ToList();

      string _response = "";


      if (myDigits.Length == 3)
      {
        _response += myDictionary1to19[myDigits[0]] + " Hundred";
        myDigits.Remove(myDigits[0]);
      }

      if (myDigits.Length == 2)
      {
        if (myDigits[0] == "0")
        {
          _myInt = int.Parse(myDigits[1]);
          _response += myDictionary1to19[_myInt];
        }
        else if (myDigits[0] == "1")
        {
          _myInt = int.Parse(myDigits[0] + myDigits[1]);
          _response += " and " + myDictionary1to19[_myInt];
        }
        else
        {
          _response += myDictionary20to90[myDigits[0] + "0"];

          if (myDigits[1] != "0")
          {
            _response += "-" + myDictionary1to19[myDigits[1]];
          }
        }
      }

      return _response;
    }
  }
}
