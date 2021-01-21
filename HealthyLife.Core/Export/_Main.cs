using System.IO;
using XQColorful.SDK.Models;

namespace XQColorful.Core.Export
{
    internal class _Main
    {
        public static XQAPI MainXQAPI = new XQAPI();

        public static void Log(string log)
        {
            if (!Directory.Exists("XQNetLogs"))
            {
                Directory.CreateDirectory("XQNetLogs");
            }

            File.AppendAllText("XQNetLogs\\log.txt", log + "\n");
        }
    }
}