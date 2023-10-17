// See https://aka.ms/new-console-template for more information
using System;

namespace C_sharp_interpolation
{
  class Program
  {
    class Person
    {
      public string Name { get; set; }
      public int Age { get; set; }

      public override string ToString() =>
        $"Person {{Name: {Name}, Age: {Age}}}";
    }
    static void Main(string[] args)
    {
      var person = new Person { Name = "John", Age = 42 };
      Console.WriteLine(person);
    }
  }
}
