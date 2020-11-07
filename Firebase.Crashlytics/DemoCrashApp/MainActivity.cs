using System;
using Android.App;
using Android.OS;
using Android.Util;
using Android.Widget;
using AndroidX.AppCompat.App;
using Fragment = AndroidX.Fragment.App.Fragment;

namespace DemoCrashApp
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme.NoActionBar", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        private Button _btnForceCrash;
        private Button _btnTestUser;
        private Button _btnTestLog;
        private Button _btnTestException;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_main);

            _btnForceCrash = FindViewById<Button>(Resource.Id.btn_force_crash);
            _btnTestUser = FindViewById<Button>(Resource.Id.btn_test_user);
            _btnTestLog = FindViewById<Button>(Resource.Id.btn_test_log);
            _btnTestException = FindViewById<Button>(Resource.Id.btn_test_exception);
        }

        protected override void OnStart()
        {
            base.OnStart();
            _btnForceCrash.Click += OnForceClicked;
            _btnTestUser.Click += OnTestUserClicked;
            _btnTestLog.Click += OnTestLogClicked;
            _btnTestException.Click += OnTestExceptionClicked;
        }

        protected override void OnStop()
        {
            base.OnStop();
            _btnForceCrash.Click -= OnForceClicked;
            _btnTestUser.Click -= OnTestUserClicked;
            _btnTestLog.Click -= OnTestLogClicked;
            _btnTestException.Click -= OnTestExceptionClicked;
        }

        private void OnForceClicked(object sender, EventArgs e)
        {
            // exepct null exception
            var tmp = ((Fragment)null).GetType();
        }

        private void OnTestUserClicked(object sender, EventArgs e)
        {
            Firebase.Crashlytics.FirebaseCrashlytics.Instance.SetUserId("custom-user-id");
            Firebase.Crashlytics.FirebaseCrashlytics.Instance.SetCustomKey("key1", "value2");
        }

        private int _count = 1;
        private void OnTestLogClicked(object sender, EventArgs e)
        {
            Firebase.Crashlytics.FirebaseCrashlytics.Instance.Log($"sample log {_count++}");
        }

        private int _countExp = 1;
        private void OnTestExceptionClicked(object sender, EventArgs e)
        {
            Firebase.Crashlytics.FirebaseCrashlytics.Instance.RecordException(new Java.Lang.Exception($"sample example: {_countExp}"));
        }
    }
}
