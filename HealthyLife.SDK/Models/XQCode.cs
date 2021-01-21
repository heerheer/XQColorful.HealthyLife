using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XQColorful.SDK.Models
{
    public class XQCode
    {
        public static string At(string qq, bool space = true)
        {
            return $"[@{qq}]{(space ? " " : "")}";
        }
    }
}
