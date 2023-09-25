# Toast for Xamarin.iOS
[![NuGet version](https://badge.fury.io/nu/Xamarin.Toast.svg)](https://badge.fury.io/nu/Xamarin.Toast)

**Net 7.0 for iOS is supported (Xcode 15, iOS 17)**

Xamarin.iOS Binding Library for [Toast](https://github.com/scalessec/Toast)

**Native Objective-C library: https://github.com/scalessec/Toast**
## Screenshots
![Toast Screenshots](https://github.com/scalessec/Toast/blob/master/toast_screenshots.jpg)

## Sample
```csharp
using Xamarin.Toast;
```

```csharp
// basic usage
View.MakeToast("This is a piece of toast.");

// toast with a specific duration and position
View.MakeToast("This is a piece of toast with a specific duration and position", 
                    3f,
                    ToastConstants.CSToastPositionTop);
// toast with all possible options
View.MakeToast("This is a piece of toast with a title & image",
                    3f,
                    NSValue.FromCGPoint(new CGPoint(110, 110)),
                    "Toast Title",
                    UIImage.FromBundle("toast.png"),
                    null,
                    (bool didTap) => System.Diagnostics.Debug.WriteLine($"Did tap: {didTap}"));

// display toast with an activity spinner
View.MakeToastActivity(ToastConstants.CSToastPositionCenter);

// display any view as toast
View.ShowToast(customView);
```

## Nuget
https://www.nuget.org/packages/Xamarin.Toast

`dotnet add package Xamarin.Toast`
