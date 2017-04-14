using Newtonsoft.Json;
using System;

namespace Piksel.SMHISharp.Structures
{
    public class VersionResult: ResultBase
    {
        [JsonProperty("Resource")]
        public Resource[] Resources { get; set; }
        
    }
}