// See https://aka.ms/new-console-template for more information
using System;

namespace A03_enumeration02
{
  class Program
  {
    abstract record IpAddr
    {
      public sealed record V4(int V, byte A, byte B, byte C, byte D) : IpAddr;
      public sealed record V6(string Address) : IpAddr;
    }

    static void Main(string[] args)
    {
      Console.WriteLine("Hello World C_Sharp");
      var home = new IpAddr.V4(127, 0, 0, 0, 1);
      Console.WriteLine("ipaddrV4: " + home);
      var loopback = new IpAddr.V6("::1");
      Console.WriteLine("ip addr V6" + loopback);
    }
  }
}
