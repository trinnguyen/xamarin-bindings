default: download build

download:
	# Download Tink.framework file directly from Google server
	# URL from podspec: https://github.com/CocoaPods/Specs/blob/master/Specs/3/8/5/Tink/1.4.0/Tink.podspec.json
	curl -L "https://dl.google.com/dl/cpdc/a970145c8a245dc6/Tink-1.4.0.tar.gz" -o Tink.tar.gz
	mkdir Tink-dist && tar -xzvf Tink.tar.gz -C Tink-dist
	rm Tink.tar.gz

build:
	msbuild /t:Rebuild /p:Configuration=Release

clean:
	msbuild /t:Clean
	rm -rf Tink-dist

nuget-pack:
	nuget pack

nuget-push:
	nuget push
