using Newtonsoft.Json;

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