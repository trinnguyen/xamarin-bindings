using System;
using Foundation;

namespace Tink
{
	// @protocol TINKAead <NSObject>
	/*
	  Check whether adding [Model] to this declaration is appropriate.
	  [Model] is used to generate a C# class that implements this protocol,
	  and might be useful for protocols that consumers are supposed to implement,
	  since consumers can subclass the generated class instead of implementing
	  the generated interface. If consumers are not supposed to implement this
	  protocol, then [Model] is redundant and will generate code that will never
	  be used.
	*/
	[Protocol]
	[BaseType(typeof(NSObject))]
	interface TINKAead
	{
		// @required -(NSData * _Nullable)encrypt:(NSData * _Nonnull)plaintext withAdditionalData:(NSData * _Nullable)additionalData error:(NSError * _Nullable * _Nullable)error;
		[Abstract]
		[Export("encrypt:withAdditionalData:error:")]
		[return: NullAllowed]
		NSData Encrypt(NSData plaintext, [NullAllowed] NSData additionalData, [NullAllowed] out NSError error);

		// @required -(NSData * _Nullable)decrypt:(NSData * _Nonnull)ciphertext withAdditionalData:(NSData * _Nullable)additionalData error:(NSError * _Nullable * _Nullable)error;
		[Abstract]
		[Export("decrypt:withAdditionalData:error:")]
		[return: NullAllowed]
		NSData Decrypt(NSData ciphertext, [NullAllowed] NSData additionalData, [NullAllowed] out NSError error);
	}

	interface ITINKAead { }

	// @interface TINKRegistryConfig : NSObject
	[BaseType(typeof(NSObject))]
	[DisableDefaultCtor]
	interface TINKRegistryConfig
	{
		// -(instancetype _Nullable)initWithError:(NSError * _Nullable * _Nullable)error __attribute__((swift_name("init()"))) __attribute__((objc_designated_initializer));
		[Export("initWithError:")]
		[DesignatedInitializer]
		IntPtr Constructor([NullAllowed] out NSError error);
	}

	// @interface TINKAeadConfig : TINKRegistryConfig
	[BaseType(typeof(TINKRegistryConfig))]
	[DisableDefaultCtor]
	interface TINKAeadConfig
	{
		// -(instancetype _Nullable)initWithError:(NSError * _Nullable * _Nullable)error __attribute__((swift_name("init()"))) __attribute__((objc_designated_initializer));
		[Export("initWithError:")]
		[DesignatedInitializer]
		IntPtr Constructor([NullAllowed] out NSError error);
	}

	// @interface TINKAeadFactory : NSObject
	[BaseType(typeof(NSObject))]
	interface TINKAeadFactory
	{
		// +(id<TINKAead> _Nullable)primitiveWithKeysetHandle:(TINKKeysetHandle * _Nonnull)keysetHandle error:(NSError * _Nullable * _Nullable)error;
		[Static]
		[Export("primitiveWithKeysetHandle:error:")]
		[return: NullAllowed]
		ITINKAead PrimitiveWithKeysetHandle(TINKKeysetHandle keysetHandle, [NullAllowed] out NSError error);
	}

	// @interface TINKKeyTemplate : NSObject
	[BaseType(typeof(NSObject))]
	[DisableDefaultCtor]
	interface TINKKeyTemplate
	{
	}

	// @interface TINKAeadKeyTemplate : TINKKeyTemplate
	[BaseType(typeof(TINKKeyTemplate))]
	[DisableDefaultCtor]
	interface TINKAeadKeyTemplate
	{
		// -(instancetype _Nullable)initWithKeyTemplate:(TINKAeadKeyTemplates)keyTemplate error:(NSError * _Nullable * _Nullable)error __attribute__((objc_designated_initializer));
		[Export("initWithKeyTemplate:error:")]
		[DesignatedInitializer]
		IntPtr Constructor(TINKAeadKeyTemplates keyTemplate, [NullAllowed] out NSError error);
	}

	// @interface TINKAllConfig : TINKRegistryConfig
	[BaseType(typeof(TINKRegistryConfig))]
	[DisableDefaultCtor]
	interface TINKAllConfig
	{
		// -(instancetype _Nullable)initWithError:(NSError * _Nullable * _Nullable)error __attribute__((swift_name("init()"))) __attribute__((objc_designated_initializer));
		[Export("initWithError:")]
		[DesignatedInitializer]
		IntPtr Constructor([NullAllowed] out NSError error);
	}

	// @interface TINKKeysetReader : NSObject
	[BaseType(typeof(NSObject))]
	interface TINKKeysetReader
	{
	}

	// @interface TINKBinaryKeysetReader : TINKKeysetReader
	[BaseType(typeof(TINKKeysetReader))]
	[DisableDefaultCtor]
	interface TINKBinaryKeysetReader
	{
		// -(instancetype _Nullable)initWithSerializedKeyset:(NSData * _Nonnull)keyset error:(NSError * _Nullable * _Nullable)error __attribute__((objc_designated_initializer));
		[Export("initWithSerializedKeyset:error:")]
		[DesignatedInitializer]
		IntPtr Constructor(NSData keyset, [NullAllowed] out NSError error);
	}

	// @interface TINKConfig : NSObject
	[BaseType(typeof(NSObject))]
	interface TINKConfig
	{
		// +(BOOL)registerConfig:(TINKRegistryConfig * _Nonnull)config error:(NSError * _Nullable * _Nullable)error;
		[Static]
		[Export("registerConfig:error:")]
		bool RegisterConfig(TINKRegistryConfig config, [NullAllowed] out NSError error);
	}

	// @protocol TINKDeterministicAead <NSObject>
	/*
	  Check whether adding [Model] to this declaration is appropriate.
	  [Model] is used to generate a C# class that implements this protocol,
	  and might be useful for protocols that consumers are supposed to implement,
	  since consumers can subclass the generated class instead of implementing
	  the generated interface. If consumers are not supposed to implement this
	  protocol, then [Model] is redundant and will generate code that will never
	  be used.
	*/
	[Protocol]
	[BaseType(typeof(NSObject))]
	interface TINKDeterministicAead
	{
		// @required -(NSData * _Nullable)encryptDeterministically:(NSData * _Nonnull)plaintext withAssociatedData:(NSData * _Nullable)associatedData error:(NSError * _Nullable * _Nullable)error;
		[Abstract]
		[Export("encryptDeterministically:withAssociatedData:error:")]
		[return: NullAllowed]
		NSData EncryptDeterministically(NSData plaintext, [NullAllowed] NSData associatedData, [NullAllowed] out NSError error);

		// @required -(NSData * _Nullable)decryptDeterministically:(NSData * _Nonnull)ciphertext withAssociatedData:(NSData * _Nullable)associatedData error:(NSError * _Nullable * _Nullable)error;
		[Abstract]
		[Export("decryptDeterministically:withAssociatedData:error:")]
		[return: NullAllowed]
		NSData DecryptDeterministically(NSData ciphertext, [NullAllowed] NSData associatedData, [NullAllowed] out NSError error);
	}

	interface ITINKDeterministicAead { }

	// @interface TINKDeterministicAeadConfig : TINKRegistryConfig
	[BaseType(typeof(TINKRegistryConfig))]
	[DisableDefaultCtor]
	interface TINKDeterministicAeadConfig
	{
		// -(instancetype _Nullable)initWithError:(NSError * _Nullable * _Nullable)error __attribute__((swift_name("init()"))) __attribute__((objc_designated_initializer));
		[Export("initWithError:")]
		[DesignatedInitializer]
		IntPtr Constructor([NullAllowed] out NSError error);
	}

	// @interface TINKDeterministicAeadFactory : NSObject
	[BaseType(typeof(NSObject))]
	interface TINKDeterministicAeadFactory
	{
		// +(id<TINKDeterministicAead> _Nullable)primitiveWithKeysetHandle:(TINKKeysetHandle * _Nonnull)keysetHandle error:(NSError * _Nullable * _Nullable)error;
		[Static]
		[Export("primitiveWithKeysetHandle:error:")]
		[return: NullAllowed]
		ITINKDeterministicAead PrimitiveWithKeysetHandle(TINKKeysetHandle keysetHandle, [NullAllowed] out NSError error);
	}

	// @interface TINKDeterministicAeadKeyTemplate : TINKKeyTemplate
	[BaseType(typeof(TINKKeyTemplate))]
	[DisableDefaultCtor]
	interface TINKDeterministicAeadKeyTemplate
	{
		// -(instancetype _Nullable)initWithKeyTemplate:(TINKDeterministicAeadKeyTemplates)keyTemplate error:(NSError * _Nullable * _Nullable)error __attribute__((objc_designated_initializer));
		[Export("initWithKeyTemplate:error:")]
		[DesignatedInitializer]
		IntPtr Constructor(TINKDeterministicAeadKeyTemplates keyTemplate, [NullAllowed] out NSError error);
	}

	// @interface TINKHybridConfig : TINKRegistryConfig
	[BaseType(typeof(TINKRegistryConfig))]
	[DisableDefaultCtor]
	interface TINKHybridConfig
	{
		// -(instancetype _Nullable)initWithError:(NSError * _Nullable * _Nullable)error __attribute__((swift_name("init()"))) __attribute__((objc_designated_initializer));
		[Export("initWithError:")]
		[DesignatedInitializer]
		IntPtr Constructor([NullAllowed] out NSError error);
	}

	// @protocol TINKHybridDecrypt <NSObject>
	/*
	  Check whether adding [Model] to this declaration is appropriate.
	  [Model] is used to generate a C# class that implements this protocol,
	  and might be useful for protocols that consumers are supposed to implement,
	  since consumers can subclass the generated class instead of implementing
	  the generated interface. If consumers are not supposed to implement this
	  protocol, then [Model] is redundant and will generate code that will never
	  be used.
	*/
	[Protocol]
	[BaseType(typeof(NSObject))]
	interface TINKHybridDecrypt
	{
		// @required -(NSData * _Nullable)decrypt:(NSData * _Nonnull)ciphertext withContextInfo:(NSData * _Nullable)contextInfo error:(NSError * _Nullable * _Nullable)error;
		[Abstract]
		[Export("decrypt:withContextInfo:error:")]
		[return: NullAllowed]
		NSData WithContextInfo(NSData ciphertext, [NullAllowed] NSData contextInfo, [NullAllowed] out NSError error);
	}

	// @interface TINKHybridDecryptFactory : NSObject
	[BaseType(typeof(NSObject))]
	interface TINKHybridDecryptFactory
	{
		// +(id<TINKHybridDecrypt> _Nullable)primitiveWithKeysetHandle:(TINKKeysetHandle * _Nonnull)keysetHandle error:(NSError * _Nullable * _Nullable)error;
		[Static]
		[Export("primitiveWithKeysetHandle:error:")]
		[return: NullAllowed]
		TINKHybridDecrypt PrimitiveWithKeysetHandle(TINKKeysetHandle keysetHandle, [NullAllowed] out NSError error);
	}

	// @protocol TINKHybridEncrypt <NSObject>
	/*
	  Check whether adding [Model] to this declaration is appropriate.
	  [Model] is used to generate a C# class that implements this protocol,
	  and might be useful for protocols that consumers are supposed to implement,
	  since consumers can subclass the generated class instead of implementing
	  the generated interface. If consumers are not supposed to implement this
	  protocol, then [Model] is redundant and will generate code that will never
	  be used.
	*/
	[Protocol]
	[BaseType(typeof(NSObject))]
	interface TINKHybridEncrypt
	{
		// @required -(NSData * _Nullable)encrypt:(NSData * _Nonnull)plaintext withContextInfo:(NSData * _Nullable)contextInfo error:(NSError * _Nullable * _Nullable)error;
		[Abstract]
		[Export("encrypt:withContextInfo:error:")]
		[return: NullAllowed]
		NSData WithContextInfo(NSData plaintext, [NullAllowed] NSData contextInfo, [NullAllowed] out NSError error);
	}

	// @interface TINKHybridEncryptFactory : NSObject
	[BaseType(typeof(NSObject))]
	interface TINKHybridEncryptFactory
	{
		// +(id<TINKHybridEncrypt> _Nullable)primitiveWithKeysetHandle:(TINKKeysetHandle * _Nonnull)keysetHandle error:(NSError * _Nullable * _Nullable)error;
		[Static]
		[Export("primitiveWithKeysetHandle:error:")]
		[return: NullAllowed]
		TINKHybridEncrypt PrimitiveWithKeysetHandle(TINKKeysetHandle keysetHandle, [NullAllowed] out NSError error);
	}

	// @interface TINKHybridKeyTemplate : TINKKeyTemplate
	[BaseType(typeof(TINKKeyTemplate))]
	[DisableDefaultCtor]
	interface TINKHybridKeyTemplate
	{
		// -(instancetype _Nullable)initWithKeyTemplate:(TINKHybridKeyTemplates)keyTemplate error:(NSError * _Nullable * _Nullable)error __attribute__((objc_designated_initializer));
		[Export("initWithKeyTemplate:error:")]
		[DesignatedInitializer]
		IntPtr Constructor(TINKHybridKeyTemplates keyTemplate, [NullAllowed] out NSError error);
	}

	// @interface TINKJSONKeysetReader : TINKKeysetReader
	[BaseType(typeof(TINKKeysetReader))]
	[DisableDefaultCtor]
	interface TINKJSONKeysetReader
	{
		// -(instancetype _Nullable)initWithSerializedKeyset:(NSData * _Nonnull)keyset error:(NSError * _Nullable * _Nullable)error __attribute__((objc_designated_initializer));
		[Export("initWithSerializedKeyset:error:")]
		[DesignatedInitializer]
		IntPtr Constructor(NSData keyset, [NullAllowed] out NSError error);
	}

	// @interface TINKKeysetHandle : NSObject
	[BaseType(typeof(NSObject))]
	[DisableDefaultCtor]
	interface TINKKeysetHandle
	{
		// -(instancetype _Nullable)initWithKeysetReader:(TINKKeysetReader * _Nonnull)reader andKey:(id<TINKAead> _Nonnull)aeadKey error:(NSError * _Nullable * _Nullable)error;
		[Export("initWithKeysetReader:andKey:error:")]
		IntPtr Constructor(TINKKeysetReader reader, ITINKAead aeadKey, [NullAllowed] out NSError error);

		// -(instancetype _Nullable)initWithNoSecretKeyset:(NSData * _Nonnull)keyset error:(NSError * _Nullable * _Nullable)error;
		[Export("initWithNoSecretKeyset:error:")]
		IntPtr Constructor(NSData keyset, [NullAllowed] out NSError error);

		// -(instancetype _Nullable)initWithKeyTemplate:(TINKKeyTemplate * _Nonnull)keyTemplate error:(NSError * _Nullable * _Nullable)error;
		[Export("initWithKeyTemplate:error:")]
		IntPtr Constructor(TINKKeyTemplate keyTemplate, [NullAllowed] out NSError error);

		// -(instancetype _Nullable)initFromKeychainWithName:(NSString * _Nonnull)keysetName error:(NSError * _Nullable * _Nullable)error;
		[Export("initFromKeychainWithName:error:")]
		IntPtr Constructor(string keysetName, [NullAllowed] out NSError error);

		// +(instancetype _Nullable)publicKeysetHandleWithHandle:(TINKKeysetHandle * _Nonnull)aHandle error:(NSError * _Nullable * _Nullable)error;
		[Static]
		[Export("publicKeysetHandleWithHandle:error:")]
		[return: NullAllowed]
		TINKKeysetHandle PublicKeysetHandleWithHandle(TINKKeysetHandle aHandle, [NullAllowed] out NSError error);

		// -(BOOL)writeToKeychainWithName:(NSString * _Nonnull)keysetName overwrite:(BOOL)overwrite error:(NSError * _Nullable * _Nullable)error;
		[Export("writeToKeychainWithName:overwrite:error:")]
		bool WriteToKeychainWithName(string keysetName, bool overwrite, [NullAllowed] out NSError error);

		// +(BOOL)deleteFromKeychainWithName:(NSString * _Nonnull)keysetName error:(NSError * _Nullable * _Nullable)error;
		[Static]
		[Export("deleteFromKeychainWithName:error:")]
		bool DeleteFromKeychainWithName(string keysetName, [NullAllowed] out NSError error);

		// -(instancetype _Nullable)initCleartextKeysetHandleWithKeysetReader:(TINKKeysetReader * _Nonnull)reader error:(NSError * _Nullable * _Nullable)error;
		[Export("initCleartextKeysetHandleWithKeysetReader:error:")]
		IntPtr Constructor(TINKKeysetReader reader, [NullAllowed] out NSError error);

		// -(NSData * _Nonnull)serializedKeyset;
		[Export("serializedKeyset")]
		// [Verify(MethodToProperty)]
		NSData SerializedKeyset { get; }
	}

	// @protocol TINKMac
	/*
	  Check whether adding [Model] to this declaration is appropriate.
	  [Model] is used to generate a C# class that implements this protocol,
	  and might be useful for protocols that consumers are supposed to implement,
	  since consumers can subclass the generated class instead of implementing
	  the generated interface. If consumers are not supposed to implement this
	  protocol, then [Model] is redundant and will generate code that will never
	  be used.
	*/
	[Protocol]
	interface TINKMac
	{
		// @required -(NSData * _Nullable)computeMacForData:(NSData * _Nonnull)data error:(NSError * _Nullable * _Nullable)error;
		[Abstract]
		[Export("computeMacForData:error:")]
		[return: NullAllowed]
		NSData ComputeMacForData(NSData data, [NullAllowed] out NSError error);

		// @required -(BOOL)verifyMac:(NSData * _Nonnull)mac forData:(NSData * _Nonnull)data error:(NSError * _Nullable * _Nullable)error;
		[Abstract]
		[Export("verifyMac:forData:error:")]
		bool VerifyMac(NSData mac, NSData data, [NullAllowed] out NSError error);
	}

	interface ITINKMac {}

	// @interface TINKMacConfig : TINKRegistryConfig
	[BaseType(typeof(TINKRegistryConfig))]
	[DisableDefaultCtor]
	interface TINKMacConfig
	{
		// -(instancetype _Nullable)initWithError:(NSError * _Nullable * _Nullable)error __attribute__((swift_name("init()"))) __attribute__((objc_designated_initializer));
		[Export("initWithError:")]
		[DesignatedInitializer]
		IntPtr Constructor([NullAllowed] out NSError error);
	}

	// @interface TINKMacFactory : NSObject
	[BaseType(typeof(NSObject))]
	interface TINKMacFactory
	{
		// +(id<TINKMac> _Nullable)primitiveWithKeysetHandle:(TINKKeysetHandle * _Nonnull)keysetHandle error:(NSError * _Nullable * _Nullable)error;
		[Static]
		[Export("primitiveWithKeysetHandle:error:")]
		[return: NullAllowed]
		ITINKMac PrimitiveWithKeysetHandle(TINKKeysetHandle keysetHandle, [NullAllowed] out NSError error);
	}

	// @interface TINKMacKeyTemplate : TINKKeyTemplate
	[BaseType(typeof(TINKKeyTemplate))]
	[DisableDefaultCtor]
	interface TINKMacKeyTemplate
	{
		// -(instancetype _Nullable)initWithKeyTemplate:(TINKMacKeyTemplates)keyTemplate error:(NSError * _Nullable * _Nullable)error __attribute__((objc_designated_initializer));
		[Export("initWithKeyTemplate:error:")]
		[DesignatedInitializer]
		IntPtr Constructor(TINKMacKeyTemplates keyTemplate, [NullAllowed] out NSError error);
	}

	// @protocol TINKPublicKeySign <NSObject>
	/*
	  Check whether adding [Model] to this declaration is appropriate.
	  [Model] is used to generate a C# class that implements this protocol,
	  and might be useful for protocols that consumers are supposed to implement,
	  since consumers can subclass the generated class instead of implementing
	  the generated interface. If consumers are not supposed to implement this
	  protocol, then [Model] is redundant and will generate code that will never
	  be used.
	*/
	[Protocol]
	[BaseType(typeof(NSObject))]
	interface TINKPublicKeySign
	{
		// @required -(NSData * _Nullable)signatureForData:(NSData * _Nonnull)data error:(NSError * _Nullable * _Nullable)error;
		[Abstract]
		[Export("signatureForData:error:")]
		[return: NullAllowed]
		NSData Error(NSData data, [NullAllowed] out NSError error);
	}

	// @interface TINKPublicKeySignFactory : NSObject
	[BaseType(typeof(NSObject))]
	interface TINKPublicKeySignFactory
	{
		// +(id<TINKPublicKeySign> _Nullable)primitiveWithKeysetHandle:(TINKKeysetHandle * _Nonnull)keysetHandle error:(NSError * _Nullable * _Nullable)error;
		[Static]
		[Export("primitiveWithKeysetHandle:error:")]
		[return: NullAllowed]
		TINKPublicKeySign PrimitiveWithKeysetHandle(TINKKeysetHandle keysetHandle, [NullAllowed] out NSError error);
	}

	// @protocol TINKPublicKeyVerify <NSObject>
	/*
	  Check whether adding [Model] to this declaration is appropriate.
	  [Model] is used to generate a C# class that implements this protocol,
	  and might be useful for protocols that consumers are supposed to implement,
	  since consumers can subclass the generated class instead of implementing
	  the generated interface. If consumers are not supposed to implement this
	  protocol, then [Model] is redundant and will generate code that will never
	  be used.
	*/
	[Protocol]
	[BaseType(typeof(NSObject))]
	interface TINKPublicKeyVerify
	{
		// @required -(BOOL)verifySignature:(NSData * _Nonnull)signature forData:(NSData * _Nonnull)data error:(NSError * _Nullable * _Nullable)error;
		[Abstract]
		[Export("verifySignature:forData:error:")]
		bool ForData(NSData signature, NSData data, [NullAllowed] out NSError error);
	}

	// @interface TINKPublicKeyVerifyFactory : NSObject
	[BaseType(typeof(NSObject))]
	interface TINKPublicKeyVerifyFactory
	{
		// +(id<TINKPublicKeyVerify> _Nullable)primitiveWithKeysetHandle:(TINKKeysetHandle * _Nonnull)keysetHandle error:(NSError * _Nullable * _Nullable)error;
		[Static]
		[Export("primitiveWithKeysetHandle:error:")]
		[return: NullAllowed]
		TINKPublicKeyVerify PrimitiveWithKeysetHandle(TINKKeysetHandle keysetHandle, [NullAllowed] out NSError error);
	}

	// @interface TINKSignatureConfig : TINKRegistryConfig
	[BaseType(typeof(TINKRegistryConfig))]
	[DisableDefaultCtor]
	interface TINKSignatureConfig
	{
		// -(instancetype _Nullable)initWithError:(NSError * _Nullable * _Nullable)error __attribute__((swift_name("init()"))) __attribute__((objc_designated_initializer));
		[Export("initWithError:")]
		[DesignatedInitializer]
		IntPtr Constructor([NullAllowed] out NSError error);
	}

	// @interface TINKSignatureKeyTemplate : TINKKeyTemplate
	[BaseType(typeof(TINKKeyTemplate))]
	[DisableDefaultCtor]
	interface TINKSignatureKeyTemplate
	{
		// -(instancetype _Nullable)initWithKeyTemplate:(TINKSignatureKeyTemplates)keyTemplate error:(NSError * _Nullable * _Nullable)error __attribute__((objc_designated_initializer));
		[Export("initWithKeyTemplate:error:")]
		[DesignatedInitializer]
		IntPtr Constructor(TINKSignatureKeyTemplates keyTemplate, [NullAllowed] out NSError error);
	}

	[Static]
	partial interface Constants
	{
		// extern NSString *const TINKVersion;
		[Field("TINKVersion", "__Internal")]
		NSString TINKVersion { get; }
	}
}