using Android;
using Android.App;
using Android.Content.PM;
using Android.OS;
using Android.Util;
using AndroidX.Core.App;
using AndroidX.Core.Content;
using Firebase.CodeScanner;
using Result = Google.ZXing.Result;

namespace DemoCodeScanner
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme.NoActionBar", MainLauncher = true)]
    public class MainActivity : Activity, IDecodeCallback
    {
        private CodeScannerView _scannerView;
        private CodeScanner _codeScanner;
        private const string TAG = "test-scanner";

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_main);
            
            _scannerView = FindViewById<CodeScannerView>(Resource.Id.scanner_view);
            _codeScanner = new CodeScanner(this, _scannerView)
            {
                ScanMode = ScanMode.Continuous, 
                AutoFocusEnabled = true,
                AutoFocusMode = AutoFocusMode.Continuous
            };
        }

        protected override void OnResume()
        {
            base.OnResume();
            
            // check permission
            Execute();
        }

        private void Execute()
        {
            
            if (ContextCompat.CheckSelfPermission(this, Permission) == Android.Content.PM.Permission.Granted)
            {
                StartPreview();
                return;
            }

            if (ActivityCompat.ShouldShowRequestPermissionRationale(this, Permission))
            {
                Log.Info(TAG, "Displaying camera permission rationale to provide additional context.");
                InternalRequest();
                return;
            }

            InternalRequest();
        }

        private void InternalRequest()
        {
            ActivityCompat.RequestPermissions(this, new []{Permission}, CameraRequestCode);
        }

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, Permission[] grantResults)
        {
            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
            if (requestCode == CameraRequestCode)
            {
                if (permissions.Length > 0 && grantResults.Length > 0 && permissions[0].Equals(Permission) &&
                    grantResults[0] == Android.Content.PM.Permission.Granted)
                {
                    StartPreview();
                }
            }
        }

        private const string Permission = Manifest.Permission.Camera;
        private const int CameraRequestCode = 1001;

        private void StartPreview()
        {
            _codeScanner.DecodeCallback = this;
            _codeScanner.StartPreview();
        }

        protected override void OnPause()
        {
            _codeScanner.StopPreview();
            _codeScanner.DecodeCallback = null;
            base.OnPause();
        }

        public void OnDecoded(Result p0)
        {
            Log.Debug(TAG, "barcode result: " + p0.Text);
        }
    }
}
