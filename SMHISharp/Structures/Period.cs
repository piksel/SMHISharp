using System;

namespace Piksel.SMHISharp.Structures
{
    public class Period : ObjectBase
    {
        public DateTimeOffset From { get; set; }
        public DateTimeOffset To { get; set; }
        public string Sampling { get; set; }
    }

    public class PeriodResult : ResultBase
    {
    }
}