SDK=17.0
SRC_FOLDER=Toast-master
PROJ_NAME=Toast.xcodeproj
NUGET_VERSION=4.0.2

all: clean prepare xcodebuild build pack

prepare:
	curl -L https://github.com/scalessec/Toast/archive/refs/heads/master.zip -o Toast.zip
	unzip Toast.zip && rm Toast.zip

xcodebuild:
	xcodebuild -project $(SRC_FOLDER)/$(PROJ_NAME) build -target Toast -sdk iphonesimulator$(SDK) IPHONEOS_DEPLOYMENT_TARGET=12.0 EXCLUDED_ARCHS="arm64"
	xcodebuild -project $(SRC_FOLDER)/$(PROJ_NAME) build -target Toast -sdk iphoneos$(SDK) IPHONEOS_DEPLOYMENT_TARGET=12.0
	cp -r $(SRC_FOLDER)/build/Release-iphoneos/Toast.framework ./Toast.framework
	rm ./Toast.framework/Toast
	lipo -create $(SRC_FOLDER)/build/Release-iphoneos/Toast.framework/Toast $(SRC_FOLDER)/build/Release-iphonesimulator/Toast.framework/Toast -output ./Toast.framework/Toast
	lipo -info ./Toast.framework/Toast

clean:
	rm -rf ${SRC_FOLDER} bin obj
	
build:
	dotnet build -c Release Xamarin.Toast.csproj
	
pack:
	dotnet pack -c Release Xamarin.Toast.csproj
	
nuget:
	nuget push bin/Release/Xamarin.Toast.${NUGET_VERSION}.nupkg -Source nuget.org