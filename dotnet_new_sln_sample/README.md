# dotnet create a solution, a console app, and tow class libraries.

<br>

https://learn.microsoft.com/en-us/dotnet/core/tools/dotnet-sln

<br>

<hr>

```
dotnet new sln -n mysolution
dotnet new console -o myapp
dotnet new classlib -o mylib1
dotnet new classlib -o mylib2
dotnet sln mysolution.sln add myapp\myapp.csproj
dotnet sln mysolution.sln add mylib1\mylib1.csproj --solution-folder mylibs
dotnet sln mysolution.sln add mylib2\mylib2.csproj --solution-folder mylibs

```

<br>

<hr>

- 실행 화면 

```
$ dotnet new sln -n mysolution
The template "Solution File" was created successfully.

$ dotnet new console -o myapp
The template "Console App" was created successfully.

Processing post-creation actions...
Running 'dotnet restore' on /Users/globalyoung/Documents/Project/Github/C_sharp_Projetct/C_Sharp_Lang/dotnet_new_sln_sample/myapp/myapp.csproj...
  Determining projects to restore...
  Restored /Users/globalyoung/Documents/Project/Github/C_sharp_Projetct/C_Sharp_Lang/dotnet_new_sln_sample/myapp/myapp.csproj (in 41 ms).
Restore succeeded.


$ dotnet new classlib -o mylib1
The template "Class Library" was created successfully.

Processing post-creation actions...
Running 'dotnet restore' on /Users/globalyoung/Documents/Project/Github/C_sharp_Projetct/C_Sharp_Lang/dotnet_new_sln_sample/mylib1/mylib1.csproj...
  Determining projects to restore...
  Restored /Users/globalyoung/Documents/Project/Github/C_sharp_Projetct/C_Sharp_Lang/dotnet_new_sln_sample/mylib1/mylib1.csproj (in 39 ms).
Restore succeeded.

$ dotnet new classlib -o mylib2
The template "Class Library" was created successfully.

Processing post-creation actions...
Running 'dotnet restore' on /Users/globalyoung/Documents/Project/Github/C_sharp_Projetct/C_Sharp_Lang/dotnet_new_sln_sample/mylib2/mylib2.csproj...
  Determining projects to restore...
  Restored /Users/globalyoung/Documents/Project/Github/C_sharp_Projetct/C_Sharp_Lang/dotnet_new_sln_sample/mylib2/mylib2.csproj (in 37 ms).
Restore succeeded.

$ ls
myapp          mylib1         mylib2         mysolution.sln

$ dotnet sln mysolution.sln add myapp/myapp.csproj
Project `myapp/myapp.csproj` added to the solution.

$ dotnet sln mysolution.sln add mylib1/mylib1.csproj
Project `mylib1/mylib1.csproj` added to the solution.

$ dotnet sln mysolution.sln add mylib2/mylib2.csproj
Project `mylib2/mylib2.csproj` added to the solution.

$ dotnet sln mysolution.sln list
Project(s)
----------
myapp/myapp.csproj
mylib1/mylib1.csproj
mylib2/mylib2.csproj



$ ls
myapp          mylib1         mylib2         mysolution.sln


$ cd myapp/
$ ls
Program.cs   bin          myapp.csproj obj


$ dotnet run
Hello, World!

```
