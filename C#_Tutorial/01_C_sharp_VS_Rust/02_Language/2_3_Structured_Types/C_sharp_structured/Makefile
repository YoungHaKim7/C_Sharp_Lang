r:
		dotnet run
clean:
		rm -rf obj bin
init:

		dotnet new console --language C#
		echo "using System;" >> Program.cs
		echo "" >> Program.cs
		echo "namespace `basename $(CURDIR)`" >> Program.cs
		echo "{" >> Program.cs
		echo "  class Program" >> Program.cs
		echo "  {" >> Program.cs
		echo "    static void Main(string[] args)" >> Program.cs
		echo "    {" >> Program.cs
		echo "      Console.WriteLine(\"Hello World C_Sharp"\);" >> Program.cs
		echo "    }" >> Program.cs
		echo "  }" >> Program.cs
		echo "}" >> Program.cs
