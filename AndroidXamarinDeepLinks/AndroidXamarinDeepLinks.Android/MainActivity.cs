using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.OS;

namespace AndroidXamarinDeepLinks.Droid
{
    [Activity(Label = "AndroidXamarinDeepLinks", Icon = "@mipmap/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize )]

    [IntentFilter(new[] { Android.Content.Intent.ActionView },
                  DataScheme = "https",
                  DataHost = "testdl.com",
                  DataPathPrefix = "/hello",
                  AutoVerify = true,
                  Categories = new[] { Android.Content.Intent.CategoryDefault, Android.Content.Intent.CategoryBrowsable })]
    [IntentFilter(new[] { Android.Content.Intent.ActionView },
                  DataScheme = "http",
                  DataHost = "testdl.com",
                  AutoVerify = true,
                  DataPathPrefix = "/hello",
                  Categories = new[] { Android.Content.Intent.CategoryDefault, Android.Content.Intent.CategoryBrowsable })]

    [IntentFilter(new[] { Android.Content.Intent.ActionView },
                  DataScheme = "http",
                  DataHost = "testdl.com",
                  AutoVerify = true,
                  DataPathPrefix = "/app",
                  Categories = new[] { Android.Content.Intent.CategoryDefault, Android.Content.Intent.CategoryBrowsable })]
    [IntentFilter(new[] { Android.Content.Intent.ActionView },
                  DataScheme = "https",
                  DataHost = "testdl.com",
                  DataPathPrefix = "/app",                  
                  AutoVerify = true,
                  Categories = new[] { Android.Content.Intent.CategoryDefault, Android.Content.Intent.CategoryBrowsable })]


    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            global::Xamarin.Forms.Forms.Init(this, savedInstanceState);
            LoadApplication(new App());
        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}