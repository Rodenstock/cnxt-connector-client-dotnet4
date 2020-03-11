:: Generated by: https://github.com/openapitools/openapi-generator.git
::

@echo off

SET CSCPATH=%SYSTEMROOT%\Microsoft.NET\Framework\v3.5

if not exist ".\nuget.exe" powershell -Command "(new-object System.Net.WebClient).DownloadFile('https://dist.nuget.org/win-x86-commandline/latest/nuget.exe', '.\nuget.exe')"
.\nuget.exe install src\CNXT.Connector.Client\packages.config -o packages

if not exist ".\bin" mkdir bin

copy packages\Newtonsoft.Json.12.0.1\lib\net40\Newtonsoft.Json.dll bin\Newtonsoft.Json.dll
copy packages\JsonSubTypes.1.5.2\lib\net40\JsonSubTypes.dll bin\JsonSubTypes.dll
copy packages\RestSharp.105.1.0\lib\net4\RestSharp.dll bin\RestSharp.dll
%CSCPATH%\csc  /reference:bin\Newtonsoft.Json.dll;bin\JsonSubTypes.dll;bin\RestSharp.dll;System.ComponentModel.DataAnnotations.dll  /target:library /out:bin\CNXT.Connector.Client.dll /recurse:src\CNXT.Connector.Client\*.cs /doc:bin\CNXT.Connector.Client.xml

