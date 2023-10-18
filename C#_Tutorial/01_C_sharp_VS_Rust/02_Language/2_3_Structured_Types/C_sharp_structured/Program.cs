// See https://aka.ms/new-console-template for more information
using System;

namespace C_sharp_structured
{
  class Program
  {
    static void Main(string[] args)
    {
      int[] someArray = new int[2] { 1, 2 };
      Console.WriteLine("Hello, World!" + someArray);
      for (int i = 0; i < someArray.Length; i++)
      {
        Console.WriteLine(someArray[i]);
      }

      Console.WriteLine("List");
      // List
      var something = new List<string>
      {
        "a",
        "b",
      };

      something.Add("c");
      for (int i = 0; i < something.Count; i++)
      {
        Console.WriteLine(something[i]);
      }
      Console.WriteLine("Hello, World!" + something[0]);

      Console.WriteLine("Tuples");
      // Tuples
      var something_tuple = (1, 2);
      Console.WriteLine($"a = {something_tuple.Item1}\nb= {something_tuple.Item2} ");

      Console.WriteLine("Dictionary");
      // Dictionary
      var something_dic = new Dictionary<string, string>
      {
        { "Foo", "Bar"},
        { "Baz", "Qux"},
      };

      something_dic.Add("hi", "there");
      for (int i = 0; i < something.Count; i++)
      {
        Console.WriteLine(something[i]);
      }
      Console.WriteLine($"Dictionary C# = {something_dic.Count} ");

      foreach (var value in something_dic.Values)
      {
        Console.WriteLine(value);
      }

    }
  }
}
