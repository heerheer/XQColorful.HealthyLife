using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace XQColorful.SDK.Models
{
    public class AppInfo
    {
        public string name { get; set; }
        public string pver { get; set; }
        public string author { get; set; }
        public string desc { get; set; }
        public int sver => 3;


        public string ToJson()
        {
            return JsonConvert.SerializeObject(this);

        }
    }
}
