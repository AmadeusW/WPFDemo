using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

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
    }
}
