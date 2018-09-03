echo off
@echo Building with MsBuild
@cd /d "%~dp0"
IF Exist "%programfiles(x86)%\MSBuild\14.0" (
	set MSBUILDVER=14.0
) else (
	set MSBUILDVER=12.0
)

echo Running: "%programfiles(x86)%\MSBuild\%MSBUILDVER%\bin\msbuild.exe"
"%programfiles(x86)%\MSBuild\%MSBUILDVER%\bin\msbuild.exe" build.proj

pause
net stop "Service Host Manager Watcher"
net stop "Service Host Manager"
copy ..\..\output\modules\Decisions.AzureServices.zip "c:\Program Files\Decisions\Decisions Services Manager\modules" /Y
net start "Service Host Manager"
pause
