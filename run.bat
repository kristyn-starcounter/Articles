@ECHO OFF

IF "%CONFIGURATION%"=="" SET CONFIGURATION=Debug

star %* --resourcedir="%~dp0src\Articles\wwwroot" "%~dp0src/Articles/bin/%CONFIGURATION%/Articles.exe"