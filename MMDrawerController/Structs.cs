using System;
using ObjCRuntime;

namespace Xamarin.MMDrawerController
{
	[Native]
	public enum MMDrawerSide : long
	{
		None = 0,
		Left,
		Right
	}

	[Native]
	public enum MMOpenDrawerGestureMode : long
	{
		None = 0,
		PanningNavigationBar = 1 << 1,
		PanningCenterView = 1 << 2,
		BezelPanningCenterView = 1 << 3,
		Custom = 1 << 4,
		All = PanningNavigationBar | PanningCenterView | BezelPanningCenterView | Custom
	}

	[Native]
	public enum MMCloseDrawerGestureMode : long
	{
		None = 0,
		PanningNavigationBar = 1 << 1,
		PanningCenterView = 1 << 2,
		BezelPanningCenterView = 1 << 3,
		TapNavigationBar = 1 << 4,
		TapCenterView = 1 << 5,
		PanningDrawerView = 1 << 6,
		Custom = 1 << 7,
		All = PanningNavigationBar | PanningCenterView | BezelPanningCenterView | TapNavigationBar | TapCenterView | PanningDrawerView | Custom
	}

	[Native]
	public enum MMDrawerOpenCenterInteractionMode : long
	{
		None,
		Full,
		NavigationBarOnly
	}
}
