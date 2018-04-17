using MvvmCross.ViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Test.Core.ViewModels
{
    public class FirstViewModel : MvxViewModel
    {
        public FirstViewModel()
        {
            //Task.Run(async () =>
            //{
            //    ColorList = await SomeData.GetColors();
            //});
        }

        public async override Task Initialize()
        {
            await base.Initialize();
            ColorList = await SomeData.GetColors();
        }

        private ColorList _ColorList;
        public ColorList ColorList
        {
            get
            {
                return _ColorList;
            }
            set
            {
                _ColorList = value;
                RaisePropertyChanged(() => ColorList);
                RaisePropertyChanged(() => Colors);
            }
        }

        public List<string> Colors
        {
            get
            {
                if (ColorList == null)
                    return new List<string>();
                else
                    return ColorList.Colors;
            }
        }


        private string _FirstName;
        public string FirstName
        {
            get
            {
                return _FirstName;
            }
            set
            {
                _FirstName = value;
                RaisePropertyChanged(() => FirstName);
                RaisePropertyChanged(() => FullName);
            }
        }

        private string _LastName;
        public string LastName
        {
            get
            {
                return _LastName;
            }
            set
            {
                _LastName = value;
                RaisePropertyChanged(() => LastName);
                RaisePropertyChanged(() => FullName);
            }
        }

        public string FullName
        {
            get
            {
                return _FirstName + " " + LastName;
            }
        }

    }
}
