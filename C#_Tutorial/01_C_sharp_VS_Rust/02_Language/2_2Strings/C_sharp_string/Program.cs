// See https://aka.ms/new-console-template for more information
using System;

namespace C_Sharp_String
{
  class Program
  {
    static void Main(string[] args)
    {

      Console.WriteLine("Hello, World!");

      bool CheckGroup(ReadOnlySpan<char> s)
      {
        // is 비교
        if (s is "admin") return true;

        // == 연산자로 비교
        if (s == "supervisor") return true;

        // switch expression 패턴 
        bool pass = s switch
        {
          "IT" => true,
          "HR" => true,
          _ => false
        };

        return pass;
      }

      // 테스트
      ReadOnlySpan<char> s = "IT".AsSpan();
      bool ok = CheckGroup(s);
      Console.WriteLine(ok);
    }
  }
}
