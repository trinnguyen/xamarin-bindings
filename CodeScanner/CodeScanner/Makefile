build: clean
	msbuild /t:Rebuild /p:Configuration=Release
	
clean:
	msbuild /t:Clean /p:Configuration=Release

nuget-pack: build
	nuget pack Xamarin.CodeScanner.nuspec

nuget-push:
	# example usage: VER=2.1.0 make nuget-push
	nuget push Xamarin.CodeScanner.${VER}.nupkg -Source https://api.nuget.org/v3/index.json