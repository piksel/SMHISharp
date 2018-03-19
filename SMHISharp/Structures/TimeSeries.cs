using System;
using System.Linq;

namespace Piksel.SMHISharp
{
    public class TimeSeries
    {
        public DateTime ValidTime { get; set; }
        public Parameter[] Parameters { get; set; }

        public class Parameter
        {
            public string name { get; set; }
            public string levelType { get; set; }
            public int level { get; set; }
            public string unit { get; set; }
            public float[] values { get; set; }
        }

        private float? GetParam(string parameter) => Parameters.FirstOrDefault(p => p.name == parameter)?.values.FirstOrDefault();

        private int? GetParamInt(string parameter)
        {
            var fp = GetParam(parameter);
            if (fp.HasValue)
                return (int)fp.Value;
            return null;
        }

        public float? AirTemperature => GetParam("t");
        public float? WetBulbTemperature => GetParam("tiw");
        public float? WindGust => GetParam("t");
        public int? WindDirection => GetParamInt("wd");
        public float? WindSpeed => GetParam("ws");
        public int? RelativeHumidity => GetParamInt("rh");
        public float? Precipitation1h => GetParam("prec1h");
        public float? Precipitation3h => GetParam("prec3h");
        public float? Precipitation12h => GetParam("prec12h");
        public float? Precipitation24h => GetParam("prec24h");
        public float? Snow1h => GetParam("frsn1h");
        public float? Snow3h => GetParam("frsn3h");
        public float? Snow12h => GetParam("frsn12h");
        public float? Snow24h => GetParam("frsn24h");
        public float? HorizontalVisibility => GetParam("vis");
        public float? AirPressure => GetParam("msl");

        public int? TotalCloudCover => GetParamInt("tcc");
        public int? LowLevelCloudCover => GetParamInt("lcc");
        public int? MediumLevelCloudCover => GetParamInt("mcc");
        public int? HighLevelCloudCover => GetParamInt("hcc");
        public int? SignificantClouds => GetParamInt("c_sigfr");
        public int? SigCloudBase => GetParamInt("cb_sig");
        public int? SigCloudTop => GetParamInt("ct_sig");

        public int? PrecipitationType => GetParamInt("prtype");
        public int? PrecipitationSort => GetParamInt("prsort");
        public int? PrecipitationFrozen => GetParamInt("spp");
        public int? WeatherSymbol => GetParamInt("Wsymb");

        /*
t	    C	    hl	    2	Air temperature	                    Decimal number, one decimal
tiw	    C	    hl	    2	Wet bulb temperature	            Decimal number, one decimal
gust	m/s	    hl	    10	Wind gust speed	                    Decimal number, one decimal
wd	    degree	hl	    10	Wind direction	                    Integer
ws	    m/s	    hl	    10	Wind speed	                        Decimal number, one decimal
r	    %	    hl	    2	Relative humidity	                Integer, 0-100
prec1h	mm	    hl	    0	Precipitation last hour	            Decimal number, one decimal
prec3h	mm	    hl	    0	Precipitation last three hours	    Decimal number, one decimal
prec12h	mm	    hl	    0	Precipitation last 12 hours	        Decimal number, one decimal
prec24h	mm	    hl	    0	Precipitation last 24 hours	        Decimal number, one decimal
frsn1h	cm	    hl	    0	Snow precipitation last hour	    Decimal number, one decimal
frsn3h	cm	    hl	    0	Snow precipitation last three hours	Decimal number, one decimal
frsn12h	cm	    hl	    0	Snow precipitation last 12 hours	Decimal number, one decimal
frsn24h	cm	    hl	    0	Snow precipitation last 24 hours	Decimal number, one decimal
vis	    km	    hl	    2	Horizontal visibility	            Decimal number, one decimal
msl	    hPa	    hmsl	0	Pressure reduced to medium sealevel	Integer
tcc	    octas	hl	    0	Total cloud cover	                Integer, 0-8
lcc	    octas	hl	    0	Low level cloud cover	            Integer, 0-8
mcc	    octas	hl	    0	Medium level cloud cover	        Integer, 0-8
hcc	    octas	hl	    0	High level cloud cover	            Integer, 0-8
c_sigfr	%	    hl	    0	Fraction of significant clouds	    Integer, 0-100
cb_sig	m	    hmsl	0	Cloud base of significant clouds	Integer
cb_sig	m	    hmsl	0	Cloud base of significant clouds	Integer
ct_sig	m	    hl	    0	Cloud top of significant clouds	    Integer
prtype	code	hl	    0	Type of precipitation	            Integer, 0-6
prsort	code	hl	    0	Sort of precipitation	            Integer, -9 or 1
spp	    %	    hl	    0	Frozen part of total precipitation.	Integer, -9 or 0-100
Wsymb	code	hl	    0	Weather Symbol	                    Integer, 1-15
         */
    }
}