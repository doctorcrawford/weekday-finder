using System;
using WeekdayFinder.Models;
// using WeekdayFinder.UserInterfaceModels;

namespace WeekdayFinder
{
  class Program
  {
    static void Main()
    {
      Console.WriteLine("Welcome!");
      Console.WriteLine("Please enter a day (MM/DD/YYYY)");
      string input = Console.ReadLine();
      try
      {
        if (Dayer.Splitter(input))
        {
          Console.WriteLine($"On this day, {Dayer.Day}, in the year of our lord, {Dayer.Year}, the day of the week was {Dayer.Weekday()}");
        }
        else
        {
          Console.WriteLine("ERRORROROEOREOREORO!!!");
        }
      }
      catch(Exception ex)
      {
        Console.WriteLine("There was a problem...: {0}", ex.Message);
        Console.WriteLine("Try again?");
      }
    }
  }
}