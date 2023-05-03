using Microsoft.VisualStudio.TestTools.UnitTesting;
using WeekdayFinder.Models;
using System.Collections.Generic;
using System;

namespace WeekdayFinder.Tests
{
  [TestClass]
  public class DayerTests
  {
    [TestMethod]
    public void Splitter_SplitInputAtSlash_Int()
    {
      string input = "12/31/1999";
      int expected = 1999;
      Dayer.Splitter(input);
      Assert.AreEqual(expected, Dayer.Year);
    }
  }
}