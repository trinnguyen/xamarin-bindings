SPDir = sharpiepod
FrameworkBuildPath = build/Toast.framework
DllPath = Xamarin.Toast/bin/Release/Xamarin.Toast.dll

sharpie:
	mkdir -p $(SPDir)
	cd $(SPDir) && sharpie pod init ios Toast
	cd $(SPDir) && sharpie pod bind
xcodebuild:
	cd $(SPDir)/Pods && xcodebuild -sdk iphonesimulator && xcodebuild -sdk iphoneos
fatlib:
	cd $(SPDir) && cp -R build/Release-iphoneos/Toast/Toast.framework $(FrameworkBuildPath)
	cd $(SPDir) && lipo -create build/Release-iphoneos/Toast/Toast.framework/Toast build/Release-iphonesimulator/Toast/Toast.framework/Toast -output $(FrameworkBuildPath)/Toast
copy-framework:
	rm -r Xamarin.Toast/Toast.framework
	cp -R $(SPDir)/$(FrameworkBuildPath) Xamarin.Toast/Toast.framework
prepare:
	sharpie xcodebuild fatlib copy-framework
build:
	msbuild /p:Configuration=Release /t:Xamarin_Toast
clean:
	rm -rf $(SPDir)
build-all:
	prepare build-all
nuget-pack:
	nuget pack Xamarin.Toast.nuspec