// See https://aka.ms/new-console-template for more information
using System;

namespace A06_non_destructive_mutations
{
  class Program
  {
    readonly record struct Point(int X, int Y);
    static void Main(string[] args)
    {
      var pt = new Point(123, 456);
      pt = pt with { X = 789 };
      Console.WriteLine(pt.ToString());
    }
  }
}
