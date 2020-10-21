VERSION=2.0.3

default: build

download-aar:
	curl -o Jars/android-maps-utils.aar -L https://repo1.maven.org/maven2/com/google/maps/android/android-maps-utils/${VERSION}/android-maps-utils-${VERSION}.aar

build: download-aar
	msbuild /t:Rebuild /p:Configuration=Release

clean:
	msbuild /t:Clean

nuget-pack:
	nuget pack Xamarin.Android.Maps.Utils.nuspec

nuget-push:
	nuget push -Source https://api.nuget.org/v3/index.json
