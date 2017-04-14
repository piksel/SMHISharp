using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Piksel.SMHISharp.Structures
{
    public class Station: ResultBase
    {
        public int Id { get; set; }
        public float Height { get; set; }
        public float Latitude { get; set; }
        public float Longitude { get; set; }
        public string Name { get; set; }
    }

    public class StationResult : ResultBase
    {
        public DateTimeOffset From { get; set; }
        public DateTimeOffset To { get; set; }

        [JsonProperty("Position")]
        public Position[] Positions { get; set; }

        [JsonProperty("Period")]
        public PeriodResult[] Periods { get; set; }
    }
}
