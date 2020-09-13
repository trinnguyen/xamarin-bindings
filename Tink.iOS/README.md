# Google Tink Crypto Library for Xamarin.iOS
[![NuGet version](https://badge.fury.io/nu/Tink.iOS.svg)](https://badge.fury.io/nu/Tink.iOS)

Xamarin.iOS Binding Library for [Tink](https://github.com/google/tink)

## Build

- `make download`
- `make build`

## Usage
- https://github.com/google/tink/blob/master/docs/OBJC-HOWTO.md

### Initializing
```csharp
var config = new TINKAeadConfig(out NSError error);
if (error != null)
{
    Console.WriteLine("Error: " + error);
    return;
}

TINKConfig.RegisterConfig(config, out error);
if (error != null)
{
    Console.WriteLine("Error: " + error);
    return;
}
```

### Create, save and load key (with iOS Keychain)
```csharp
// gen key
NSError error;
var tpl = new TINKAeadKeyTemplate(TINKAeadKeyTemplates.Aes256Gcm, out error);
if (error != null)
{
    Console.WriteLine("Error: " + error);
    return;
}
var handle = new TINKKeysetHandle(tpl, out error);
if (error != null)
{
    Console.WriteLine("Error: " + error);
    return;
}

// store
var keysetName = "co.tnn.tink.demo_key";
if (!handle.WriteToKeychainWithName(keysetName, true, out error))
{
    Console.WriteLine("Error: " + error);
    return;
}

// load
TINKKeysetHandle handleStore = new TINKKeysetHandle(keysetName, out error);
if (error != null)
{
    Console.WriteLine("Error: " + error);
    return;
}
```

### Encrypt/Decrypt with AEAD
```csharp
// AEAD
ITINKAead aead = TINKAeadFactory.PrimitiveWithKeysetHandle(handleStore, out error);
if (error != null)
{
    Console.WriteLine("Error: " + error);
    return;
}

// encrypt
NSData cipher = aead.Encrypt(NSData.FromString("hello world", NSStringEncoding.UTF8), NSData.FromString("k_value", NSStringEncoding.UTF8), out error);
if (error != null)
{
    Console.WriteLine("Error: " + error);
    return;
}

Console.WriteLine(cipher.GetBase64EncodedString(NSDataBase64EncodingOptions.None));

// decrypt
var plain = aead.Decrypt(cipher, NSData.FromString("k_value", NSStringEncoding.UTF8), out error);
if (error != null)
{
    Console.WriteLine("Error: " + error);
    return;
}
Console.WriteLine(plain.ToString(NSStringEncoding.UTF8));
```
### Encrypt/Decrypt with Deterministically
```csharp
// aead deter
var tpl = new TINKDeterministicAeadKeyTemplate(TINKDeterministicAeadKeyTemplates.TINKAes256Siv, out NSError error);
var handle = new TINKKeysetHandle(tpl, out error);
ITINKDeterministicAead aeadDeter = TINKDeterministicAeadFactory.PrimitiveWithKeysetHandle(handle, out error);
if (error != null)
{
    Console.WriteLine("Error: " + error.LocalizedFailureReason);
    return;
}

// encrypt
string associatedData = "name_default";
NSData cipher = aeadDeter.EncryptDeterministically(NSData.FromString(item, NSStringEncoding.UTF8), NSData.FromString(associatedData, NSStringEncoding.UTF8), out error);
if (error != null)
{
    Console.WriteLine(error.LocalizedFailureReason);
    return;
}

Console.WriteLine(cipher.GetBase64EncodedString(NSDataBase64EncodingOptions.None));

// decrypt
NSData unencryped = aeadDeter.DecryptDeterministically(cipher, NSData.FromString(associatedData, NSStringEncoding.UTF8), out error);
if (error != null)
{
    Console.WriteLine(error.LocalizedFailureReason);
    return;
}
Console.WriteLine(unencryped.ToString(NSStringEncoding.UTF8));
```

### Known issue

- Load from iOS keychain throw Exception if the keyset is not yet exist
- Reason: Xamarin.iOS binding can not create new NULL instance
- Solution: use try-catch
```csharp
private static TINKKeysetHandle LoadFromKeychain(string keysetName)
{
    try
    {
        TINKKeysetHandle handleStore = new TINKKeysetHandle(keysetName, out NSError error);
        if (error != null)
        {
            Debug.WriteLine(error.LocalizedFailureReason);
            return null;
        }

        return handleStore;

    }
    catch (Exception ex)
    {
        return null;
    }
}
```