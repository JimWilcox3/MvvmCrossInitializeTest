
using Android.App;
using Android.OS;
using MvvmCross.Platforms.Android.Views;
using Test.Core.ViewModels;

namespace Test.Droid.Views
{
    [Activity(Label = "FirstView")]
    public class FirstView : MvxActivity<FirstViewModel>
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.FirstView);
        }
    }
}