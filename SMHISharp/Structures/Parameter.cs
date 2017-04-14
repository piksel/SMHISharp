using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Piksel.SMHISharp.Structures
{
    public class Parameter
    {
        public string Name { get; set; }
        public string Unit { get; set; }
    }

    public class ParameterResult : ResultBase
    {
        public string ValueType { get; set; }
        public object StationSet { get; set; }

        [JsonProperty("Station")]
        public Station[] Stations { get; set; }
    }
}
