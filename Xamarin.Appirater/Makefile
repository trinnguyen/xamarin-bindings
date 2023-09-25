NUGET_VERSION=2.3.1.1
build:
	dotnet build -c Release Xamarin.Appirater.csproj
	
pack:
	dotnet pack -c Release Xamarin.Appirater.csproj

nuget:
	nuget push bin/Release/Xamarin.Appirater.${NUGET_VERSION}.nupkg -Source nuget.org