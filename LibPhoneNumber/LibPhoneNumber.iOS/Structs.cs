using System;
using ObjCRuntime;

namespace LibPhoneNumber.iOS
{
	[Native]
	public enum NBEPhoneNumberFormat : long
	{
		E164 = 0,
		International = 1,
		National = 2,
		Rfc3966 = 3
	}

	[Native]
	public enum NBEPhoneNumberType : long
	{
		FixedLine = 0,
		Mobile = 1,
		FixedLineOrMobile = 2,
		TollFree = 3,
		PremiumRate = 4,
		SharedCost = 5,
		Voip = 6,
		PersonalNumber = 7,
		Pager = 8,
		Uan = 9,
		Voicemail = 10,
		Unknown = -1
	}

	[Native]
	public enum NBEMatchType : long
	{
		NotANumber = 0,
		NoMatch = 1,
		ShortNsnMatch = 2,
		NsnMatch = 3,
		ExactMatch = 4
	}

	[Native]
	public enum NBEValidationResult : long
	{
		Unknown = 0,
		IsPossible = 1,
		InvalidCountryCode = 2,
		TooShort = 3,
		TooLong = 4
	}

	[Native]
	public enum NBECountryCodeSource : long
	{
		NumberWithPlusSign = 1,
		NumberWithIdd = 5,
		NumberWithoutPlusSign = 10,
		DefaultCountry = 20
	}
}
