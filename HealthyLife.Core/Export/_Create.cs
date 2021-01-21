using System.IO;
using HuajiTech.UnmanagedExports;

namespace XQColorful.Core.Export
{
    public class _Create
    {
        [DllExport]
        public static string XQ_Create(string frameworkversion) => CreateMain();

        public static string CreateMain()
        {
            //解析Assembly

            //Assembly ass = Assembly.GetExecutingAssembly();

            //var plugin = ass.GetCustomAttribute<XQPluginAttribute>();

            //PluginInitializer.Init(ass);

            //这边会进行

            //对插件信息的处理并返回JSON
            var info = PluginMain.Info();
            _Main.MainXQAPI.SetAppInfo(PluginMain.Info());

            _Main.MainXQAPI.AppDirectory = Directory.GetCurrentDirectory() + "\\Config" + "\\" + info.name + "\\";

            if (!Directory.Exists(_Main.MainXQAPI.AppDirectory))
                Directory.CreateDirectory(_Main.MainXQAPI.AppDirectory);

            PluginMain.RegEvent();

            return info.ToJson();
        }
    }
}