// See https://aka.ms/new-console-template for more information
using System;

namespace A01_structures
{
  class Program
  {
    struct Rectangle
    {
      public Rectangle(int x1, int y1, int x2, int y2) =>
      (X1, Y1, X2, Y2) = (x1, y1, x2, y2);

      public int X1 { get; }
      public int Y1 { get; }
      public int X2 { get; }
      public int Y2 { get; }

      public int Length => Y2 - Y1;
      public int Width => X2 - X1;

      public (int, int) TopLeft => (X1, Y1);
      public (int, int) BottomRight => (X2, Y2);

      public int Area => Length * Width;
      public bool IsSquare => Width == Length;

      public override string ToString() => $"{X1}, {Y1}, {X2}, {X2}";
    }

    static void Main(string[] args)
    {
      Console.WriteLine("Hello World C_Sharp");
      Console.WriteLine(new Rectangle(1, 2, 3, 4).ToString());
    }
  }
}
