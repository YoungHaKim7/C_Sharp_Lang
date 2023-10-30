// See https://aka.ms/new-console-template for more information
using System;
using System.Text;
using Extensions;

namespace Extensions
{
  static class StringBuilderExtensions
  {
    public static void Wrap(this StringBuilder sb,
                            string left, string right) =>
        sb.Insert(0, left).Append(right);
  }
}

namespace A05_extension_methods
{
  class Program
  {
    static void Main(string[] args)
    {
      var sb = new StringBuilder("Hello, World C#");
      sb.Wrap(">>> ", " <<<");
      Console.WriteLine(sb.ToString());
    }
  }
}
