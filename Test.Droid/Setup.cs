using Android.Content;
using MvvmCross.Platforms.Android.Core;
using MvvmCross.ViewModels;
using Test.Core;

namespace Test.Droid
{
    public class Setup : MvxAndroidSetup<App>
    {
        //public Setup(Context applicationContext) : base(applicationContext)
        //{
        //}

        protected override IMvxApplication CreateApp()
        {
//            App.sdkHandler = new SDKHandler(ApplicationContext);
            return new App();
        }

        //protected override IMvxTrace CreateDebugTrace()
        //{
        //    return new DebugTrace();
        //}
    }
}