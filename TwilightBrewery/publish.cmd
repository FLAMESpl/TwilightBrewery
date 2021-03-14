@echo off
pushd %~dp0
rmdir publish /S /Q
dotnet publish ./src/TwilightBrewery/TwilightBrewery.csproj -p:PublishProfile=Desktop -o publish
popd
pause