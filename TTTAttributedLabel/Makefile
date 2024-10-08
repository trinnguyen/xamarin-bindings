NUGET_VERSION=1.0.0

all: clean prepare xcodeframework xcodecreate build clean

prepare:
	curl -L https://github.com/TTTAttributedLabel/TTTAttributedLabel/archive/refs/heads/master.zip | tar xz
	mv TTTAttributedLabel-master src

xcodeframework:
	xcodebuild build -scheme TTTAttributedLabel -destination "generic/platform=iOS" -configuration Release -derivedDataPath build
	xcodebuild build -scheme TTTAttributedLabel -destination "generic/platform=iOS Simulator" -configuration Release -derivedDataPath build

xcodecreate:
	rm -rf TTTAttributedLabel.xcframework
	xcodebuild -create-xcframework -framework build/Build/Products/Release-iphonesimulator/TTTAttributedLabel.framework -framework build/Build/Products/Release-iphoneos/TTTAttributedLabel.framework -output ./TTTAttributedLabel.xcframework
	
build:
	dotnet build -c Release
	dotnet pack -c Release
	ls bin/Release

nuget:
	nuget push bin/Release/Xamarin.TTTAttributedLabel.${NUGET_VERSION}.nupkg -Source nuget.org

clean:
	rm -rf src
	rm -rf bin
	rm -rf build
	rm -rf obj