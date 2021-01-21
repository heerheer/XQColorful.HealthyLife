using XQColorful.SDK.EventArgs;
using XQColorful.SDK.Models;

namespace XQ.Net.SDK.EventArgs
{
    public class PrivateMsgEventArgs : XQEventArgs
    {
        public PrivateMsgEventArgs(XQAPI api, OriginArgs args) : base(api, args)
        {
        }

        /// <summary>
        /// 来自QQ
        /// </summary>
        public string FromQQ => originArgs.fromQQ;

        /// <summary>
        /// 消息
        /// </summary>
        public string Message => originArgs.content;

        public void SendMsg(string msg) => this.XQAPI.SendMsgEX(RobotQQ, 1, "", FromQQ, msg, 0, false);
    }
}