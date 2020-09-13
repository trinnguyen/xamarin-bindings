using ObjCRuntime;

namespace Tink
{
	[Native]
	public enum TINKAeadKeyTemplates : long
	{
		Aes128Gcm = 1,
		Aes256Gcm = 2,
		Aes128CtrHmacSha256 = 3,
		Aes256CtrHmacSha256 = 4,
		Aes128Eax = 5,
		Aes256Eax = 6,
		XChaCha20Poly1305 = 7
	}

	[Native]
	public enum TINKDeterministicAeadKeyTemplates : long
	{
		TINKAes256Siv = 1
	}

	[Native]
	public enum TINKHybridKeyTemplates : long
	{
		Gcm = 1,
		CtrHmacSha256 = 2
	}

	[Native]
	public enum TINKMacKeyTemplates : long
	{
		HmacSha256HalfSizeTag = 1,
		HmacSha256 = 2,
		HmacSha512HalfSizeTag = 3,
		HmacSha512 = 4,
		AesCmac = 5
	}

	[Native]
	public enum TINKSignatureKeyTemplates : long
	{
		EcdsaP256 = 1,
		EcdsaP384 = 2,
		EcdsaP521 = 3,
		EcdsaP256Ieee = 4,
		EcdsaP384Ieee = 5,
		EcdsaP521Ieee = 6,
		RsaSsaPkcs13072Sha256F4 = 7,
		RsaSsaPkcs14096Sha512F4 = 8,
		RsaSsaPss3072Sha256Sha256F4 = 9,
		RsaSsaPss4096Sha512Sha512F4 = 10,
		Ed25519 = 11
	}

}