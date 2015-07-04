@echo off
rem VS2013
if not exist "C:\Program Files (x86)\Visual Studio 12.0\Common7\IDE\ItemTemplates\CSharp\Silverlight" goto VS2013WPF
xcopy /s /i /q /y NReactComponent.zip "C:\Program Files (x86)\Visual Studio 12.0\Common7\IDE\ItemTemplates\CSharp\Silverlight"
:VS2013WPF
if not exist "C:\Program Files (x86)\Visual Studio 12.0\Common7\IDE\ItemTemplates\CSharp\WPF" goto VS2013XAML
xcopy /s /i /q /y NReactComponent.zip "C:\Program Files (x86)\Visual Studio 12.0\Common7\IDE\ItemTemplates\CSharp\WPF"
:VS2013XAML
if not exist "C:\Program Files (x86)\Visual Studio 12.0\Common7\IDE\ItemTemplates\CSharp\XAML" goto VS2013STORE
xcopy /s /i /q /y NReactComponent.zip "C:\Program Files (x86)\Visual Studio 12.0\Common7\IDE\ItemTemplates\CSharp\XAML"
:VS2013STORE
if not exist "C:\Program Files (x86)\Visual Studio 12.0\Common7\IDE\ItemTemplates\CSharp\Windows Store" goto VS2013PHONE
xcopy /s /i /q /y NReactComponent.zip "C:\Program Files (x86)\Visual Studio 12.0\Common7\IDE\ItemTemplates\CSharp\Windows Store"
:VS2013PHONE
if not exist "C:\Program Files (x86)\Visual Studio 12.0\Common7\IDE\ItemTemplates\CSharp\Windows Phone" goto VS2015
xcopy /s /i /q /y NReactComponent.zip "C:\Program Files (x86)\Visual Studio 12.0\Common7\IDE\ItemTemplates\CSharp\Windows Phone"



:VS2015
rem todo
:END
echo Templates installed.
