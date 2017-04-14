using Newtonsoft.Json;

namespace Piksel.SMHISharp.Structures
{
    public class Data: ObjectBase
    {

    }

    internal class DataResult: ResultBase
    {
        Parameter Parameter { get; set; }
        Station Station { get; set; }
        PeriodResult Period { get; set; }
        Position Position { get; set; }

        [JsonProperty(PropertyName = "Value")]
        public DataPoint[] Values { get; set; }
    }
}