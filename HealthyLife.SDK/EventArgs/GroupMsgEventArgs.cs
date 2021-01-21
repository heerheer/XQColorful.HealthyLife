using XQColorful.SDK.Models;

namespace XQColorful.SDK.EventArgs
{
    public class GroupMsgEventArgs : XQEventArgs
    {
        public GroupMsgEventArgs(XQAPI api, OriginArgs args) : base(api, args)
        {
        }

        public GroupMsgEventArgs(XQEventArgs ea) : base(ea.XQAPI, ea.originArgs)
        {
        }

        /// <summary>
        /// 来自群
        /// </summary>
        public string FromGroup => originArgs.from;

        /// <summary>
        /// 来自QQ
        /// </summary>
        public string FromQQ => originArgs.fromQQ;

        /// <summary>
        /// 消息
        /// </summary>
        public string Message => originArgs.content;

        public void SendMsg(string msg) => this.XQAPI.SendGroupMessage(RobotQQ, FromGroup, msg);
    }
}