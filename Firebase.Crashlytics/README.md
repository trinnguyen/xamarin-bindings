# Xamarin.Android binding for Firebase Crashlytics (Android)
[![NuGet version](https://badge.fury.io/nu/Tnn.Firebase.Crashlytics.svg)](https://badge.fury.io/nu/Tnn.Firebase.Crashlytics)

- Use Google Tink Crypto library for encrypting/decrypting key and value
- Keyset is generated at runtime if not exist, stored in iOS Keychain

## Install Nuget package
- https://www.nuget.org/packages/Tnn.Firebase.Crashlytics

## Get started
- Step 1: Add nuget package to your project
    - `<PackageReference Include="Tnn.Firebase.Crashlytics" Version="17.1.1" />`
- Step 2: Download `google-services.json` file of the Android app from Firebase Console and add to the project, set Build Action to `GoogleServicesJson`
- Step 4: Open Firebase Console -> Crashlytics -> Enable Crashlytics
- Step 3: Run the app and force a crash and reopen the app
    + Open main activity class (for example: `MainActivity.cs`), add invalid code in `OnCreate` function, for example:
    + `var tmp = ((Fragment)null).GetType();`
- Step 4: Open Firebase Console -> Crashlytics, the crash report should already arrive
    
## Advanced
### Add custom keys
```csharp
Firebase.Crashlytics.FirebaseCrashlytics.Instance.SetCustomKey("key1", "value2");
```

### SetUserId
```csharp
Firebase.Crashlytics.FirebaseCrashlytics.Instance.SetUserId("custom-user-id");
```

### Log
```csharp
Firebase.Crashlytics.FirebaseCrashlytics.Instance.Log($"sample log");
```

### Record exception (Non-fatal report)
```csharp
Firebase.Crashlytics.FirebaseCrashlytics.Instance.RecordException(new Java.Lang.Exception($"sample exception"));
```
