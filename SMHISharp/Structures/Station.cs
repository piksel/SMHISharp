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
}
