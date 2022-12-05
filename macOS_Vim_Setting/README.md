# :CocConfig

```

{
//  "workbench.colorCustomizations": {
//    // Name of the theme you are currently using
//    "[Default Dark+]": {
//      "editorInlayHint.foreground": "#868686f0",
//      "editorInlayHint.background": "#f700d6",
//
//      // Overrides for specific kinds of inlay hints
//      "editorInlayHint.typeForeground": "#f700d6",
//      "editorInlayHint.parameterForeground": "#fdb6fdf0",
//    }
  //}
  "workbench.colorCustomizations": {
      "[Default Dark+]": {
          "editorInlayHint.foreground": "#868686f0",
          "editorInlayHint.background": "#f700d6",
      "editorInlayHint.typeForeground": "#f700d6",
      "editorInlayHint.parameterForeground": "#fdb6fdf0",
      }
  },
  "workspace.workspaceFolderFallbackCwd": true",
  "rust-analyzer.semanticHighlighting.operator.specialization.enable": true,
  "rust-analyzer.inlayHints.typeHints.enable": true,
  "rust-analyzer.hover.documentation.enable": true,
  
  // rust-analyzer setting~
  "rust-analyzer.inlayHints.enable": true,
  // "rust-analyzer.cargo.loadOutDirsFromCheck": true,
  "rust-analyzer.procMacro.enable": true,
  "rust-analyzer.lens.enable": true,
  "rust-analyzer.lens.implementations.enable": true,

  // C# Setting~~~ Omnisharp
  "languageserver": {
      "csharp-ls": {
        "command": "csharp-ls",
        "filetypes": ["cs"],
        "rootPatterns": ["*.csproj", ".vim/", ".git/", ".hg/"]
        }
  },
  "omnisharp.trace.server": "information",
  "omnisharp.debug.server": true,

  // Ada Setting
  "ada.serverBin": "ada_language_server", // must be in the path, otherwise use full path to the binary
  "ada.enabled": true,
  "ada.trace.server": "off",
  "ada.projectFile": "", // See below
  "ada.scenarioVariables": {},
  "ada.defaultCharset":  "iso-8859-1",
  "ada.displayMethodAncestryOnNavigation": "usage_and_abstract_only", // never | usage_and_abstract_only | definition_only | always
  "ada.enableDiagnostics": true,
  "ada.renameInComments": false,

  // Haskell Settings
  "languageserver": {
    "haskell": {
      "command": "haskell-language-server-wrapper",
      "args": ["--lsp"],
      "rootPatterns": ["*.cabal", "stack.yaml", "cabal.project", "package.yaml", "hie.yaml"],
      "filetypes": ["haskell", "lhaskell"],
      // Settings are optional, here are some example values
      "settings": {
        "haskell": {
          "checkParents": "CheckOnSave",
          "checkProject": true,
          "maxCompletions": 40,
          "formattingProvider": "ormolu",
          "plugin": {
            "stan": { "globalOn": true }
          }
        }
      }
    }
  }
}

```
