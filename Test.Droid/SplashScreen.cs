using Android.App;
using MvvmCross.Platforms.Android.Views;

namespace Test.Droid
{
    [Activity(
		Label = "DroidTest"
		, MainLauncher = true
		, Icon = "@drawable/icon"
		, Theme = "@style/Theme.Splash"
		, NoHistory = true)]
    public class SplashScreen : MvxSplashScreenActivity
    {
        public SplashScreen()
            : base(Resource.Layout.SplashScreen)
        {
        }
    }
}