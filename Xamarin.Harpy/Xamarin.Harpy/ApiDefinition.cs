using System;

using UIKit;
using Foundation;
using ObjCRuntime;

namespace Xamarin.Harpy
{
    // @protocol HarpyDelegate <NSObject>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface HarpyDelegate
    {
        // @optional -(void)harpyDidShowUpdateDialog;
        [Export("harpyDidShowUpdateDialog")]
        void HarpyDidShowUpdateDialog();

        // @optional -(void)harpyUserDidLaunchAppStore;
        [Export("harpyUserDidLaunchAppStore")]
        void HarpyUserDidLaunchAppStore();

        // @optional -(void)harpyUserDidSkipVersion;
        [Export("harpyUserDidSkipVersion")]
        void HarpyUserDidSkipVersion();

        // @optional -(void)harpyUserDidCancel;
        [Export("harpyUserDidCancel")]
        void HarpyUserDidCancel();

        // @optional -(void)harpyDidDetectNewVersionWithoutAlert:(NSString *)message;
        [Export("harpyDidDetectNewVersionWithoutAlert:")]
        void HarpyDidDetectNewVersionWithoutAlert(string message);
    }

    // @interface Harpy : NSObject
    [BaseType(typeof(NSObject))]
    interface Harpy
    {
        [Wrap("WeakDelegate")]
        HarpyDelegate Delegate { get; set; }

        // @property (nonatomic, weak) id<HarpyDelegate> delegate;
        [NullAllowed, Export("delegate", ArgumentSemantic.Weak)]
        NSObject WeakDelegate { get; set; }

        // @property (nonatomic, strong) UIViewController * presentingViewController;
        [Export("presentingViewController", ArgumentSemantic.Strong)]
        UIViewController PresentingViewController { get; set; }

        // @property (readonly, copy, nonatomic) NSString * currentAppStoreVersion;
        [Export("currentAppStoreVersion")]
        string CurrentAppStoreVersion { get; }

        // @property (nonatomic, strong) NSString * appName;
        [Export("appName", ArgumentSemantic.Strong)]
        string AppName { get; set; }

        // @property (getter = isDebugEnabled, assign, nonatomic) BOOL debugEnabled;
        [Export("debugEnabled")]
        bool DebugEnabled { [Bind("isDebugEnabled")] get; set; }

        // @property (assign, nonatomic) HarpyAlertType alertType;
        [Export("alertType", ArgumentSemantic.Assign)]
        HarpyAlertType AlertType { get; set; }

        // @property (assign, nonatomic) HarpyAlertType majorUpdateAlertType;
        [Export("majorUpdateAlertType", ArgumentSemantic.Assign)]
        HarpyAlertType MajorUpdateAlertType { get; set; }

        // @property (assign, nonatomic) HarpyAlertType minorUpdateAlertType;
        [Export("minorUpdateAlertType", ArgumentSemantic.Assign)]
        HarpyAlertType MinorUpdateAlertType { get; set; }

        // @property (assign, nonatomic) HarpyAlertType patchUpdateAlertType;
        [Export("patchUpdateAlertType", ArgumentSemantic.Assign)]
        HarpyAlertType PatchUpdateAlertType { get; set; }

        // @property (assign, nonatomic) HarpyAlertType revisionUpdateAlertType;
        [Export("revisionUpdateAlertType", ArgumentSemantic.Assign)]
        HarpyAlertType RevisionUpdateAlertType { get; set; }

        // @property (copy, nonatomic) NSString * countryCode;
        [Export("countryCode")]
        string CountryCode { get; set; }

        // @property (copy, nonatomic) NSString * forceLanguageLocalization;
        [Export("forceLanguageLocalization")]
        string ForceLanguageLocalization { get; set; }

        // @property (nonatomic, strong) UIColor * alertControllerTintColor;
        [Export("alertControllerTintColor", ArgumentSemantic.Strong)]
        UIColor AlertControllerTintColor { get; set; }

        // @property (assign, nonatomic) NSUInteger showAlertAfterCurrentVersionHasBeenReleasedForDays;
        [Export("showAlertAfterCurrentVersionHasBeenReleasedForDays")]
        nuint ShowAlertAfterCurrentVersionHasBeenReleasedForDays { get; set; }

        // +(Harpy *)sharedInstance;
        [Static]
        [Export("sharedInstance")]
        Harpy SharedInstance { get; }

        // -(void)checkVersion;
        [Export("checkVersion")]
        void CheckVersion();

        // -(void)checkVersionDaily;
        [Export("checkVersionDaily")]
        void CheckVersionDaily();

        // -(void)checkVersionWeekly;
        [Export("checkVersionWeekly")]
        void CheckVersionWeekly();

        // -(NSString *)testLocalizedStringForKey:(NSString *)stringKey;
        [Export("testLocalizedStringForKey:")]
        string TestLocalizedStringForKey(string stringKey);

        // -(void)testSetCurrentInstalledVersion:(NSString *)version;
        [Export("testSetCurrentInstalledVersion:")]
        void TestSetCurrentInstalledVersion(string version);

        // -(void)testSetCurrentAppStoreVersion:(NSString *)version;
        [Export("testSetCurrentAppStoreVersion:")]
        void TestSetCurrentAppStoreVersion(string version);

        // -(BOOL)testIsAppStoreVersionNewer;
        [Export("testIsAppStoreVersionNewer")]
        bool TestIsAppStoreVersionNewer { get; }
    }
}