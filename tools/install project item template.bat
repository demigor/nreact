@echo off
:VS2013
if not exist "%UserProfile%\Documents\Visual Studio 2013\Templates\ItemTemplates\Visual C#" goto VS2015
xcopy /s /i /q /y NReactComponent "%UserProfile%\Documents\Visual Studio 2013\Templates\ItemTemplates\Visual C#\NReactComponent\"
:VS2015
if not exist "%UserProfile%\Documents\Visual Studio 2015\Templates\ItemTemplates\Visual C#" goto END
xcopy /s /i /q /y NReactComponent "%UserProfile%\Documents\Visual Studio 2015\Templates\ItemTemplates\Visual C#\NReactComponent\"
:END
