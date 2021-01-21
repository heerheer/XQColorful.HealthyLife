using XQColorful.SDK.Models;

namespace XQColorful.SDK.EventArgs
{
    public class OriginArgs
    {
        public string robotQQ;
        public int eventType;
        public int extraType;
        public string from;
        public string fromQQ;
        public string targetQQ;
        public string content;
        public string index;
        public string msgid;
        public string udpmsg;
        public string unix;
        public int p;

        public OriginArgs(string robotQQ, int eventType, int extraType, string from, string fromQQ, string targetQQ, string content, string index, string msgid, string udpmsg, string unix, int p)
        {
            this.robotQQ = robotQQ;
            this.eventType = eventType;
            this.extraType = extraType;
            this.from = from;
            this.fromQQ = fromQQ;
            this.targetQQ = targetQQ;
            this.content = content;
            this.index = index;
            this.msgid = msgid;
            this.udpmsg = udpmsg;
            this.unix = unix;
            this.p = p;
        }
    }

    public class XQEventArgs
    {
        public XQEventArgs(XQAPI api, OriginArgs args)
        {
            XQAPI = api;
            originArgs = args;
        }

        /// <summary>
        /// 基本XQAPI
        /// </summary>
        public XQAPI XQAPI { get; set; }

        /// <summary>
        /// 收到事件的机器人QQ
        /// </summary>
        public string RobotQQ => originArgs.robotQQ;

        /// <summary>
        /// 主动触发事件的QQ
        /// </summary>
        public string EventQQ { get; set; }

        public OriginArgs originArgs;

        /// <summary>
        /// 是否处理并阻塞
        /// </summary>
        public bool Handler
        { get; set; } = false;//默认不阻塞
    }
}