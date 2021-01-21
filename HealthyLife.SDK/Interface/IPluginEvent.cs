using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XQColorful.SDK.EventArgs;

namespace XQColorful.SDK.Interface
{
    public interface IPluginEvent
    {
        XQEventType EventType { get ; }

        void Process(XQEventArgs e);
    }
}
