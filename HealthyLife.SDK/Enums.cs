namespace XQColorful.SDK
{
    public enum XQEventType
    {
        None = -1,
        OnlineTmp = 0,

        /// <summary>
        /// 好友私聊消息
        /// </summary>
        Friend = 1,

        /// <summary>
        /// 群消息
        /// </summary>
        Group = 2,

        /// <summary>
        /// 来自群的临时消息
        /// </summary>
        GroupTmp = 4,

        /// <summary>
        /// 来自好友验证的对话消息
        /// </summary>
        AddFriendReply = 7,

        /// <summary>
        /// 收到财付通转账
        /// </summary>
        Money = 6,

        /// <summary>
        /// 某人请求加为好友
        /// </summary>
        AddFriend = 101,

        /// <summary>
        /// 被删除好友
        /// </summary>
        BeRemovedFriend = 104,

        /// <summary>
        /// 好友接收离线文件
        /// </summary>
        ReceivedFile = 105,

        /// <summary>
        /// 说说被评论
        /// </summary>
        BeCommented = 107,

        /// <summary>
        /// 某人离开了群聊
        /// </summary>
        LeaveGroup = 201,

        BanSpeak = 203,
        UnBanSpeak = 204,

        AllBanSpeak = 205,
        AllUnBanSpeak = 206,

        /// <summary>
        /// 某人被批准加入群
        /// </summary>
        AllowedToGroup = 212,

        /// <summary>
        /// 某人申请入群
        /// </summary>
        AddGroup = 213,

        /// <summary>
        /// 被邀请入群
        /// </summary>
        BeInvitedToGroup = 214,

        /// <summary>
        /// 某人被邀请入群
        /// </summary>
        SomeoneInvitedToGroup = 215,

        /// <summary>
        /// 某群被解散
        /// </summary>
        GroupDissolved = 216,

        /// <summary>
        /// 群名片变动
        /// </summary>
        GroupCardChanged = 217,

        /// <summary>
        /// 某人被邀请并且进入了群(100以内免审核)
        /// </summary>
        SomeoneHasBeenInvitedIntoGroup = 219,

        /// <summary>
        /// 群名称变动
        /// </summary>
        GroupNameChanged = 220,

        /// <summary>
        /// 被拒绝入群
        /// </summary>
        BeRefusedGroup = 221,

        QQLogin = 1101,

        /// <summary>
        /// 插件被启用
        /// </summary>
        PluginEnable = 12000,

        PluginClicked = 12003,
    }

    public enum ResponseType
    {
        PASS = 10,
        REFUSE = 20,
        IGNORE = 30
    }
}