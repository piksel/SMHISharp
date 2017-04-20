using System;

namespace Piksel.SMHISharp
{
    public class Analysis
    {
        public DateTime ApprovedTime { get; set; }
        public DateTime ReferenceTime { get; set; }
        public Geometry Geometry { get; set; }
        public TimeSeries[] TimeSeries { get; set; }

    }
}