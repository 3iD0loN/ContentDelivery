if $%1$==$release$ (SET CONFIG=Release) else if $%1$==$debug$ (SET CONFIG=Debug)

msbuild LowLevelNativePluginWindows.sln /p:configuration=%CONFIG% /p:platform=x86

msbuild LowLevelNativePluginWindows.sln /p:configuration=%CONFIG% /p:platform=x64

msbuild LowLevelNativePluginWindows.sln /p:configuration=%CONFIG% /p:platform=ARM