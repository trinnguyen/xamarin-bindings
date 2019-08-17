using System;

using UIKit;
using Foundation;
using ObjCRuntime;
using CoreGraphics;

namespace LinkedInMobileSDKiOS.Binding
{
	// The first step to creating a binding is to add your native library ("libNativeLibrary.a")
	// to the project by right-clicking (or Control-clicking) the folder containing this source
	// file and clicking "Add files..." and then simply select the native library (or libraries)
	// that you want to bind.
	//
	// When you do that, you'll notice that MonoDevelop generates a code-behind file for each
	// native library which will contain a [LinkWith] attribute. MonoDevelop auto-detects the
	// architectures that the native library supports and fills in that information for you,
	// however, it cannot auto-detect any Frameworks or other system libraries that the
	// native library may depend on, so you'll need to fill in that information yourself.
	//
	// Once you've done that, you're ready to move on to binding the API...
	//
	//
	// Here is where you'd define your API definition for the native Objective-C library.
	//
	// For example, to bind the following Objective-C class:
	//
	//     @interface Widget : NSObject {
	//     }
	//
	// The C# binding would look like this:
	//
	//     [BaseType (typeof (NSObject))]
	//     interface Widget {
	//     }
	//
	// To bind Objective-C properties, such as:
	//
	//     @property (nonatomic, readwrite, assign) CGPoint center;
	//
	// You would add a property definition in the C# interface like so:
	//
	//     [Export ("center")]
	//     CGPoint Center { get; set; }
	//
	// To bind an Objective-C method, such as:
	//
	//     -(void) doSomething:(NSObject *)object atIndex:(NSInteger)index;
	//
	// You would add a method definition to the C# interface like so:
	//
	//     [Export ("doSomething:atIndex:")]
	//     void DoSomething (NSObject object, int index);
	//
	// Objective-C "constructors" such as:
	//
	//     -(id)initWithElmo:(ElmoMuppet *)elmo;
	//
	// Can be bound as:
	//
	//     [Export ("initWithElmo:")]
	//     IntPtr Constructor (ElmoMuppet elmo);
	//
	// For more information, see http://developer.xamarin.com/guides/ios/advanced_topics/binding_objective-c/
	//

	public delegate void AuthSuccessBlock(string msg);
	public delegate void AuthErrorBlock(NSError error);

	[BaseType(typeof(NSObject))]
	interface LISDKAccessToken
	{
		[Export("accessTokenValue")]
		string AccessTokenValue { get; set; }

		[Export("expiration")]
		Foundation.NSDate Expiration { get; set; }

		[Export("serializedString")]
		string SerializedString { get; }

		[Static, Export("LISDKAccessTokenWithValue:expiresOnMillis:")]
		LISDKAccessToken LISDKAccessTokenWithValue(string value, long expiresOnMillis);

		[Static, Export("LISDKAccessTokenWithSerializedString:")]
		LISDKAccessToken LISDKAccessTokenWithSerializedString(string serString);
	}

	[BaseType(typeof(NSObject))]
	interface LISDKSession
	{ 
		[Export("accessToken")]
		LISDKAccessToken AccessToken { get; set; }

		[Export("isValid")]
		bool IsValid { get; }

		[Export("Value")]
		string value { get; }
	}

	[BaseType(typeof(NSObject))]
	interface LISDKSessionManager
	{
		[Static, Export("sharedInstance")]
		LISDKSessionManager SharedInstance { get; }

		[Export("session")]
		LISDKSession Session { get; set; }

		[Static, Export("createSessionWithAuth:state:showGoToAppStoreDialog:successBlock:errorBlock:")]
		void CreateSessionWithAuth(NSObject[] permissions, string state, bool showDialog, AuthSuccessBlock successBlock, AuthErrorBlock erroBlock);

		[Static, Export("createSessionWithAccessToken:")]
		void CreateSessionWithAccessToken(LISDKAccessToken accessToken);

		[Static, Export("clearSession")]
		void ClearSession();

		[Static, Export("hasValidSession")]
		bool HasValidSession { get; }

		[Static, Export("application:openURL:sourceApplication:annotation:")]
		bool ApplicationOpenURL(UIApplication application, NSUrl url, string sourceApplication, [NullAllowed] NSObject annotation);

		[Static, Export("shouldHandleUrl:")]
		bool ShouldHandleUrl(NSUrl url);
	}

	[BaseType(typeof(NSObject))]
	interface LISDKCallbackHandler
	{
		[Static, Export("shouldHandleUrl:")]
		bool ShouldHandleUrl(NSUrl url);

		[Static, Export("application:openURL:sourceApplication:annotation:")]
		bool ApplicationOpenURL(UIApplication application, NSUrl url, string sourceApplication, [NullAllowed] NSObject annotation);
	}

	[BaseType(typeof(NSObject))]
	interface LISDKAPIResponse
	{ 
		[Export("data")]
		string Data { get; set; }

		[Export("statusCode")]
		int StatusCode { get; set; }

		[Export("headers")]
		NSDictionary Headers { get; set; }

		[Export("initWithData:headers:statusCode:")]
		IntPtr Constructor(string data, NSDictionary headers, int statusCode);
	}

	[BaseType(typeof(NSError))]
	interface LISDKAPIError
	{
		[Export("errorResponse")]
		LISDKAPIResponse ErrorResponse { get; }

		[Static, Export("errorWithApiResponse:")]
		LISDKAPIError ErrorWithApiResponse(LISDKAPIResponse response);

		[Static, Export("errorWithError:")]
		LISDKAPIError ErrorWithError(NSError error);
	}

	[BaseType(typeof(NSObject))]
	interface LISDKAPIHelper
	{
		[Static, Export("sharedInstance")]
		LISDKAPIHelper SharedInstance { get; }

		[Export("getRequest:success:error:")]
		void GetRequest(string url, Action<LISDKAPIResponse> success, Action<LISDKAPIError> error);

		[Export("apiRequest:method:body:success:error:")]
		void ApiRequest(string url, string method, NSData body, Action<LISDKAPIResponse> successCompletion, Action<LISDKAPIError> errorCompletion);
	}
}

