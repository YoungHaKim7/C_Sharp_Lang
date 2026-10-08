<p align="center">
  <a href="https://learn.microsoft.com/en-us/dotnet/csharp/"><img alt="csharp" width="60px" src="https://user-images.githubusercontent.com/67513038/206488978-ab94802f-9f34-45b6-a456-876f900e3047.png"></a>
</p>

<hr>

# C# playground

- https://www.w3schools.com/cs/cs_compiler.php

- https://www.jdoodle.com/compile-c-sharp-online

- The .NET Programmer’s Playground
  - https://www.linqpad.net/
- GN⁺: LINQPad – .NET 프로그래머를 위한 Playground (linqpad.net)
  - https://news.hada.io/topic?id=15501&utm_source=discord&utm_medium=bot&utm_campaign=1480

# C# Visual Studio Shortcuts(CheatSheet)
- https://learn.microsoft.com/en-us/visualstudio/ide/default-keyboard-shortcuts-in-visual-studio?view=visualstudio
- 한글 설명서
  - https://learn.microsoft.com/ko-kr/visualstudio/ide/default-keyboard-shortcuts-in-visual-studio?view=visualstudio

# C#: 공부하기 좋은곳

- https://learn.microsoft.com/en-us/dotnet/csharp/tour-of-csharp (영어; 한국어 번역은 기계번역, 퀄리티 낮음)

- Model Binding in ASP.NET Core
  - https://learn.microsoft.com/en-us/aspnet/core/mvc/models/model-binding?view=aspnetcore-8.0

<hr>


# C# 언어의 꽃🌹❤️링큐 LINQ & C#의 창시자, 앤더스 하일스버그(아네르스 하일스베르(덴마크어: Anders Hejlsberg) - 

- Microsoft의 LINQ설명
  - https://microsoft.github.io/rust-for-dotnet-devs/latest/linq/index.html

https://economiceco.tistory.com/m/16241

https://learn.microsoft.com/ko-kr/dotnet/api/system.linq?view=net-7.0
- LinQ 링큐 강의🌯 몰아보기 #12 - 이거 하나면 끝!!! LinQ Basics tutorial | chaems
  - https://youtu.be/5ieU9A8hYP0?si=KMjMkk8sfa-fGQIl

- 유니티 C# 고급문법 LINQ | 게이머TV
  - https://youtu.be/o3CQgqGRTgY?si=v7DE2yf1pFN4WpTB


## Advanced C# – LINQ Tutorial | freeCodeCamp.org
- https://youtu.be/5l2qA3Pc83M?si=Y89OrX5-Yvdko1io
  - MS공식 문서 설명(LINQ)
    - https://learn.microsoft.com/en-us/dotnet/csharp/linq/

- Language-Integrated Query (LINQ) is the name for a set of technologies based on the integration of query capabilities directly into the C# language. Traditionally, queries against data are expressed as simple strings without type checking at compile time or IntelliSense support. Furthermore, you have to learn a different query language for each type of data source: SQL databases, XML documents, various Web services, and so on. With LINQ, a query is a first-class language construct, just like classes, methods, and events.
  - LINQ(Language-Integrated Query)는 쿼리 기능을 C# 언어로 직접 통합하는 기술 집합의 이름입니다. 기존에는 데이터에 대한 쿼리를 컴파일 시 또는 IntelliSense 지원 시 유형 검사 없이 간단한 문자열로 표현합니다. 또한 SQL 데이터베이스, XML 문서, 다양한 웹 서비스 등 데이터 소스 유형별로 다른 쿼리 언어를 학습해야 합니다. LINQ를 사용하면 쿼리는 클래스, 메서드 및 이벤트와 마찬가지로 일급 언어 구성입니다.
    
- When you write queries, the most visible "language-integrated" part of LINQ is the query expression. Query expressions are written in a declarative query syntax. By using query syntax, you perform filtering, ordering, and grouping operations on data sources with a minimum of code. You use the same query expression patterns to query and transform data from any type of data source.
  - 쿼리를 작성할 때 LINQ에서 가장 눈에 띄는 "언어 통합" 부분은 쿼리 표현식입니다. 쿼리 표현식은 선언적 쿼리 구문으로 작성됩니다. 쿼리 구문을 사용하여 최소 코드로 데이터 소스에 대한 필터링, 순서 지정 및 그룹화 작업을 수행합니다. 동일한 쿼리 표현식 패턴을 사용하여 모든 유형의 데이터 소스에서 데이터를 쿼리하고 변환합니다.

- The following example shows a complete query operation. The complete operation includes creating a data source, defining the query expression, and executing the query in a foreach statement.
  - 다음 예제는 완전한 쿼리 작업을 보여줍니다. 완전한 작업은 데이터 소스를 만들고, 쿼리 표현식을 정의하고, 각 문에 대해 쿼리를 실행하는 것을 포함합니다.

```cs

// Specify the data source.
int[] scores = [97, 92, 81, 60];

// Define the query expression.
IEnumerable<int> scoreQuery =
    from score in scores
    where score > 80
    select score;

// Execute the query.
foreach (var i in scoreQuery)
{
    Console.Write(i + " ");
}

// Output: 97 92 81
```


<hr>

# C#의 창시자 & TypeScript 창시자  , 앤더스 헤일즈버그 (Anders Hejlsberg

https://www.csharpstudy.com/Story/Article/2

https://dev.to/destrodevshow/typescript-and-c-both-created-by-the-same-person-named-anders-hejlsberg-42g4

<br>

<hr>

# 상단에 숨겨진 Using 보이게 세팅하기

- So you could add your own namespaces if you like.
- To disable implicit global usings, that is the generation of the <projectname>.GlobalUsings.g.cs file, set the ImplicitUsings property to disable in your csproj file:

```
<PropertyGroup>
    <ImplicitUsings>disable</ImplicitUsings>
</PropertyGroup>

```
- *.csproj (이 파일에서 세팅해주면 된다.)
- 한참을 찾았다. C#은 왜 숨기는걸 왜케 좋아하는지 모르겠다. 다 숨긴다...
- https://www.hanselman.com/blog/implicit-usings-in-net-6
- https://twitter.com/okyrylchuk/status/1441432245932380161


https://stackoverflow.com/questions/74826313/how-to-show-all-using-directives-visual-studio-2022

# Configure Keyboard Shortcuts:(Visual Studio)

- Tools -> Options; Environment -> Keyboard
  - https://visualstudio.microsoft.com/keyboard-shortcuts.pdf

- If you want to edit the shortcut of quick fix
  - https://stackoverflow.com/questions/9786144/visual-studio-shortcut-for-quick-fix
```
if you want to edit the shortcut of quick fix you can do the following:
 Open Tools->Options
->Keyboard
and in the Show commands containing field enter EditorContextMenus.CodeWindow.QuickActionsForPosition

and replace the old shortcut with the new one.
```

- Learn C# (Visual Stuio)
  - https://learn.microsoft.com/ko-kr/visualstudio/ide/not-in-toc/welcome-to-visual-studio-docs?view=vs-2022&f1url=%3FappId%3DDev16IDEF1%26l%3DKO-KR%26k%3Dk(vs.ViewHelp)%3Bk(DevLang-csharp)%26rd%3Dtrue

<hr>

# VS Code Extension(C# Dev Kit)

https://marketplace.visualstudio.com/items?itemName=ms-dotnettools.csdevkit

<hr>


# .gitignore C#(Visual Studio)

- A collection of useful .gitignore templates
  - https://github.com/github/gitignore

```
## Ignore Visual Studio temporary files, build results, and
## files generated by popular Visual Studio add-ons.
##
## Get latest from https://github.com/github/gitignore/blob/master/VisualStudio.gitignore

# User-specific files
*.rsuser
*.suo
*.user
*.userosscache
*.sln.docstates

# User-specific files (MonoDevelop/Xamarin Studio)
*.userprefs

# Mono auto generated files
mono_crash.*

# Build results
[Dd]ebug/
[Dd]ebugPublic/
[Rr]elease/
[Rr]eleases/
x64/
x86/
[Ww][Ii][Nn]32/
[Aa][Rr][Mm]/
[Aa][Rr][Mm]64/
bld/
[Bb]in/
[Oo]bj/
[Oo]ut/
[Ll]og/
[Ll]ogs/

# Visual Studio 2015/2017 cache/options directory
.vs/
# Uncomment if you have tasks that create the project's static files in wwwroot
#wwwroot/

# Visual Studio 2017 auto generated files
Generated\ Files/

# MSTest test Results
[Tt]est[Rr]esult*/
[Bb]uild[Ll]og.*

# NUnit
*.VisualState.xml
TestResult.xml
nunit-*.xml

# Build Results of an ATL Project
[Dd]ebugPS/
[Rr]eleasePS/
dlldata.c

# Benchmark Results
BenchmarkDotNet.Artifacts/

# .NET Core
project.lock.json
project.fragment.lock.json
artifacts/

# ASP.NET Scaffolding
ScaffoldingReadMe.txt

# StyleCop
StyleCopReport.xml

# Files built by Visual Studio
*_i.c
*_p.c
*_h.h
*.ilk
*.meta
*.obj
*.iobj
*.pch
*.pdb
*.ipdb
*.pgc
*.pgd
*.rsp
*.sbr
*.tlb
*.tli
*.tlh
*.tmp
*.tmp_proj
*_wpftmp.csproj
*.log
*.vspscc
*.vssscc
.builds
*.pidb
*.svclog
*.scc

# Chutzpah Test files
_Chutzpah*

# Visual C++ cache files
ipch/
*.aps
*.ncb
*.opendb
*.opensdf
*.sdf
*.cachefile
*.VC.db
*.VC.VC.opendb

# Visual Studio profiler
*.psess
*.vsp
*.vspx
*.sap

# Visual Studio Trace Files
*.e2e

# TFS 2012 Local Workspace
$tf/

# Guidance Automation Toolkit
*.gpState

# ReSharper is a .NET coding add-in
_ReSharper*/
*.[Rr]e[Ss]harper
*.DotSettings.user

# TeamCity is a build add-in
_TeamCity*

# DotCover is a Code Coverage Tool
*.dotCover

# AxoCover is a Code Coverage Tool
.axoCover/*
!.axoCover/settings.json

# Coverlet is a free, cross platform Code Coverage Tool
coverage*.json
coverage*.xml
coverage*.info

# Visual Studio code coverage results
*.coverage
*.coveragexml

# NCrunch
_NCrunch_*
.*crunch*.local.xml
nCrunchTemp_*

# MightyMoose
*.mm.*
AutoTest.Net/

# Web workbench (sass)
.sass-cache/

# Installshield output folder
[Ee]xpress/

# DocProject is a documentation generator add-in
DocProject/buildhelp/
DocProject/Help/*.HxT
DocProject/Help/*.HxC
DocProject/Help/*.hhc
DocProject/Help/*.hhk
DocProject/Help/*.hhp
DocProject/Help/Html2
DocProject/Help/html

# Click-Once directory
publish/

# Publish Web Output
*.[Pp]ublish.xml
*.azurePubxml
# Note: Comment the next line if you want to checkin your web deploy settings,
# but database connection strings (with potential passwords) will be unencrypted
*.pubxml
*.publishproj

# Microsoft Azure Web App publish settings. Comment the next line if you want to
# checkin your Azure Web App publish settings, but sensitive information contained
# in these scripts will be unencrypted
PublishScripts/

# NuGet Packages
*.nupkg
# NuGet Symbol Packages
*.snupkg
# The packages folder can be ignored because of Package Restore
**/[Pp]ackages/*
# except build/, which is used as an MSBuild target.
!**/[Pp]ackages/build/
# Uncomment if necessary however generally it will be regenerated when needed
#!**/[Pp]ackages/repositories.config
# NuGet v3's project.json files produces more ignorable files
*.nuget.props
*.nuget.targets

# Microsoft Azure Build Output
csx/
*.build.csdef

# Microsoft Azure Emulator
ecf/
rcf/

# Windows Store app package directories and files
AppPackages/
BundleArtifacts/
Package.StoreAssociation.xml
_pkginfo.txt
*.appx
*.appxbundle
*.appxupload

# Visual Studio cache files
# files ending in .cache can be ignored
*.[Cc]ache
# but keep track of directories ending in .cache
!?*.[Cc]ache/

# Others
ClientBin/
~$*
*~
*.dbmdl
*.dbproj.schemaview
*.jfm
*.pfx
*.publishsettings
orleans.codegen.cs

# Including strong name files can present a security risk
# (https://github.com/github/gitignore/pull/2483#issue-259490424)
#*.snk

# Since there are multiple workflows, uncomment next line to ignore bower_components
# (https://github.com/github/gitignore/pull/1529#issuecomment-104372622)
#bower_components/

# RIA/Silverlight projects
Generated_Code/

# Backup & report files from converting an old project file
# to a newer Visual Studio version. Backup files are not needed,
# because we have git ;-)
_UpgradeReport_Files/
Backup*/
UpgradeLog*.XML
UpgradeLog*.htm
ServiceFabricBackup/
*.rptproj.bak

# SQL Server files
*.mdf
*.ldf
*.ndf

# Business Intelligence projects
*.rdl.data
*.bim.layout
*.bim_*.settings
*.rptproj.rsuser
*- [Bb]ackup.rdl
*- [Bb]ackup ([0-9]).rdl
*- [Bb]ackup ([0-9][0-9]).rdl

# Microsoft Fakes
FakesAssemblies/

# GhostDoc plugin setting file
*.GhostDoc.xml

# Node.js Tools for Visual Studio
.ntvs_analysis.dat
node_modules/

# Visual Studio 6 build log
*.plg

# Visual Studio 6 workspace options file
*.opt

# Visual Studio 6 auto-generated workspace file (contains which files were open etc.)
*.vbw

# Visual Studio LightSwitch build output
**/*.HTMLClient/GeneratedArtifacts
**/*.DesktopClient/GeneratedArtifacts
**/*.DesktopClient/ModelManifest.xml
**/*.Server/GeneratedArtifacts
**/*.Server/ModelManifest.xml
_Pvt_Extensions

# Paket dependency manager
.paket/paket.exe
paket-files/

# FAKE - F# Make
.fake/

# CodeRush personal settings
.cr/personal

# Python Tools for Visual Studio (PTVS)
__pycache__/
*.pyc

# Cake - Uncomment if you are using it
# tools/**
# !tools/packages.config

# Tabs Studio
*.tss

# Telerik's JustMock configuration file
*.jmconfig

# BizTalk build output
*.btp.cs
*.btm.cs
*.odx.cs
*.xsd.cs

# OpenCover UI analysis results
OpenCover/

# Azure Stream Analytics local run output
ASALocalRun/

# MSBuild Binary and Structured Log
*.binlog

# NVidia Nsight GPU debugger configuration file
*.nvuser

# MFractors (Xamarin productivity tool) working folder
.mfractor/

# Local History for Visual Studio
.localhistory/

# BeatPulse healthcheck temp database
healthchecksdb

# Backup folder for Package Reference Convert tool in Visual Studio 2017
MigrationBackup/

# Ionide (cross platform F# VS Code tools) working folder
.ionide/

# Fody - auto-generated XML schema
FodyWeavers.xsd 
  
```

# dotnet new

```
dotnet new console --language C#

dotnet run


```

# C# gitignore(dotnet new)

```
bin/
obj/
  
```


<hr>

# [개발도구 꿀팁] Visual Studio 에서 Git 사용하는 방법 (기초)
https://youtu.be/aG0zuM8XuP4

# Visual Assist supports keyboard access to all of its features. (Visual Studio Plugin _ VAssistX | Help | Keyboard Shortcuts.)

https://docs.wholetomato.com/default.asp?W375

# Visual Studio Tips & Tricks

https://www.youtube.com/playlist?list=PLReL099Y5nRc-zbaFbf0aNcIamBQujOxP

# Keyboard shortcuts in Visual Studio

https://learn.microsoft.com/en-us/visualstudio/ide/default-keyboard-shortcuts-in-visual-studio?view=vs-2022&utm_source=vshelp&wt.mc_id=visualstudio_inproduct_shortcuts_csaapp

<hr>

<hr>

# Rust for C#/.NET Developers(<a href="https://learn.microsoft.com/en-us/dotnet/csharp/"><img alt="csharp" width="30px" src="https://user-images.githubusercontent.com/67513038/206488978-ab94802f-9f34-45b6-a456-876f900e3047.png"></a>Tutorial<a href="https://www.rust-lang.org/"><img align="left" alt="rust1" width="26px" src="https://user-images.githubusercontent.com/67513038/213436632-820a1675-98d9-4626-979d-be63c60cdcb7.png" /></a> eBook🖼💻📖)

https://microsoft.github.io/rust-for-dotnet-devs/latest/

#  Free e-book: Blazor for ASP.NET Web Forms Developers (MicroSoft)

https://devblogs.microsoft.com/dotnet/blazor-aspnet-webforms-ebook/

- https://learn.microsoft.com/en-us/dotnet/architecture/blazor-for-web-forms-developers/

# 24hr) Create a C# Application from Start to Finish - Complete Course 

https://youtu.be/wfWxdh-_k_4

<br>

<hr>

# Complete Beginner Courses | C# Tutorial for Beginners | Learn the Basics of C# programming 🖥️ Csharp Tutorial for Beginners | tutorialsEU

https://youtu.be/UKaZ2S4AJAA

<br>

# Complete Beginner Courses

https://youtube.com/playlist?list=PLwhVruPHD9rxZ9U5K6vqUFkfrjaRhwEsV

# C# (LeetCodeNet) Training 👍

https://github.com/kulikov-dev/LeetCodeNet

<br>

<hr>

#  dotnet 기초 상식

첫 번째 앱 작성: 

https://aka.ms/dotnet-hello-world

<br>

새로운 기능 확인: 

https://aka.ms/dotnet-whats-new

<br>

설명서 살펴보기: 

https://aka.ms/dotnet-docs

<br>

GitHub에서 문제 보고 및 소스 찾기: 

https://github.com/dotnet/core

<br>

<br>

사용 가능한 명령을 보려면 'dotnet --help'를 사용하거나 

https://aka.ms/dotnet-cli

를 방문하세요.

- dotnet sln

https://learn.microsoft.com/en-us/dotnet/core/tools/dotnet-sln

<br>

# Microsoft. NET SDK 7.0.100 Choco install

```
> choco install dotnet-sdk

```

<br>

# Get started vscos c# net Core Windows OS

- 1로 설치하면됨

https://learn.microsoft.com/ko-kr/dotnet/core/install/windows?tabs=net70

<br>

- 설치 설명서 

https://learn.microsoft.com/en-us/shows/dotnet/get-started-vscode-csharp-net-core-windows

<br>

<hr>



# C# 키워드 - C_Sharp_Referece_Documentation

https://learn.microsoft.com/ko-kr/dotnet/csharp/language-reference/keywords/

- C# Language Referece

https://learn.microsoft.com/ko-kr/dotnet/csharp/language-reference/

- C# documentation

https://learn.microsoft.com/en-us/dotnet/csharp/

<br>

# Visual Studio for Mac IDE tour

https://learn.microsoft.com/en-us/visualstudio/mac/ide-tour?view=vsmac-2022


# C# Cheat Sheets

https://cheatography.com/ziggiboy/cheat-sheets/c/

<br>

# C# 기본 틀

- C_Sharp_Lang/exercise/A003_Searching_strings/

```
// console 만들기 
dotnet new console --language C#

// 실행하기 
dotnet run
```

```

tree
.
├── A003_Searching_strings.csproj
├── Program.cs
└── delete.sh


```


- Program.cs

```
// See https://aka.ms/new-console-template for more information
using System;

namespace A003_Searching_strings
{
  class Program
  {
    static void Main(string[] args)
    {
      string firstFriend = "Maria";
      string sencondFriend = "Sage";
      Console.WriteLine($"My friend are {firstFriend} and {sencondFriend}");
    }
  }
}

// result :  
// My friend ar Maria and Sage

```

https://blockdmask.tistory.com/359

[C#] string format, 문자열 보간($)을 이용한 문자열 출력방법

<br>

- C# for Beginners


https://youtube.com/playlist?list=PLdo4fOcmZ0oVxKLQCHpiUWun7vlJJvUiN

<br>

<hr>

# csc.exe 컴파일 하기 (WindowsOS 기준)

- C:\Windows\Microsoft.NET\Framework\v4.0.30319\csc.exe hello.cs

- \MicrosoftVisualStudio\MSBuild\Current\Bin\Roslyn



```
PS D:\Young_Project\C_Sharp_Lang\C_Sharp_Lang\Hello_C_sharp2> csc .\Hello1.cs
Microsoft (R) Visual C# 컴파일러 버전 3.11.0-4.22108.8 (d9bef045)
Copyright (C) Microsoft Corporation. All rights reserved.

PS Hello_C_sharp2> ls

    Directory: D:\Hello_C_sharp2

Mode                 LastWriteTime         Length Name
----                 -------------         ------ ----
-a---        2022-12-05  오후 6:50            105 Hello1.cs
-a---        2022-12-05  오후 6:50           3584 Hello1.exe
-a---        2022-12-05  오후 6:50             48 Hello2.cs
-a---        2022-12-05  오후 6:50            178 README.md

PS Hello_C_sharp2> .\Hello1.exe

Hello, world C#

```

<br>

- hello.cs

```

using System;

class Hello
{
	static void Main()
	{
		Console.WriteLine("Hello, world C# ");
	}
}

```


<hr>

# Vim Setting

Example vimrc
Below is an example .vimrc for getting started with OmniSharp-vim. For a more complete example with autocompletion, fzf integration, statusline indicators etc., have a look at the Example config in the wiki.

<br>

```
" Use the vim-plug plugin manager: https://github.com/junegunn/vim-plug
" Remember to run :PlugInstall when loading this vimrc for the first time, so
" vim-plug downloads the plugins listed.

silent! if plug#begin('~/.vim/plugged')
Plug 'OmniSharp/omnisharp-vim'
Plug 'dense-analysis/ale'
call plug#end()
endif

" Don't autoselect first omnicomplete option, show options even if there is only
" one (so the preview documentation is accessible). Remove 'preview', 'popup'
" and 'popuphidden' if you don't want to see any documentation whatsoever.
" Note that neovim does not support `popuphidden` or `popup` yet:
" https://github.com/neovim/neovim/issues/10996
if has('patch-8.1.1880')
  set completeopt=longest,menuone,popuphidden
  " Highlight the completion documentation popup background/foreground the same as
  " the completion menu itself, for better readability with highlighted
  " documentation.
  set completepopup=highlight:Pmenu,border:off
else
  set completeopt=longest,menuone,preview
  " Set desired preview window height for viewing documentation.
  set previewheight=5
endif

" Tell ALE to use OmniSharp for linting C# files, and no other linters.
let g:ale_linters = { 'cs': ['OmniSharp'] }

augroup omnisharp_commands
  autocmd!

  " Show type information automatically when the cursor stops moving.
  " Note that the type is echoed to the Vim command line, and will overwrite
  " any other messages in this space including e.g. ALE linting messages.
  autocmd CursorHold *.cs OmniSharpTypeLookup

  " The following commands are contextual, based on the cursor position.
  autocmd FileType cs nmap <silent> <buffer> gd <Plug>(omnisharp_go_to_definition)
  autocmd FileType cs nmap <silent> <buffer> <Leader>osfu <Plug>(omnisharp_find_usages)
  autocmd FileType cs nmap <silent> <buffer> <Leader>osfi <Plug>(omnisharp_find_implementations)
  autocmd FileType cs nmap <silent> <buffer> <Leader>ospd <Plug>(omnisharp_preview_definition)
  autocmd FileType cs nmap <silent> <buffer> <Leader>ospi <Plug>(omnisharp_preview_implementations)
  autocmd FileType cs nmap <silent> <buffer> <Leader>ost <Plug>(omnisharp_type_lookup)
  autocmd FileType cs nmap <silent> <buffer> <Leader>osd <Plug>(omnisharp_documentation)
  autocmd FileType cs nmap <silent> <buffer> <Leader>osfs <Plug>(omnisharp_find_symbol)
  autocmd FileType cs nmap <silent> <buffer> <Leader>osfx <Plug>(omnisharp_fix_usings)
  autocmd FileType cs nmap <silent> <buffer> <C-\> <Plug>(omnisharp_signature_help)
  autocmd FileType cs imap <silent> <buffer> <C-\> <Plug>(omnisharp_signature_help)

  " Navigate up and down by method/property/field
  autocmd FileType cs nmap <silent> <buffer> [[ <Plug>(omnisharp_navigate_up)
  autocmd FileType cs nmap <silent> <buffer> ]] <Plug>(omnisharp_navigate_down)
  " Find all code errors/warnings for the current solution and populate the quickfix window
  autocmd FileType cs nmap <silent> <buffer> <Leader>osgcc <Plug>(omnisharp_global_code_check)
  " Contextual code actions (uses fzf, vim-clap, CtrlP or unite.vim selector when available)
  autocmd FileType cs nmap <silent> <buffer> <Leader>osca <Plug>(omnisharp_code_actions)
  autocmd FileType cs xmap <silent> <buffer> <Leader>osca <Plug>(omnisharp_code_actions)
  " Repeat the last code action performed (does not use a selector)
  autocmd FileType cs nmap <silent> <buffer> <Leader>os. <Plug>(omnisharp_code_action_repeat)
  autocmd FileType cs xmap <silent> <buffer> <Leader>os. <Plug>(omnisharp_code_action_repeat)

  autocmd FileType cs nmap <silent> <buffer> <Leader>os= <Plug>(omnisharp_code_format)

  autocmd FileType cs nmap <silent> <buffer> <Leader>osnm <Plug>(omnisharp_rename)

  autocmd FileType cs nmap <silent> <buffer> <Leader>osre <Plug>(omnisharp_restart_server)
  autocmd FileType cs nmap <silent> <buffer> <Leader>osst <Plug>(omnisharp_start_server)
  autocmd FileType cs nmap <silent> <buffer> <Leader>ossp <Plug>(omnisharp_stop_server)
augroup END

" Enable snippet completion, using the ultisnips plugin
" let g:OmniSharp_want_snippet=1

```

<br>

https://github.com/OmniSharp/omnisharp-vim

# Vim omnicompletion (intellisense) and more for C#

https://github.com/OmniSharp/omnisharp-vim

<br>

# coc-omnisharp
⛔ This project is lacking proper maintanence. I would recommend csharp-ls at this moment.
I may work on the integration of csharp-ls in the future, but now please manually set it up.

```
dotnet tool install --global csharp-ls

```

```
:CocConfig


{
    "languageserver": {
        "csharp-ls": {
          "command": "csharp-ls",
          "filetypes": ["cs"],
          "rootPatterns": ["*.csproj", ".vim/", ".git/", ".hg/"]
        }
    }
}

```

=== Original README below ===

A vim plugin powered by OmniSharp and coc.nvim.

Prerequisites
Vim 8.0+ or NeoVim
dotnet
coc.nvim
Installation
coc-omnisharp is an extension for coc.nvim. You can install coc.nvim with a plugin manager like vim-plug:
```
Plug 'neoclide/coc.nvim', {'branch': 'release'}
Then, use :CocInstall coc-omnisharp to install.

```

Alternatively, you can have coc.nvim automatically install the extension if it's missing:

```
let g:coc_global_extensions=[ 'coc-omnisharp', ... ]
```

Configuration

https://github.com/coc-extensions/coc-omnisharp

<hr>

# My_Setting (:CocConfig)

```
{
    // rust-analyzer.procMacro.enable=true,
    // rust-analyzer.inlayHints.typeHints.enable=true,
      "rust-analyzer.inlayHints.enable": true,
      "rust-analyzer.cargo.loadOutDirsFromCheck": true,
      "rust-analyzer.procMacro.enable": true,

    "languageserver": {
        "csharp-ls": {
          "command": "csharp-ls",
          "filetypes": ["cs"],
          "rootPatterns": ["*.csproj", ".vim/", ".git/", ".hg/"]
        }
    },

      "ada.serverBin": "ada_language_server", // must be in the path, otherwise use full path to the binary
      "ada.enabled": true,
      "ada.trace.server": "off",
      "ada.projectFile": "", // See below
      "ada.scenarioVariables": {},
      "ada.defaultCharset":  "iso-8859-1",
      "ada.displayMethodAncestryOnNavigation": "usage_and_abstract_only", // never | usage_and_abstract_only | definition_only | always
      "ada.enableDiagnostics": true,
      "ada.renameInComments": false
}

```

<br>

<hr>

# Github는 왜 기본 gitignore 파일에 C#을 지원해주지 않을까요?

https://forum.dotnetdev.kr/t/github-gitignore-c/487/2

<br>

- 단서 2

https://www.toptal.com/developers/gitignore/api/csharp


<br>

<hr>

# Learning C#

- Korean

https://learn.microsoft.com/ko-kr/dotnet/csharp/


- en-us
https://learn.microsoft.com/en-us/dotnet/csharp/

<br>

<hr>

# C# dotnet

cargo init 과 비슷함 폴더 만들고 그 안에서 치면 됨.


```
dotnet new console --language C#

dotnet run

```

# C# Dotnet

https://learn.microsoft.com/en-us/dotnet/

<br>

```
dotnet new console -o sample1
cd sample1
dotnet run
```

<br>

# C# dotnet command

https://economiceco.tistory.com/13924


```
// 콘솔 프로젝트 만들기
dotnet new console



// 새로 만들 수 있는 list를 볼 수 있다
dotnet new --list

```


```
// 지정된 디렉터리에서 프로젝트 및 해당 종속성을 빌드합니다.
// .NET CLI


dotnet build
```

https://docs.microsoft.com/ko-kr/dotnet/core/tools/dotnet-run


https://docs.microsoft.com/ko-kr/dotnet/core/get-started



```
// 애플리케이션을 실행 한다 dll실행 됨 대박 ㅋ

dotnet myapp.dll
```

https://docs.microsoft.com/ko-kr/dotnet/core/tools/dotnet





<br>


# dotnet명령어 깊이 파고 들어가기

```
// dotnet 명령
// 일반

// 명령	함수
dotnet build	.NET 애플리케이션을 빌드합니다.
dotnet build-server	빌드에서 시작된 서버와 상호 작용합니다.
dotnet clean	빌드 출력을 정리합니다.
dotnet help	명령에 대한 자세한 온라인 설명서를 표시합니다.
dotnet migrate	유효한 Preview 2 프로젝트를 .NET Core SDK 1.0 프로젝트로 마이그레이션합니다.
dotnet msbuild	MSBuild 명령줄에 대한 액세스 권한을 제공합니다.
dotnet new	지정한 템플릿에 대해 C# 또는 F# 프로젝트를 초기화합니다.
dotnet pack	코드의 NuGet 패키지를 만듭니다.
dotnet publish	.NET Framework 종속형 또는 자체 포함 애플리케이션을 게시합니다.
dotnet restore	지정된 애플리케이션에 대한 종속성을 복원합니다.
dotnet run	소스에서 애플리케이션을 실행합니다.
dotnet sdk check	설치된 SDK 및 런타임 버전의 최신 상태를 표시합니다.
dotnet sln	솔루션 파일에 프로젝트를 추가, 제거 및 나열하는 옵션입니다.
dotnet store	어셈블리를 런타임 패키지 저장소에 저장합니다.
dotnet test	Test Runner를 사용하여 테스트를 실행합니다.

```


- 프로젝트 참조

```
// 프로젝트 참조

// 명령	함수
dotnet add reference	프로젝트 참조를 추가합니다.
dotnet list reference	프로젝트 참조를 나열합니다.
dotnet remove reference	프로젝트 참조를 제거합니다
```


- NuGet 패키지

```
// NuGet 패키지

// 명령	함수
dotnet add package	NuGet 패키지를 추가합니다.
dotnet remove package	NuGet 패키지를 제거합니다
```





- NuGet 명령

```
// NuGet 명령

// 명령	함수
dotnet nuget delete	서버에서 패키지를 삭제하거나 목록에서 제거합니다.
dotnet nuget push	서버에 패키지를 푸시하고 게시합니다.
dotnet nuget locals	http-request 캐시, 임시 캐시 또는 시스템 전체의 글로벌 패키지 폴더와 같은 로컬 NuGet 리소스를 지우거나 목록에 포함합니다.
dotnet nuget add source	NuGet 소스를 추가합니다.
dotnet nuget disable source	NuGet 소스를 사용하지 않도록 설정합니다.
dotnet nuget enable source	NuGet 소스를 사용하도록 설정합니다.
dotnet nuget list source	구성된 NuGet 소스를 모두 나열합니다.
dotnet nuget remove source	NuGet 소스를 제거합니다.
dotnet nuget update source	NuGet 소스를 업데이트합니다
```

- en-us
https://learn.microsoft.com/en-us/dotnet/core/tools/dotnet

/ 워크로드 명령

```
/ 워크로드 명령

// 명령	기능

dotnet workload install	선택적 워크로드를 설치합니다.
dotnet workload list	설치된 모든 워크로드를 나열합니다.
dotnet workload repair	설치된 모든 워크로드를 복구합니다.
dotnet workload search	선택한 워크로드 또는 사용 가능한 모든 워크로드를 나열합니다.
dotnet workload uninstall	워크로드를 제거합니다.
dotnet workload update	설치된 모든 워크로드를 다시 설치합니다.

```


- en-us

https://learn.microsoft.com/en-us/dotnet/core/tools/dotnet

-	컴퓨터에 도구를 설치합니다.

```
//	컴퓨터에 도구를 설치합니다.

dotnet tool install




dotnet tool list	컴퓨터에 현재 설치되어 있는 모든 전역, 도구 경로 또는 로컬 도구를 나열합니다.
dotnet tool search	NuGet.org에서 지정된 검색 용어가 이름 또는 메타데이터에 포함된 도구를 검색합니다.
dotnet tool uninstall	컴퓨터에서 도구를 제거합니다.
dotnet tool update	컴퓨터에 설치된 도구를 업데이트합니다


```

- en-us

https://learn.microsoft.com/en-us/dotnet/core/tools/dotnet

- korean

https://docs.microsoft.com/ko-kr/dotnet/core/tools/dotnet


<hr>

<br>


# C# Tutorial


- Use C# on macOS

```
brew install dotnet

```


<br>

# C# Documentation

https://learn.microsoft.com/en-us/dotnet/whats-new/

<br>

# C# Cheatsheet 

https://simplecheatsheet.com/tag/c-cheat-sheet-1/


<br>

# C# for Beginners 

https://economiceco.tistory.com/14236


- C# tutorial for beginners

https://youtube.com/playlist?list=PLZPZq0r_RZOPNy28FDBys3GVP2LiaIyP_


<br>

<br>

<hr>

# Rust vs C# primitive type

- 영어 출처
https://learn.microsoft.com/en-us/dotnet/api/system.type.isprimitive?view=net-7.0

<br>

 8bit = 1 bytes

<br>

<table border="1">
    <tr>
    <td colspan="3" align="center">Rust vs C#</td>
    </tr>
    <tr align="center">
        <td>분류(Type) </td>
        <td>Rust</td>
        <td>C# </td>
    </tr>
    <tr align="center">
        <td>Char<br>char</td>
        <td>i8<br>(size: 4 bytes)</td>
        <td>char<br>(size: 2 bytes)</td>
    </tr>
    <tr align="center">
        <td>signed integer<br>8bit</td>
        <td>i8<br>(size: 1 bytes)</td>
        <td>sbyte<br>(size: 1 bytes)</td>
    </tr>
    <tr align="center">
        <td>signed integer<br>16bit</td>
        <td>i16<br>(size: 2 bytes)</td>
        <td>short<br>(size: 2 bytes)</td>
    </tr>
    <tr align="center">
        <td>signed integer<br>32bit</td>
        <td>i32<br>(size: 4 bytes)</td>
        <td>int<br>(size: 4 bytes)</td>
    </tr>
    <tr align="center">
        <td>signed integer<br>64bit</td>
        <td>i64<br>(size: 8 bytes)</td>
        <td>long</td>
    </tr>
    <tr align="center">
        <td>--</td>
        <td>--</td>
        <td>--</td>
    </tr>
    <tr align="center">
        <td>unsigned integer<br>8bit</td>
        <td>u8</td>
        <td>byte</td>
    </tr>
    <tr align="center">
        <td>unsigned integer<br>16bit</td>
        <td>u16</td>
        <td>ushort</td>
    </tr>
    <tr align="center">
        <td>unsigned integer<br>32bit</td>
        <td>u32</td>
        <td>uint</td>
    </tr>
    <tr align="center">
        <td>unsigned integer<br>64bit</td>
        <td>u64</td>
        <td>ulong</td>
    </tr>
    <tr align="center">
        <td>--</td>
        <td>--</td>
        <td>--</td>
    </tr>
    <tr align="center">
        <td>floating point<br>부동 소수점<br>32 bit</td>
        <td>f32<br>(size: 4bytes)</td>
        <td>float<br>(size: 4bytes)</td>
    </tr>
    <tr align="center">
        <td>floating point<br>부동 소수점<br>64 bit</td>
        <td>f64<br>(size: 8bytes)</td>
        <td>double<br>(size: 8bytes)</td>
    </tr>
    <tr align="center">
        <td>--</td>
        <td>--</td>
        <td>--</td>
    </tr>
    <tr align="center">
        <td>Decimal<br>128 bit</td>
        <td>f128</td>
        <td>decimal<br>(size: 16bytes)</td>
    </tr>
</table>

<br>

- C# byte 용량정리 잘됨

https://condor.depaul.edu/sjost/nwdp/notes/cs1/CSDatatypes.htm

<br>

- C# char

https://learn.microsoft.com/ko-kr/dotnet/csharp/language-reference/builtin-types/char

- C# decimal

https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/floating-point-numeric-types


<br>

<hr>

- Rust types

https://dhghomon.github.io/easy_rust/Chapter_7.html

<br>

- 러스트변수용량계산하기_Calculating the variable capacity_Java Hello World_Print#rust

https://youtu.be/ncmbWBs2-WA


<br>

- Rust f32, f64 byte 잘 나옴

https://docs.rs/fsize/latest/fsize/

<br>

<hr>

<br>

#  한글_씨샵&_에프_ #C# & F# 강의_001⭐️Hello World C#_F# LunarVim_Demo_Vim_macOS_M1_pro #csharp #fsharp

https://youtu.be/bhrU4B1-yeg

<br>

<hr>


<br>

# dotnet 활용법 외국의 블로그

https://andrewlock.net/how-to-stop-visual-studio-from-creating-launchsettings-json/
