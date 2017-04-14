using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Piksel.SMHISharp.Structures
{
    public class DataPoint
    {
        public DateTimeOffset Date { get; set; }

        [JsonProperty("Value")]
        public string ValueRaw { get; set; }

        double _value;
        bool _valueSet;
        [JsonIgnore]
        public double? Value
        {
            get
            {
                if(_valueSet || double.TryParse(ValueRaw, out _value))
                {
                    _valueSet = true;
                    return _value;
                }
                else
                {
                    return null;
                }
            }
        }

        public string Quality { get; set; }
    }
}
