﻿using System;
using System.Linq;

namespace Piksel.SMHISharp.Structures
{
    public class Resource
    {
        public GeoBox GeoBox { get; set; }
        public string Key { get; set; }
        public DateTimeOffset Updated { get; set; }
        public string Title { get; set; }
        public string Summary { get; set; }
        public Link[] Link { get; set; }

        public Link GetLink(string type) => Link.FirstOrDefault(l => l.Type == type);
        
        
    }
}