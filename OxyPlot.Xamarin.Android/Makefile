SRC=src-remote
NUGET_VERSION=2.1.2

all: checkout build pack

checkout:
	rm -rf ${SRC}
	git clone https://github.com/oxyplot/oxyplot-xamarin.git ${SRC} --depth 1
	cp -r ${SRC}/Source/OxyPlot.Xamarin.Android/*.cs ./
	rm -rf ${SRC}
build:
	dotnet build -c Release OxyPlot.Xamarin.Android.csproj
pack:
	rm -rf bin obj && dotnet pack -c Release OxyPlot.Xamarin.Android.csproj
nuget:
	nuget push bin/Release/Tnn.OxyPlot.Xamarin.Android.${NUGET_VERSION}.nupkg -Source nuget.org