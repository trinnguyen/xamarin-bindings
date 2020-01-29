using ObjCRuntime;

namespace MTBBarcode
{
	[Native]
	public enum MTBCamera : ulong
	{
		Back,
		Front
	}

	[Native]
	public enum MTBTorchMode : ulong
	{
		ff,
		n
	}
}
