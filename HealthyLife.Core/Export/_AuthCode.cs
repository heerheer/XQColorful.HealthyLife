using HuajiTech.UnmanagedExports;

namespace XQColorful.Core.Export
{
    public class _AuthCode
    {
        [DllExport]
        public static void XQ_AuthId(short id, int IMAddr) => AuthCode(id, IMAddr);

        [DllExport]
        public static void XQ_AutoId(short id, int IMAddr) => AuthCode(id, IMAddr);

        public static void AuthCode(short id, int IMAddr)
        {
            _Main.MainXQAPI.SetAuthID(id, IMAddr);
        }
    }
}