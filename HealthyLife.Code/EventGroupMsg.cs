using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XQColorful.SDK;
using XQColorful.SDK.EventArgs;
using XQColorful.SDK.Interface;
using XQColorful.SDK.Models;

namespace HealthyLife.Code
{
    public class EventGroupMsg : IPluginEvent
    {
        public XQEventType EventType => XQEventType.Group;

        public void Process(XQEventArgs _e)
        {
            //
            var e = new GroupMsgEventArgs(_e);

            if (e.Message == "我醒了")
            {
                if (DateTime.Now.Hour < 8)
                {
                    e.SendMsg(XQCode.At(e.FromQQ) + "你醒啦!");
                }

                if ( 8 <= DateTime.Now.Hour && DateTime.Now.Hour <= 10 )
                {
                    e.SendMsg(XQCode.At(e.FromQQ) + "快起床!");
                }
                if (DateTime.Now.Hour > 10)
                {
                    e.SendMsg(XQCode.At(e.FromQQ) +"懒虫!");

                }
            }
        }
    }
}
