using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using XQColorful.SDK;
using XQColorful.SDK.Interface;
using HealthyLife.Code;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //new EventGroupMsg();
            var ass = AppDomain.CurrentDomain.GetAssemblies();
            ass.ToList().ForEach(c => Console.WriteLine(c.FullName));
            //new XQColorful.SDK.Models.AppInfo();

            foreach (var item in ass)
            {
                Console.WriteLine(item.FullName);
                var types = item.GetTypes().ToList().Where(s =>  s!= typeof(IPluginEvent) && typeof(IPluginEvent).IsAssignableFrom(s));
                Console.WriteLine(types.Count());
            }
            Console.ReadKey();

        }
    }
}
