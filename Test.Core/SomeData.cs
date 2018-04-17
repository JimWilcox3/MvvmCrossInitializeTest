using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Test.Core
{

    public class ColorList
    {
        public ColorList()
        {
            Colors = new List<string>();
        }

        public List<string> Colors { get; set; }
    }

    public class SomeData
    {
        public static Task<ColorList> GetColors()
        {
            var tcs = new TaskCompletionSource<ColorList>();

            Task.Factory.StartNew(() =>
            {
                Thread.Sleep(1000);

                ColorList ret = new ColorList();

                ret.Colors.Add("Red");
                ret.Colors.Add("Orange");
                ret.Colors.Add("Yellow");
                ret.Colors.Add("Green");
                ret.Colors.Add("Blue");
                ret.Colors.Add("Purple");

                tcs.SetResult(ret);
            });

            return tcs.Task;
        }


    }
}