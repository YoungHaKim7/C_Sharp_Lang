// See https://aka.ms/new-console-template for more information
using System;

namespace a02_enumeration_type
{
  class Program
  {
    enum DayOfWeek
    {
      Sunday = 0,
      Monday = 1,
      Tuesday = 2,
      Wednesday = 3,
      THursday = 4,
      Friday = 5,
      Saturday = 6,
    }
    static void Main(string[] args)
    {
      Console.WriteLine("Hello World C_Sharp");
      // Create a new DayOfWeek object.
      DayOfWeek dayOfWeek = DayOfWeek.Monday;

      Console.WriteLine(dayOfWeek.ToString());

    }
  }
}
