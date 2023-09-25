SRC=src-remote
NUGET_VERSION=2.1.2
checkout:
	rm -rf ${SRC}
	git clone https://github.com/oxyplot/oxyplot-xamarin.git ${SRC} --depth 1
	cp -r ${SRC}/Source/OxyPlot.Xamarin.iOS/*.cs ./
	rm -rf ${SRC}
build:
	dotnet build -c Release OxyPlot.Xamarin.iOS.csproj
pack:
	rm -rf bin obj && dotnet pack -c Release OxyPlot.Xamarin.iOS.csproj
nuget:
	nuget push bin/Release/Tnn.OxyPlot.Xamarin.iOS.${NUGET_VERSION}.nupkg -Source nuget.org