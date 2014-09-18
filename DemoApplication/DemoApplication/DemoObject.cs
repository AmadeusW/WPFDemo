using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmadeusW.DemoApplication
{
    internal class DemoObject
    {
        static Random random = new Random();

        public String Title
        {
            get
            {
                return "Sample text " + random.NextDouble().ToString();
            }
        }

        public DateTime CreatedDate
        {
            get
            {
                // Some time between now and 5 days ago.
                return DateTime.Now - TimeSpan.FromMinutes(random.NextDouble() * 60 * 24 * 5);
            }
        }

        public String Variable1
        {
            get
            {
                return "Sample text 1";
            }
        }

        public String Variable2
        {
            get
            {
                return "Sample text 2";
            }
        }
    }
}
