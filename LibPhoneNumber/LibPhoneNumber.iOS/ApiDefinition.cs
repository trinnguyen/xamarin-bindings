using System;

using UIKit;
using Foundation;
using ObjCRuntime;
using CoreGraphics;

namespace LibPhoneNumber.iOS
{

	//[Static]
	//[Verify(ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern double libPhoneNumber_iOSVersionNumber;
		[Field("libPhoneNumber_iOSVersionNumber", "__Internal")]
		double libPhoneNumber_iOSVersionNumber { get; }

		// extern const unsigned char [] libPhoneNumber_iOSVersionString;
		[Field("libPhoneNumber_iOSVersionString", "__Internal")]
		byte[] libPhoneNumber_iOSVersionString { get; }
	}

	//[Static]
	//[Verify(ConstantsInterfaceAssociation)]
	partial interface Constants
	{
		// extern NSString *const NB_UNKNOWN_REGION;
		[Field("NB_UNKNOWN_REGION", "__Internal")]
		NSString NB_UNKNOWN_REGION { get; }

		// extern NSString *const NB_NON_BREAKING_SPACE;
		[Field("NB_NON_BREAKING_SPACE", "__Internal")]
		NSString NB_NON_BREAKING_SPACE { get; }

		// extern NSString *const NB_PLUS_CHARS;
		[Field("NB_PLUS_CHARS", "__Internal")]
		NSString NB_PLUS_CHARS { get; }

		// extern NSString *const NB_VALID_DIGITS_STRING;
		[Field("NB_VALID_DIGITS_STRING", "__Internal")]
		NSString NB_VALID_DIGITS_STRING { get; }

		// extern NSString *const NB_REGION_CODE_FOR_NON_GEO_ENTITY;
		[Field("NB_REGION_CODE_FOR_NON_GEO_ENTITY", "__Internal")]
		NSString NB_REGION_CODE_FOR_NON_GEO_ENTITY { get; }
	}

	[BaseType(typeof(NSObject))]
	interface NBPhoneNumberUtil
	{
		//+ (NBPhoneNumberUtil*)sharedInstance;
		[Static, Export("sharedInstance")]
		NBPhoneNumberUtil SharedInstance { get; }

		//- (NBEMatchType)isNumberMatch:(id)firstNumberIn second:(id)secondNumberIn error:(NSError**)error;
		[Export("isNumberMatch:second:error:")]
		NBEMatchType IsNumberMatch(NSObject firstNumberIn, NSObject secondNumberIn, out NSError error);
	}
}
