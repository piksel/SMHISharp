using System;

namespace Piksel.SMHISharp.Structures
{
    public class Position
    {
        public DateTimeOffset From { get; set; }
        public DateTimeOffset To { get; set; }
        public float Height { get; set; }
        public float Latitude { get; set; }
        public float Longitude { get; set; }
    }
}