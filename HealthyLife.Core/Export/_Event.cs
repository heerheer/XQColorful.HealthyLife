using System;
using System.Collections.Generic;
using HuajiTech.UnmanagedExports;
using XQColorful.SDK.EventArgs;
using XQColorful.SDK.Interface;

namespace XQColorful.Core.Export
{
    public class _Event
    {
        internal static List<IPluginEvent> Events = new List<IPluginEvent>();

        [DllExport]
        public static int
            XQ_Event(string robotQQ, int eventType, int extraType, string from, string fromQQ, string targetQQ, string content, string index, string msgid, string udpmsg, string unix, int p) => Event(robotQQ, eventType, extraType, from, fromQQ, targetQQ, content, index, msgid, udpmsg, unix, p);

        public static int Event(string robotQQ, int eventType, int extraType, string from, string fromQQ, string targetQQ, string content, string index, string msgid, string udpmsg, string unix, int p)
        {
            try
            {
                var oargs = new OriginArgs(robotQQ, eventType, extraType, from, fromQQ, targetQQ, content, index, msgid, udpmsg, unix, p);

                var maineventarg = new XQEventArgs(new SDK.Models.XQAPI() { RobotQQ = robotQQ }, oargs);

                Events.FindAll(e => (int)e.EventType == eventType)?.ForEach(eve =>
                {
                    eve.Process(maineventarg);
                });
                return 1;
            }
            catch (Exception ex)
            {
                _Main.Log(ex.ToString());

                return 1;
            }
        }

        [DllExport]
        public static int XQ_SetUp() => Menu();

        public static int Menu()
        {
            try
            {
            }
            catch (Exception ex)
            {
                _Main.Log(ex.ToString());
            }
            return 0;
        }
    }
}