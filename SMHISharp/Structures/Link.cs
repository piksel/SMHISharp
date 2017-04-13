namespace Piksel.SMHISharp.Structures
{
    public class Link
    {
        public string Rel { get; set; }
        public string Type { get; set; }
        public string Href { get; set; }

        public const string JsonType = "application/json";
        public const string XmlType = "application/xml";
        public const string AtomType = "application/atom+xml";
        public const string ISO19139Type = "application/vnd.iso.19139+xml";

    }
}