# 24hr) Create a C# Application from Start to Finish - Complete Course 

https://youtu.be/wfWxdh-_k_4

<br>

<hr>

# Complete Beginner Courses | C# Tutorial for Beginners | Learn the Basics of C# programming ๐ฅ๏ธ Csharp Tutorial for Beginners | tutorialsEU

https://youtu.be/UKaZ2S4AJAA

<br>

# Complete Beginner Courses

https://youtube.com/playlist?list=PLwhVruPHD9rxZ9U5K6vqUFkfrjaRhwEsV

<br>

<hr>

#  dotnet ๊ธฐ์ด ์์

์ฒซ ๋ฒ์งธ ์ฑ ์์ฑ: 

https://aka.ms/dotnet-hello-world

<br>

์๋ก์ด ๊ธฐ๋ฅ ํ์ธ: 

https://aka.ms/dotnet-whats-new

<br>

์ค๋ช์ ์ดํด๋ณด๊ธฐ: 

https://aka.ms/dotnet-docs

<br>

GitHub์์ ๋ฌธ์  ๋ณด๊ณ  ๋ฐ ์์ค ์ฐพ๊ธฐ: 

https://github.com/dotnet/core

<br>

<br>

์ฌ์ฉ ๊ฐ๋ฅํ ๋ช๋ น์ ๋ณด๋ ค๋ฉด 'dotnet --help'๋ฅผ ์ฌ์ฉํ๊ฑฐ๋ 

https://aka.ms/dotnet-cli

๋ฅผ ๋ฐฉ๋ฌธํ์ธ์.

- dotnet sln

https://learn.microsoft.com/en-us/dotnet/core/tools/dotnet-sln

<br>

# Microsoft. NET SDK 7.0.100 Choco install

```
> choco install dotnet-sdk

```

<br>

# Get started vscos c# net Core Windows OS

- 1๋ก ์ค์นํ๋ฉด๋จ

https://learn.microsoft.com/ko-kr/dotnet/core/install/windows?tabs=net70

<br>

- ์ค์น ์ค๋ช์ 

https://learn.microsoft.com/en-us/shows/dotnet/get-started-vscode-csharp-net-core-windows

<br>

<hr>



# C# ํค์๋ - C_Sharp_Referece_Documentation

https://learn.microsoft.com/ko-kr/dotnet/csharp/language-reference/keywords/

- C# Language Referece

https://learn.microsoft.com/ko-kr/dotnet/csharp/language-reference/

- C# documentation

https://learn.microsoft.com/en-us/dotnet/csharp/

<br>

# Visual Studio for Mac IDE tour

https://learn.microsoft.com/en-us/visualstudio/mac/ide-tour?view=vsmac-2022

<br>

# C# ๊ธฐ๋ณธ ํ

- C_Sharp_Lang/exercise/A003_Searching_strings/

```
// console ๋ง๋ค๊ธฐ 
dotnet new console --language C#

// ์คํํ๊ธฐ 
dotnet run
```

```

tree
.
โโโ A003_Searching_strings.csproj
โโโ Program.cs
โโโ delete.sh


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

[C#] string format, ๋ฌธ์์ด ๋ณด๊ฐ($)์ ์ด์ฉํ ๋ฌธ์์ด ์ถ๋ ฅ๋ฐฉ๋ฒ

<br>

- C# for Beginners


https://youtube.com/playlist?list=PLdo4fOcmZ0oVxKLQCHpiUWun7vlJJvUiN

<br>

<hr>

# csc.exe ์ปดํ์ผ ํ๊ธฐ (WindowsOS ๊ธฐ์ค)

- C:\Windows\Microsoft.NET\Framework\v4.0.30319\csc.exe hello.cs

- \MicrosoftVisualStudio\MSBuild\Current\Bin\Roslyn



```
PS D:\Young_Project\C_Sharp_Lang\C_Sharp_Lang\Hello_C_sharp2> csc .\Hello1.cs
Microsoft (R) Visual C# ์ปดํ์ผ๋ฌ ๋ฒ์  3.11.0-4.22108.8 (d9bef045)
Copyright (C) Microsoft Corporation. All rights reserved.

PS Hello_C_sharp2> ls

    Directory: D:\Hello_C_sharp2

Mode                 LastWriteTime         Length Name
----                 -------------         ------ ----
-a---        2022-12-05  ์คํ 6:50            105 Hello1.cs
-a---        2022-12-05  ์คํ 6:50           3584 Hello1.exe
-a---        2022-12-05  ์คํ 6:50             48 Hello2.cs
-a---        2022-12-05  ์คํ 6:50            178 README.md

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
โ This project is lacking proper maintanence. I would recommend csharp-ls at this moment.
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

# Github๋ ์ ๊ธฐ๋ณธ gitignore ํ์ผ์ C#์ ์ง์ํด์ฃผ์ง ์์๊น์?

https://forum.dotnetdev.kr/t/github-gitignore-c/487/2

<br>

- ๋จ์ 2

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

cargo init ๊ณผ ๋น์ทํจ ํด๋ ๋ง๋ค๊ณ  ๊ทธ ์์์ ์น๋ฉด ๋จ.


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
// ์ฝ์ ํ๋ก์ ํธ ๋ง๋ค๊ธฐ
dotnet new console



// ์๋ก ๋ง๋ค ์ ์๋ list๋ฅผ ๋ณผ ์ ์๋ค
dotnet new --list

```


```
// ์ง์ ๋ ๋๋ ํฐ๋ฆฌ์์ ํ๋ก์ ํธ ๋ฐ ํด๋น ์ข์์ฑ์ ๋น๋ํฉ๋๋ค.
// .NET CLI


dotnet build
```

https://docs.microsoft.com/ko-kr/dotnet/core/tools/dotnet-run


https://docs.microsoft.com/ko-kr/dotnet/core/get-started



```
// ์ ํ๋ฆฌ์ผ์ด์์ ์คํ ํ๋ค dll์คํ ๋จ ๋๋ฐ ใ

dotnet myapp.dll
```

https://docs.microsoft.com/ko-kr/dotnet/core/tools/dotnet





<br>


# dotnet๋ช๋ น์ด ๊น์ด ํ๊ณ  ๋ค์ด๊ฐ๊ธฐ

```
// dotnet ๋ช๋ น
// ์ผ๋ฐ

// ๋ช๋ น	ํจ์
dotnet build	.NET ์ ํ๋ฆฌ์ผ์ด์์ ๋น๋ํฉ๋๋ค.
dotnet build-server	๋น๋์์ ์์๋ ์๋ฒ์ ์ํธ ์์ฉํฉ๋๋ค.
dotnet clean	๋น๋ ์ถ๋ ฅ์ ์ ๋ฆฌํฉ๋๋ค.
dotnet help	๋ช๋ น์ ๋ํ ์์ธํ ์จ๋ผ์ธ ์ค๋ช์๋ฅผ ํ์ํฉ๋๋ค.
dotnet migrate	์ ํจํ Preview 2 ํ๋ก์ ํธ๋ฅผ .NET Core SDK 1.0 ํ๋ก์ ํธ๋ก ๋ง์ด๊ทธ๋ ์ด์ํฉ๋๋ค.
dotnet msbuild	MSBuild ๋ช๋ น์ค์ ๋ํ ์ก์ธ์ค ๊ถํ์ ์ ๊ณตํฉ๋๋ค.
dotnet new	์ง์ ํ ํํ๋ฆฟ์ ๋ํด C# ๋๋ F# ํ๋ก์ ํธ๋ฅผ ์ด๊ธฐํํฉ๋๋ค.
dotnet pack	์ฝ๋์ NuGet ํจํค์ง๋ฅผ ๋ง๋ญ๋๋ค.
dotnet publish	.NET Framework ์ข์ํ ๋๋ ์์ฒด ํฌํจ ์ ํ๋ฆฌ์ผ์ด์์ ๊ฒ์ํฉ๋๋ค.
dotnet restore	์ง์ ๋ ์ ํ๋ฆฌ์ผ์ด์์ ๋ํ ์ข์์ฑ์ ๋ณต์ํฉ๋๋ค.
dotnet run	์์ค์์ ์ ํ๋ฆฌ์ผ์ด์์ ์คํํฉ๋๋ค.
dotnet sdk check	์ค์น๋ SDK ๋ฐ ๋ฐํ์ ๋ฒ์ ์ ์ต์  ์ํ๋ฅผ ํ์ํฉ๋๋ค.
dotnet sln	์๋ฃจ์ ํ์ผ์ ํ๋ก์ ํธ๋ฅผ ์ถ๊ฐ, ์ ๊ฑฐ ๋ฐ ๋์ดํ๋ ์ต์์๋๋ค.
dotnet store	์ด์๋ธ๋ฆฌ๋ฅผ ๋ฐํ์ ํจํค์ง ์ ์ฅ์์ ์ ์ฅํฉ๋๋ค.
dotnet test	Test Runner๋ฅผ ์ฌ์ฉํ์ฌ ํ์คํธ๋ฅผ ์คํํฉ๋๋ค.

```


- ํ๋ก์ ํธ ์ฐธ์กฐ

```
// ํ๋ก์ ํธ ์ฐธ์กฐ

// ๋ช๋ น	ํจ์
dotnet add reference	ํ๋ก์ ํธ ์ฐธ์กฐ๋ฅผ ์ถ๊ฐํฉ๋๋ค.
dotnet list reference	ํ๋ก์ ํธ ์ฐธ์กฐ๋ฅผ ๋์ดํฉ๋๋ค.
dotnet remove reference	ํ๋ก์ ํธ ์ฐธ์กฐ๋ฅผ ์ ๊ฑฐํฉ๋๋ค
```


- NuGet ํจํค์ง

```
// NuGet ํจํค์ง

// ๋ช๋ น	ํจ์
dotnet add package	NuGet ํจํค์ง๋ฅผ ์ถ๊ฐํฉ๋๋ค.
dotnet remove package	NuGet ํจํค์ง๋ฅผ ์ ๊ฑฐํฉ๋๋ค
```





- NuGet ๋ช๋ น

```
// NuGet ๋ช๋ น

// ๋ช๋ น	ํจ์
dotnet nuget delete	์๋ฒ์์ ํจํค์ง๋ฅผ ์ญ์ ํ๊ฑฐ๋ ๋ชฉ๋ก์์ ์ ๊ฑฐํฉ๋๋ค.
dotnet nuget push	์๋ฒ์ ํจํค์ง๋ฅผ ํธ์ํ๊ณ  ๊ฒ์ํฉ๋๋ค.
dotnet nuget locals	http-request ์บ์, ์์ ์บ์ ๋๋ ์์คํ ์ ์ฒด์ ๊ธ๋ก๋ฒ ํจํค์ง ํด๋์ ๊ฐ์ ๋ก์ปฌ NuGet ๋ฆฌ์์ค๋ฅผ ์ง์ฐ๊ฑฐ๋ ๋ชฉ๋ก์ ํฌํจํฉ๋๋ค.
dotnet nuget add source	NuGet ์์ค๋ฅผ ์ถ๊ฐํฉ๋๋ค.
dotnet nuget disable source	NuGet ์์ค๋ฅผ ์ฌ์ฉํ์ง ์๋๋ก ์ค์ ํฉ๋๋ค.
dotnet nuget enable source	NuGet ์์ค๋ฅผ ์ฌ์ฉํ๋๋ก ์ค์ ํฉ๋๋ค.
dotnet nuget list source	๊ตฌ์ฑ๋ NuGet ์์ค๋ฅผ ๋ชจ๋ ๋์ดํฉ๋๋ค.
dotnet nuget remove source	NuGet ์์ค๋ฅผ ์ ๊ฑฐํฉ๋๋ค.
dotnet nuget update source	NuGet ์์ค๋ฅผ ์๋ฐ์ดํธํฉ๋๋ค
```

- en-us
https://learn.microsoft.com/en-us/dotnet/core/tools/dotnet

/ ์ํฌ๋ก๋ ๋ช๋ น

```
/ ์ํฌ๋ก๋ ๋ช๋ น

// ๋ช๋ น	๊ธฐ๋ฅ

dotnet workload install	์ ํ์  ์ํฌ๋ก๋๋ฅผ ์ค์นํฉ๋๋ค.
dotnet workload list	์ค์น๋ ๋ชจ๋  ์ํฌ๋ก๋๋ฅผ ๋์ดํฉ๋๋ค.
dotnet workload repair	์ค์น๋ ๋ชจ๋  ์ํฌ๋ก๋๋ฅผ ๋ณต๊ตฌํฉ๋๋ค.
dotnet workload search	์ ํํ ์ํฌ๋ก๋ ๋๋ ์ฌ์ฉ ๊ฐ๋ฅํ ๋ชจ๋  ์ํฌ๋ก๋๋ฅผ ๋์ดํฉ๋๋ค.
dotnet workload uninstall	์ํฌ๋ก๋๋ฅผ ์ ๊ฑฐํฉ๋๋ค.
dotnet workload update	์ค์น๋ ๋ชจ๋  ์ํฌ๋ก๋๋ฅผ ๋ค์ ์ค์นํฉ๋๋ค.

```


- en-us

https://learn.microsoft.com/en-us/dotnet/core/tools/dotnet

-	์ปดํจํฐ์ ๋๊ตฌ๋ฅผ ์ค์นํฉ๋๋ค.

```
//	์ปดํจํฐ์ ๋๊ตฌ๋ฅผ ์ค์นํฉ๋๋ค.

dotnet tool install




dotnet tool list	์ปดํจํฐ์ ํ์ฌ ์ค์น๋์ด ์๋ ๋ชจ๋  ์ ์ญ, ๋๊ตฌ ๊ฒฝ๋ก ๋๋ ๋ก์ปฌ ๋๊ตฌ๋ฅผ ๋์ดํฉ๋๋ค.
dotnet tool search	NuGet.org์์ ์ง์ ๋ ๊ฒ์ ์ฉ์ด๊ฐ ์ด๋ฆ ๋๋ ๋ฉํ๋ฐ์ดํฐ์ ํฌํจ๋ ๋๊ตฌ๋ฅผ ๊ฒ์ํฉ๋๋ค.
dotnet tool uninstall	์ปดํจํฐ์์ ๋๊ตฌ๋ฅผ ์ ๊ฑฐํฉ๋๋ค.
dotnet tool update	์ปดํจํฐ์ ์ค์น๋ ๋๊ตฌ๋ฅผ ์๋ฐ์ดํธํฉ๋๋ค


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

- ์์ด ์ถ์ฒ
https://learn.microsoft.com/en-us/dotnet/api/system.type.isprimitive?view=net-7.0

<br>

 8bit = 1 bytes

<br>

<table border="1">
    <tr>
    <td colspan="3" align="center">Rust vs C#</td>
    </tr>
    <tr align="center">
        <td>๋ถ๋ฅ(Type) </td>
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
        <td>floating point<br>๋ถ๋ ์์์ <br>32 bit</td>
        <td>f32<br>(size: 4bytes)</td>
        <td>float<br>(size: 4bytes)</td>
    </tr>
    <tr align="center">
        <td>floating point<br>๋ถ๋ ์์์ <br>64 bit</td>
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

- C# byte ์ฉ๋์ ๋ฆฌ ์๋จ

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

- ๋ฌ์คํธ๋ณ์์ฉ๋๊ณ์ฐํ๊ธฐ_Calculating the variable capacity_Java Hello World_Print#rust

https://youtu.be/ncmbWBs2-WA


<br>

- Rust f32, f64 byte ์ ๋์ด

https://docs.rs/fsize/latest/fsize/

<br>

<hr>

<br>

#  ํ๊ธ_์จ์ต&_์ํ_ #C# & F# ๊ฐ์_001โญ๏ธHello World C#_F# LunarVim_Demo_Vim_macOS_M1_pro #csharp #fsharp

https://youtu.be/bhrU4B1-yeg

<br>

<hr>
