using Piksel.SMHISharp.Structures;
using System;

namespace Piksel.SMHISharp
{
    public static class Utilities
    {
        public static Station GetClosestStation(this Station[] stations, double longitude, double latitude, TimeSpan? maxAge = null)
        {
            Station bestStation = null;
            double bestDelta = double.MaxValue;
            double delta = double.MaxValue;

            foreach (var station in stations)
            {
                if (bestStation == null || (
                    (delta = (Math.Abs(longitude - station.Longitude) + Math.Abs(latitude - station.Latitude))) < bestDelta
                    && (!maxAge.HasValue || DateTimeOffset.Now - station.Updated < maxAge)))
                {
                    bestStation = station;
                    bestDelta = delta;
                }
            }

            return bestStation;
        }
    }
}