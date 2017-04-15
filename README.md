# SMHISharp
Library for querying SMHI Open Data API for .NET

![Example application](https://i.imgur.com/h3dUvYR.png)

## Installation

Install from nuget:  
```Install-Package SMHISharp```

## Usage

```cs
var client = new Piksel.SMHISharp.ApiClient();

// Print all resources
client.GetResources(resources => {
  Console.WriteLinte("Resources:");
  foreach(var resource in resources){
    Console.WriteLine("  {resource.Key}: {resource.Title}");
  }
});

// Print all stations for resource 1
var resourceKey = "1"; // momentanvärde, 1 gång/tim
client.GetStations(resourceKey, stations => {
  Console.WriteLinte("Stations:");
  foreach(var station in stations){
    Console.WriteLine("  {station.Key}: {station.Title}");
  }
});

client.GetPeriods(resourceKey, stationKey, periods => {
  ...
});

// Note: GetData can fail
client.GetData(resourceKey, stationKey, periodKey, (dataPoints, exception) => {
  ...
});
```
