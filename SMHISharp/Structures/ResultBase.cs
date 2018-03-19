using Newtonsoft.Json;
using System;
using System.Linq;

namespace Piksel.SMHISharp.Structures
{
    public abstract class ResultBase : ObjectBase
    {
        public DateTimeOffset Updated { get; set; }
        public string Title { get; set; }

        [JsonProperty("Link")]
        public Link[] Links { get; set; }

        public Link GetLink(string type) => Links.FirstOrDefault(l => l.Type == type);
    }
}