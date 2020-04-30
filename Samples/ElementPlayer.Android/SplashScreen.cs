using System.Collections.Generic;
using System.Reflection;
using Android.App;
using Android.Content.PM;
using AndroidX.AppCompat.App;
using MvvmCross.DroidX.AppCompat;
using MvvmCross.Platforms.Android.Presenters;

namespace ElementPlayer.Android
{
    [Activity(Label = "@string/ApplicationName",
        MainLauncher = true,
        NoHistory = true,
        Icon = "@drawable/baseline_play_circle_filled_24",
        RoundIcon = "@drawable/baseline_play_circle_filled_24",
        Theme = "@style/AppTheme.Splash",
        LaunchMode = LaunchMode.SingleTop,
        ConfigurationChanges = ConfigChanges.Orientation | ConfigChanges.ScreenSize)]
    public class SplashScreen : MvxSplashScreenAppCompatActivity<Setup, Core.App>
    {
        public SplashScreen()
             : base(Resource.Layout.splash_screen)
        {
        }
    }

    public class Setup : MvxAppCompatSetup<Core.App>
    {
        protected override IMvxAndroidViewPresenter CreateViewPresenter()
        {
            var presenter = new MyAndroidViewPresenter(AndroidViewAssemblies);
            return presenter;
        }
    }

    public class MyAndroidViewPresenter : MvxAndroidViewPresenter
    {
        public MyAndroidViewPresenter(IEnumerable<Assembly> androidViewAssemblies) : base(androidViewAssemblies)
        {
        }

        protected override AppCompatActivity CurrentActivity
        {
            get
            {
                var activity = base.CurrentActivity;
                return activity;
            }
        }
    }
}
