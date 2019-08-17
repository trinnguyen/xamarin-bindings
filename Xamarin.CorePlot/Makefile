DLL_NAME=Xamarin.CorePlot.dll

msbuild:
	msbuild /p:Configuration=Release

nuget:
	nuget pack Xamarin.CorePlot.nuspec

clean:
	rm -rf bin obj *.nupkg
