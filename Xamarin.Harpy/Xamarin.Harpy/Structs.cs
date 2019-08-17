using System;
using ObjCRuntime;
namespace Xamarin.Harpy
{
    [Native]
    public enum HarpyAlertType : ulong
    {
        Force = 1,
        Option,
        Skip,
        None
    }   
}
