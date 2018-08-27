using Android.App;
using Android.Widget;
using Android.OS;

namespace DemoAndroid
{
    [Activity(Label = "DemoAndroid", MainLauncher = true, Icon = "@mipmap/icon")]
    public class MainActivity : Activity
    {
        int count = 1;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // test
            PhotoView photoView = new PhotoView(container.Context);
        }
    }
}

