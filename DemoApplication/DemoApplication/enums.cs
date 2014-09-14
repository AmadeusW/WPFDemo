using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmadeusW.DemoApplication
{
    /// <summary>
    /// Controls which screen is visible
    /// </summary>
    internal enum ApplicationSteps
    {
        LogIn,
        ChooseView,
        DemoData1,
        DemoData2
    }

    /// <summary>
    /// Controls the appearance of the message
    /// </summary>
    internal enum MessageStatus
    {
        Closed,
        InfoMessage,
        ErrorMessage
    }
}
