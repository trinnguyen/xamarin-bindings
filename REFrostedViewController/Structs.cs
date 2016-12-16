using System;
using System.Runtime.InteropServices;
using ObjCRuntime;

namespace Xamarin.REFrostedViewController
{
	static class CFunctions
	{
		// extern BOOL REFrostedViewControllerUIKitIsFlatMode ();
		[DllImport ("__Internal")]
		//[Verify (PlatformInvoke)]
		static extern bool REFrostedViewControllerUIKitIsFlatMode ();
	}

	[Native]
	public enum REFrostedViewControllerDirection : long
	{
		Left,
		Right,
		Top,
		Bottom
	}

	[Native]
	public enum REFrostedViewControllerLiveBackgroundStyle : long
	{
		Light,
		Dark
	}
}
