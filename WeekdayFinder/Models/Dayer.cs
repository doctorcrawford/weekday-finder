using System;

namespace WeekdayFinder.Models
{
  public class Dayer
  {
    public static int Year { get; set; }
    public static int Month { get; set; }
    public static int Day { get; set; }
    
    public static bool Splitter (string dateInput)
    {
      if (CheckString(dateInput))
      {
        string[] things = dateInput.Split('/');
        if (CheckInput(things))
        {
          SetDateFields(things);
          return true;
        }
        else
        {
          return false;
        };
      }
      else
      {
        return false;
      }
    }

    public static void SetDateFields(string[] input)
    {
      Month = int.Parse(input[0]);
      Day = int.Parse(input[1]);
      Year = int.Parse(input[2]);
    }
    public static bool CheckInput (string[] input)
    {
      bool flag = true;
      foreach (string thing in input)
      {
        if (int.TryParse(thing, out int thingNum))
        {
          return true;
        }
        else
        {
          flag = false;
        }
      }
      return flag;
    }

    public static bool CheckString(string input)
    {
      int counter = 0;
      foreach (char character in input)
      {
        if (character == '/')
        {
          counter++;
        }
      }
      return (counter == 2);
    }

    public static string Weekday()
    {
      DateTime newDate = new DateTime(Year, Month, Day);
      return newDate.ToString("dddd");
    }
  }
}