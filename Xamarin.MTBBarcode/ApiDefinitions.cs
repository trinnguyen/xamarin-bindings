using System;
using AVFoundation;
using CoreAnimation;
using CoreGraphics;
using Foundation;
using ObjCRuntime;
using UIKit;

namespace MTBBarcode
{
	// @interface MTBBarcodeScanner : NSObject
	[BaseType (typeof(NSObject))]
	interface MTBBarcodeScanner
	{
		// @property (readonly, assign, nonatomic) MTBCamera camera;
		[Export ("camera", ArgumentSemantic.Assign)]
		MTBCamera Camera { get; }

		// @property (assign, nonatomic) MTBTorchMode torchMode;
		[Export ("torchMode", ArgumentSemantic.Assign)]
		MTBTorchMode TorchMode { get; set; }

		// @property (assign, nonatomic) BOOL allowTapToFocus;
		[Export ("allowTapToFocus")]
		bool AllowTapToFocus { get; set; }

		// @property (assign, nonatomic) CGRect scanRect;
		[Export ("scanRect", ArgumentSemantic.Assign)]
		CGRect ScanRect { get; set; }

		// @property (nonatomic, strong) CALayer * previewLayer;
		[Export ("previewLayer", ArgumentSemantic.Strong)]
		CALayer PreviewLayer { get; set; }

		// @property (copy, nonatomic) void (^didStartScanningBlock)();
		[Export ("didStartScanningBlock", ArgumentSemantic.Copy)]
		Action DidStartScanningBlock { get; set; }

		// @property (copy, nonatomic) void (^didTapToFocusBlock)(CGPoint);
		[Export ("didTapToFocusBlock", ArgumentSemantic.Copy)]
		Action<CGPoint> DidTapToFocusBlock { get; set; }

		// @property (copy, nonatomic) void (^resultBlock)(NSArray<AVMetadataMachineReadableCodeObject *> *);
		[Export ("resultBlock", ArgumentSemantic.Copy)]
		Action<NSArray<AVMetadataMachineReadableCodeObject>> ResultBlock { get; set; }

		// @property (assign, nonatomic) AVCaptureAutoFocusRangeRestriction preferredAutoFocusRangeRestriction;
		[Export ("preferredAutoFocusRangeRestriction", ArgumentSemantic.Assign)]
		AVCaptureAutoFocusRangeRestriction PreferredAutoFocusRangeRestriction { get; set; }

		// -(instancetype)initWithPreviewView:(UIView *)previewView;
		[Export ("initWithPreviewView:")]
		IntPtr Constructor (UIView previewView);

		// -(instancetype)initWithMetadataObjectTypes:(NSArray<NSString *> *)metaDataObjectTypes previewView:(UIView *)previewView;
		[Export ("initWithMetadataObjectTypes:previewView:")]
		IntPtr Constructor (string[] metaDataObjectTypes, UIView previewView);

		// +(BOOL)cameraIsPresent;
		[Static]
		[Export ("cameraIsPresent")]
		bool CameraIsPresent { get; }

		// -(BOOL)hasOppositeCamera;
		[Export ("hasOppositeCamera")]
		bool HasOppositeCamera { get; }

		// +(BOOL)scanningIsProhibited;
		[Static]
		[Export ("scanningIsProhibited")]
		bool ScanningIsProhibited { get; }

		// +(void)requestCameraPermissionWithSuccess:(void (^)(BOOL))successBlock;
		[Static]
		[Export ("requestCameraPermissionWithSuccess:")]
		void RequestCameraPermissionWithSuccess (Action<bool> successBlock);

		// -(BOOL)startScanningWithError:(NSError **)error;
		[Export ("startScanningWithError:")]
		bool StartScanningWithError (out NSError error);

		// -(BOOL)startScanningWithResultBlock:(void (^)(NSArray<AVMetadataMachineReadableCodeObject *> *))resultBlock error:(NSError **)error;
		[Export ("startScanningWithResultBlock:error:")]
		bool StartScanningWithResultBlock (Action<NSArray<AVMetadataMachineReadableCodeObject>> resultBlock, out NSError error);

		// -(BOOL)startScanningWithCamera:(MTBCamera)camera resultBlock:(void (^)(NSArray<AVMetadataMachineReadableCodeObject *> *))resultBlock error:(NSError **)error;
		[Export ("startScanningWithCamera:resultBlock:error:")]
		bool StartScanningWithCamera (MTBCamera camera, Action<NSArray<AVMetadataMachineReadableCodeObject>> resultBlock, out NSError error);

		// -(void)stopScanning;
		[Export ("stopScanning")]
		void StopScanning ();

		// -(BOOL)isScanning;
		[Export ("isScanning")]
		bool IsScanning { get; }

		// -(void)flipCamera;
		[Export ("flipCamera")]
		void FlipCamera ();

		// -(void)setCamera:(MTBCamera)camera __attribute__((availability(ios, introduced=2.0, deprecated=2.0)));
		[Introduced (PlatformName.iOS, 2, 0, message: "Use setCamera:error: instead")]
		[Deprecated (PlatformName.iOS, 2, 0, message: "Use setCamera:error: instead")]
		[Export ("setCamera:")]
		void SetCamera (MTBCamera camera);

		// -(BOOL)setCamera:(MTBCamera)camera error:(NSError **)error;
		[Export ("setCamera:error:")]
		bool SetCamera (MTBCamera camera, out NSError error);

		// -(BOOL)flipCameraWithError:(NSError **)error;
		[Export ("flipCameraWithError:")]
		bool FlipCameraWithError (out NSError error);

		// -(BOOL)hasTorch;
		[Export ("hasTorch")]
		bool HasTorch { get; }

		// -(void)toggleTorch;
		[Export ("toggleTorch")]
		void ToggleTorch ();

		// -(BOOL)setTorchMode:(MTBTorchMode)torchMode error:(NSError **)error;
		[Export ("setTorchMode:error:")]
		bool SetTorchMode (MTBTorchMode torchMode, out NSError error);

		// -(void)freezeCapture;
		[Export ("freezeCapture")]
		void FreezeCapture ();

		// -(void)unfreezeCapture;
		[Export ("unfreezeCapture")]
		void UnfreezeCapture ();

		// -(void)captureStillImage:(void (^)(UIImage *, NSError *))captureBlock;
		[Export ("captureStillImage:")]
		void CaptureStillImage (Action<UIImage, NSError> captureBlock);

		// -(BOOL)isCapturingStillImage;
		[Export ("isCapturingStillImage")]
		bool IsCapturingStillImage { get; }
	}
}
