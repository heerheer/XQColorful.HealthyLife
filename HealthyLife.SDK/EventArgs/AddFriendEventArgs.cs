using XQColorful.SDK.Models;

namespace XQColorful.SDK.EventArgs
{
    public class AddFriendEventArgs : XQEventArgs
    {
        public void Pass()
        {
            this.XQAPI.HandleFriendEvent(this.RobotQQ, originArgs.fromQQ, (int)ResponseType.PASS, "");
        }

        public void Refuse(string msg = "")
        {
            XQAPI.HandleFriendEvent(this.RobotQQ, originArgs.fromQQ, (int)ResponseType.REFUSE, msg);
        }

        public void Ignore()
        {
            XQAPI.HandleFriendEvent(this.RobotQQ, originArgs.fromQQ, (int)ResponseType.IGNORE, "");
        }

        public AddFriendEventArgs(XQAPI api, OriginArgs args) : base(api, args)
        {
        }

        public AddFriendEventArgs(XQEventArgs ae) : base(ae.XQAPI, ae.originArgs)
        {
        }
    }
}