using MvvmCross.ViewModels;
using Test.Core.ViewModels;

namespace Test.Core
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            base.Initialize();

            RegisterAppStart<FirstViewModel>();
        }
    }
}
