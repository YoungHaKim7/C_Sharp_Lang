// See https://aka.ms/new-console-template for more information
using System;
namespace A004_Searching
{
  class Program
  {
    static void Main(string[] args)
    {
      string sayHello = "Hello World";
      Console.WriteLine(sayHello);

      sayHello = sayHello.Replace("Hello", "Kendra");
      Console.WriteLine(sayHello);

      Console.WriteLine(sayHello.ToUpper());
      Console.WriteLine(sayHello.ToLower());

      Console.WriteLine(sayHello);
    }
  }
}


    
// $ dotnet run
//
// Hello World
// Kendra World
// KENDRA WORLD
// kendra world
// Kendra World    

