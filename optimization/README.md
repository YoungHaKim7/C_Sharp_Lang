C# 애플리케이션의 빌드 결과물(.exe, .dll) 용량을 킬로바이트(KB) 단위까지 극한으로 줄이기 위해 적용할 수 있는 최적화 방법입니다.
------------------------------
## 1. .NET 7 / 8+ 핵심 최적화 설정 (프로젝트 파일 수정)
프로젝트 파일(.csproj)을 메모장이나 IDE로 열고 <PropertyGroup> 내부에 아래 설정들을 추가합니다. 용량을 줄이는 데 가장 효과적인 방법들입니다.

```xml
<PropertyGroup>
  <!-- 1. 트리밍(Trimming) 활성화: 사용하지 않는 코드를 빌드 시 제거합니다. -->
  <PublishTrimmed>true</PublishTrimmed>
  <TrimMode>link</TrimMode>

  <!-- 2. 단일 파일 빌드: 모든 dll을 exe 하나로 묶어 오버헤드를 줄입니다. -->
  <PublishSingleFile>true</PublishSingleFile>

  <!-- 3. 필요 없는 프레임워크 기능 제거 (사용하지 않을 경우에만 추가) -->
  <MetadataUpdaterSupport>false</MetadataUpdaterSupport>
  <EnableUnsafeBinaryFormatterSerialization>false</EnableUnsafeBinaryFormatterSerialization>
  <HttpActivityPropagationSupport>false</HttpActivityPropagationSupport>
</PropertyGroup>
```

## 2. Native AOT (Ahead-Of-Time) 컴파일 사용
.NET 7부터 지원하는 Native AOT를 사용하면 .NET 런타임(CLR) 없이 기계어로 직접 컴파일되어 릴리즈 용량이 매우 획기적으로 줄어듭니다. 콘솔 앱이나 라이브러리에 특히 강력합니다.

```xml
<PropertyGroup>
  <PublishAot>true</PublishAot>
</PropertyGroup>
```

* 주의: 리플렉션(Reflection)이나 동적 코드를 사용하는 라이브러리는 Native AOT 환경에서 작동하지 않을 수 있으므로 빌드 경고를 확인해야 합니다.

## 3. 디버그 정보(PDB) 및 기호 제거
배포용 파일에 포함되는 디버깅 기호를 제거하여 용량을 줄입니다.

```xml
<PropertyGroup Condition="'$(Configuration)' == 'Release'">
  <DebugType>none</DebugType>
  <DebugSymbols>false</DebugSymbols>
</PropertyGroup>
```

## 4. CLI 게시(Publish) 명령어 활용
터미널에서 빌드할 때 아래와 같이 독립형(Self-contained)이 아닌 프레임워크 종속형(Framework-dependent)으로 배포하면 런타임이 제외되어 파일 크기가 KB 단위로 작아집니다. target 시스템에 .NET이 설치되어 있어야 합니다.

```bash
dotnet publish -c Release -r win-x64 --self-contained false
```

만약 독립형(Self-contained)으로 실행 파일 하나만 깔끔하게 전달해야 한다면, 위의 1번(트리밍) 설정을 켠 채로 아래 명령어를 사용합니다.

```bash
dotnet publish -c Release -r win-x64 --self-contained true
```

------------------------------
추가적으로 프로젝트 내에 포함된 이미지, XML, JSON 등의 임베디드 리소스(Embedded Resources)가 있다면 크기를 압축하거나 빌드 출력에서 제외하는 것도 큰 도움이 됩니다.
진행 중이신 프로젝트의 .NET 버전이나 앱 종류(Windows Forms, WPF, 콘솔 등)를 알려주시면 해당 환경에 맞는 더 구체적인 최적화 코드를 안내해 드릴 수 있습니다. 어떻게 진행해 볼까요?

