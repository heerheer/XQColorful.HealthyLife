using System;
using System.Linq;
using HealthyLife.Code;
using XQColorful.Core.Export;
using XQColorful.SDK.Interface;
using XQColorful.SDK.Models;

namespace XQColorful.Core
{
    public class PluginMain
    {
        public static AppInfo Info() => new AppInfo()
        {
            name = "HealthyLife",
            author = "Heer",
            desc = "健康生活",
            pver = "1.0.0"
        };

        public static void RegEvent()
        {
            new Class1();// 请在这里随意使用Code的一个代码以保证add ref的Code程序集能够被正确加载
            //new Class2(); UI项目同理

            var ass = AppDomain.CurrentDomain.GetAssemblies();
            foreach (var item in ass)
            {
                var types = item.GetTypes().ToList().Where(s => s != typeof(IPluginEvent) && typeof(IPluginEvent).IsAssignableFrom(s));
                types.ToList().ForEach(
                    t => _Event.Events.Add((IPluginEvent)Activator.CreateInstance(t)));
            }
        }
    }
}