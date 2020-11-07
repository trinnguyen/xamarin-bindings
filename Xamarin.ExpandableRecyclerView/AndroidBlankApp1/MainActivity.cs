﻿using Android.App;
using Android.OS;
using AndroidX.AppCompat.App;
using Com.Thoughtbot.Expandablerecyclerview.Viewholders;

namespace AndroidBlankApp1
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);
            ChildViewHolder v;
        }
    }
}