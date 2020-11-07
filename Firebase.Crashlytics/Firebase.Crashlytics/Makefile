build: clean
	msbuild /t:Rebuild /p:Configuration=Release
	
clean:
	msbuild /t:Clean /p:Configuration=Release

nuget-pack: build
	nuget pack Tnn.Firebase.Crashlytics.nuspec

nuget-push:
	# example usage: VER=17.1.1-alpha make nuget-push
	nuget push Tnn.Firebase.Crashlytics.${VER}.nupkg -Source https://api.nuget.org/v3/index.json