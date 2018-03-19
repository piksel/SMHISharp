using Newtonsoft.Json;

namespace Piksel.SMHISharp.Structures
{
    public class Data : ObjectBase
    {
    }

    internal class DataResult : ResultBase
    {
        private Parameter Parameter { get; set; }
        private Station Station { get; set; }
        private PeriodResult Period { get; set; }
        private Position Position { get; set; }

        [JsonProperty(PropertyName = "Value")]
        public DataPoint[] Values { get; set; }
    }
}