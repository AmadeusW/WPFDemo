using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Collections.ObjectModel;

namespace AmadeusW.DemoApplication
{
    /// <summary>
    /// A class that provides various kinds of data and services for this demo
    /// </summary>
    internal class DummyDataProvider
    {
        public void LogIn(String connectionString)
        {
            Thread.Sleep(1000);
            return;
        }

        internal ObservableCollection<DemoObject> CreateDemoData(int howManyPieces)
        {
            var items = new List<DemoObject>();
            for (int i = 0; i < howManyPieces; i++)
            {
                items.Add(new DemoObject());
            }
            return new ObservableCollection<DemoObject>(items);
        }
    }
}
