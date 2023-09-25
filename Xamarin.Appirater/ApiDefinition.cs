using System;
using Foundation;
using ObjCRuntime;
using StoreKit;
using UIKit;

namespace AppiraterBinding
{
    interface IAppiraterDelegate { }

    // @protocol AppiraterDelegate <NSObject>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface AppiraterDelegate
    {
        // @optional -(BOOL)appiraterShouldDisplayAlert:(Appirater *)appirater;
        [Export("appiraterShouldDisplayAlert:")]
        bool AppiraterShouldDisplayAlert(Appirater appirater);

        // @optional -(void)appiraterDidDisplayAlert:(Appirater *)appirater;
        [Export("appiraterDidDisplayAlert:")]
        void AppiraterDidDisplayAlert(Appirater appirater);

        // @optional -(void)appiraterDidDeclineToRate:(Appirater *)appirater;
        [Export("appiraterDidDeclineToRate:")]
        void AppiraterDidDeclineToRate(Appirater appirater);

        // @optional -(void)appiraterDidOptToRate:(Appirater *)appirater;
        [Export("appiraterDidOptToRate:")]
        void AppiraterDidOptToRate(Appirater appirater);

        // @optional -(void)appiraterDidOptToRemindLater:(Appirater *)appirater;
        [Export("appiraterDidOptToRemindLater:")]
        void AppiraterDidOptToRemindLater(Appirater appirater);

        // @optional -(void)appiraterWillPresentModalView:(Appirater *)appirater animated:(BOOL)animated;
        [Export("appiraterWillPresentModalView:animated:")]
        void AppiraterWillPresentModalView(Appirater appirater, bool animated);

        // @optional -(void)appiraterDidDismissModalView:(Appirater *)appirater animated:(BOOL)animated;
        [Export("appiraterDidDismissModalView:animated:")]
        void AppiraterDidDismissModalView(Appirater appirater, bool animated);
    }

    [Static]
    partial interface Constants
    {
        // extern NSString *const kAppiraterFirstUseDate;
        [Field("kAppiraterFirstUseDate", "__Internal")]
        NSString kAppiraterFirstUseDate { get; }

        // extern NSString *const kAppiraterUseCount;
        [Field("kAppiraterUseCount", "__Internal")]
        NSString kAppiraterUseCount { get; }

        // extern NSString *const kAppiraterSignificantEventCount;
        [Field("kAppiraterSignificantEventCount", "__Internal")]
        NSString kAppiraterSignificantEventCount { get; }

        // extern NSString *const kAppiraterCurrentVersion;
        [Field("kAppiraterCurrentVersion", "__Internal")]
        NSString kAppiraterCurrentVersion { get; }

        // extern NSString *const kAppiraterRatedCurrentVersion;
        [Field("kAppiraterRatedCurrentVersion", "__Internal")]
        NSString kAppiraterRatedCurrentVersion { get; }

        // extern NSString *const kAppiraterDeclinedToRate;
        [Field("kAppiraterDeclinedToRate", "__Internal")]
        NSString kAppiraterDeclinedToRate { get; }

        // extern NSString *const kAppiraterReminderRequestDate;
        [Field("kAppiraterReminderRequestDate", "__Internal")]
        NSString kAppiraterReminderRequestDate { get; }
    }

    // @interface Appirater : NSObject <UIAlertViewDelegate, SKStoreProductViewControllerDelegate>
    [BaseType(typeof(NSObject))]
    interface Appirater : IUIAlertViewDelegate, ISKStoreProductViewControllerDelegate
    {
        // @property (nonatomic, strong) id ratingAlert;
        [Export("ratingAlert", ArgumentSemantic.Strong)]
        NSObject RatingAlert { get; set; }

        // @property (nonatomic) BOOL openInAppStore;
        [Export("openInAppStore")]
        bool OpenInAppStore { get; set; }

        [Wrap("WeakDelegate")]
        AppiraterDelegate Delegate { get; set; }

        // @property (nonatomic, unsafe_unretained) NSObject<AppiraterDelegate> * delegate;
        [NullAllowed, Export("delegate", ArgumentSemantic.Assign)]
        NSObject WeakDelegate { get; set; }

        // +(void)appLaunched:(BOOL)canPromptForRating;
        [Static]
        [Export("appLaunched:")]
        void AppLaunched(bool canPromptForRating);

        // +(void)appEnteredForeground:(BOOL)canPromptForRating;
        [Static]
        [Export("appEnteredForeground:")]
        void AppEnteredForeground(bool canPromptForRating);

        // +(void)userDidSignificantEvent:(BOOL)canPromptForRating;
        [Static]
        [Export("userDidSignificantEvent:")]
        void UserDidSignificantEvent(bool canPromptForRating);

        // +(void)tryToShowPrompt;
        [Static]
        [Export("tryToShowPrompt")]
        void TryToShowPrompt();

        // +(void)forceShowPrompt:(BOOL)displayRateLaterButton;
        [Static]
        [Export("forceShowPrompt:")]
        void ForceShowPrompt(bool displayRateLaterButton);

        // +(void)rateApp;
        [Static]
        [Export("rateApp")]
        void RateApp();

        // +(void)closeModal;
        [Static]
        [Export("closeModal")]
        void CloseModal();

        // -(BOOL)userHasDeclinedToRate;
        [Export("userHasDeclinedToRate")]
        bool UserHasDeclinedToRate { get; }

        // -(BOOL)userHasRatedCurrentVersion;
        [Export("userHasRatedCurrentVersion")]
        bool UserHasRatedCurrentVersion { get; }

        // +(void)setAppId:(NSString *)appId;
        [Static]
        [Export("setAppId:")]
        void SetAppId(string appId);

        // +(void)setDaysUntilPrompt:(double)value;
        [Static]
        [Export("setDaysUntilPrompt:")]
        void SetDaysUntilPrompt(double value);

        // +(void)setUsesUntilPrompt:(NSInteger)value;
        [Static]
        [Export("setUsesUntilPrompt:")]
        void SetUsesUntilPrompt(nint value);

        // +(void)setSignificantEventsUntilPrompt:(NSInteger)value;
        [Static]
        [Export("setSignificantEventsUntilPrompt:")]
        void SetSignificantEventsUntilPrompt(nint value);

        // +(void)setTimeBeforeReminding:(double)value;
        [Static]
        [Export("setTimeBeforeReminding:")]
        void SetTimeBeforeReminding(double value);

        // +(void)setCustomAlertTitle:(NSString *)title;
        [Static]
        [Export("setCustomAlertTitle:")]
        void SetCustomAlertTitle(string title);

        // +(void)setCustomAlertMessage:(NSString *)message;
        [Static]
        [Export("setCustomAlertMessage:")]
        void SetCustomAlertMessage(string message);

        // +(void)setCustomAlertCancelButtonTitle:(NSString *)cancelTitle;
        [Static]
        [Export("setCustomAlertCancelButtonTitle:")]
        void SetCustomAlertCancelButtonTitle(string cancelTitle);

        // +(void)setCustomAlertRateButtonTitle:(NSString *)rateTitle;
        [Static]
        [Export("setCustomAlertRateButtonTitle:")]
        void SetCustomAlertRateButtonTitle(string rateTitle);

        // +(void)setCustomAlertRateLaterButtonTitle:(NSString *)rateLaterTitle;
        [Static]
        [Export("setCustomAlertRateLaterButtonTitle:")]
        void SetCustomAlertRateLaterButtonTitle(string rateLaterTitle);

        // +(void)setDebug:(BOOL)debug;
        [Static]
        [Export("setDebug:")]
        void SetDebug(bool debug);

        // +(void)setDelegate:(id<AppiraterDelegate>)delegate;
        [Static]
        [Export("setDelegate:")]
        void SetDelegate(AppiraterDelegate @delegate);

        // +(void)setUsesAnimation:(BOOL)animation;
        [Static]
        [Export("setUsesAnimation:")]
        void SetUsesAnimation(bool animation);

        // +(void)setOpenInAppStore:(BOOL)openInAppStore;
        [Static]
        [Export("setOpenInAppStore:")]
        void SetOpenInAppStore(bool openInAppStore);

        // +(void)setAlwaysUseMainBundle:(BOOL)useMainBundle;
        [Static]
        [Export("setAlwaysUseMainBundle:")]
        void SetAlwaysUseMainBundle(bool useMainBundle);
    }
}
