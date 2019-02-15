using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using NumbersToWords;
using NumbersToWords.Models;

namespace NumbersToWords.Tests
{
  [TestClass]
  public class NumbersToWordsTest
  {
    [TestMethod]
    public void NumbersToWords_IsInteger_False()
    {
      Assert.AreEqual(false, NumbersToWords.Validate("aString"));
    }

    [TestMethod]
    public void NumbersToWords_IsInteger_True()
    {
      Assert.AreEqual(true, NumbersToWords.Validate(345));
    }

    [TestMethod]
    public void NumbersToWords_Score_1to20()
    {
      Assert.AreEqual("Seventeen" ScrabbleScorer.Score(17));
    }


  }
}
