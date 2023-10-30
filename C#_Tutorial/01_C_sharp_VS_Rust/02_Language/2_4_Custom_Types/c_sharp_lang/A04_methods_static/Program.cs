// See https://aka.ms/new-console-template for more information
using System;

namespace A04_methods_static
{
  class Program
  {
    readonly record struct Point(int X, int Y)
    {
      public static readonly Point Zero = new(0, 0);
    }
    static void Main(string[] args)
    {
      Console.WriteLine("Hello World C_Sharp");
      Console.WriteLine("Point : " + new Point(3, 4));
    }
  }
}
