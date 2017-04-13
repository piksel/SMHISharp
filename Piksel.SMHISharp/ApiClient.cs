using Piksel.SMHISharp.Structures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;

namespace Piksel.SMHISharp
{
    public class ApiClient
    {
        const string Version = "1.0";
        public string EntryPoint { get; set; } = "http://opendata-download-metobs.smhi.se/api";

        public Dictionary<string, Resource> _resources;

        public async void GetResources(Action<Dictionary<string, Resource>> callback, bool refresh = false)
        {
            using(var wc = new WebClient())
            {

            }
        }
    }
}
