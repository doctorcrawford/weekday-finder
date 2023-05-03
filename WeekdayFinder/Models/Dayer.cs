using System;

namespace WeekdayFinder.Models
{
  public class Dayer
  {
    public static int Year { get; set; }
    public static int Month { get; set; }
    public static int Day { get; set; }
    
    public static void Splitter (string dateInput)
    {
      string[] things = dateInput.Split('/');
      Month = Int32.Parse(things[0]);
      Day = Int32.Parse(things[1]);
      Year = Int32.Parse(things[2]);
    }
  }
}