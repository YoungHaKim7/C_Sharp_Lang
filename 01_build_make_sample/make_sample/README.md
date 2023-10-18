# Make sample

```
echo "r:\xa\x09\x09dotnet run" >> Makefile &&

echo "clean:" >> Makefile &&
echo "\x09\x09rm -rf obj bin" >> Makefile &&
echo "init:\xa" >> Makefile &&
echo "\x09\x09dotnet new console --language C#" >> Makefile &&
echo "\x09\x09echo \x22using System;\x22 >> Program.cs" >> Makefile &&
echo "\x09\x09echo \x22\x22 >> Program.cs" >> Makefile &&
echo "\x09\x09echo \x22namespace \x60basename \x24\x28CURDIR\x29\x60\x22 >> Program.cs" >> Makefile &&
echo "\x09\x09echo \x22{\x22 >> Program.cs" >> Makefile &&
echo "\x09\x09echo \x22  class Program\x22 >> Program.cs" >> Makefile &&
echo "\x09\x09echo \x22  {\x22 >> Program.cs" >> Makefile &&
echo "\x09\x09echo \x22    static void Main(string[] args)\x22 >> Program.cs" >> Makefile &&
echo "\x09\x09echo \x22    {\x22 >> Program.cs" >> Makefile &&
echo "\x09\x09echo \x22      Console.WriteLine(\\\x22Hello World C_Sharp\\\x22);\x22 >> Program.cs" >> Makefile &&
echo "\x09\x09echo \x22    }\x22 >> Program.cs" >> Makefile &&
echo "\x09\x09echo \x22  }\x22 >> Program.cs" >> Makefile &&
echo "\x09\x09echo \x22}\x22 >> Program.cs" >> Makefile
```
