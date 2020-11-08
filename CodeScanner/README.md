# Xamarin.Android binding for Firebase Crashlytics (Android)
[![NuGet version](https://badge.fury.io/nu/Xamarin.CodeScanner.svg)](https://badge.fury.io/nu/Xamarin.CodeScanner)

## Get started

### Install Nuget package
- https://www.nuget.org/packages/Xamarin.CodeScanner


### Create new Android Activity with CodeScannerView
```xml
<?xml version="1.0" encoding="utf-8"?>
<FrameLayout xmlns:android="http://schemas.android.com/apk/res/android"
    android:layout_height="match_parent"
    android:layout_width="match_parent"
    xmlns:app="http://schemas.android.com/apk/res-auto">

    <com.budiyev.android.codescanner.CodeScannerView
        android:id="@+id/scanner_view"
        android:layout_width="match_parent"
        android:layout_height="match_parent"
        app:autoFocusButtonVisible="false"
        app:flashButtonColor="@android:color/white"
        app:flashButtonVisible="true"
        app:frameColor="@android:color/white"
        app:frameCornersSize="50dp"
        app:frameCornersRadius="0dp"
        app:frameAspectRatioWidth="1"
        app:frameAspectRatioHeight="1"
        app:frameSize="0.75"
        app:frameThickness="2dp"
        app:maskColor="#77000000"/>
    
</FrameLayout>
```

## Sample project
- Checkout sample Xamarin.Android project: [DemoCodeScanner](DemoCodeScanner)

## Credits
- Native Android library: https://github.com/yuriy-budiyev/code-scanner