using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Piksel.SMHISharp.Structures
{
    public class Parameter: ResultBase
    {
        public string ValueType { get; set; }
        public object StationSet { get; set; }
        public Station[] Station { get; set; }
    }
}
