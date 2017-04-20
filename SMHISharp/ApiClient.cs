﻿using Piksel.SMHISharp.Structures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using Newtonsoft.Json;
using System.Globalization;

namespace Piksel.SMHISharp
{
    public class ApiClient
    {
        const string Version = "1.0";
        public string EntryObs { get; set; } = "http://opendata-download-metobs.smhi.se/api";
        public string EntryAnl { get; set; } = "http://opendata-download-metanalys.smhi.se/api";

        static IFormatProvider _floatFormat = new NumberFormatInfo() { NumberDecimalSeparator = ".", NumberDecimalDigits = 4 };

        public Dictionary<string, Resource> _resources;
        private JsonSerializerSettings _settings;

        public ApiClient()
        {
            _settings = new JsonSerializerSettings();
            _settings.Converters.Add(new IntDateConverter());
        }

        public async void GetResources(Action<Resource[]> callback, bool refresh = false)
        {
            using (var wc = new WebClient())
            {
                var uri = new Uri($"{EntryObs}/version/{Version}.json");
                var result = await wc.DownloadDataTaskAsync(uri);
                var version = await JsonConvert.DeserializeObjectAsync<VersionResult>(Encoding.UTF8.GetString(result), _settings);
                callback(version.Resources);
            }
        }

        public async void GetStations(string parameter, Action<Station[]> callback)
        {
            using (var wc = new WebClient())
            {
                var uri = new Uri($"{EntryObs}/version/{Version}/parameter/{parameter}.json");
                var result = await wc.DownloadDataTaskAsync(uri);
                var param = await JsonConvert.DeserializeObjectAsync<ParameterResult>(Encoding.UTF8.GetString(result), _settings);
                callback(param.Stations);
            }
        }

        public async void GetPeriods(string parameter, string station, Action<PeriodResult[]> callback)
        {
            using (var wc = new WebClient())
            {
                var uri = new Uri($"{EntryObs}/version/{Version}/parameter/{parameter}/station/{station}.json");
                var result = await wc.DownloadDataTaskAsync(uri);
                var stat = await JsonConvert.DeserializeObjectAsync<StationResult>(Encoding.UTF8.GetString(result), _settings);
                callback(stat.Periods);
            }
        }


        public async void GetData(string parameter, string station, string period, Action<DataPoint[], Exception> callback)
        {
            using (var wc = new WebClient())
            {
                var uri = new Uri($"{EntryObs}/version/{Version}/parameter/{parameter}/station/{station}/period/{period}/data.json");
                try
                {
                    var result = await wc.DownloadDataTaskAsync(uri);
                    var data = await JsonConvert.DeserializeObjectAsync<DataResult>(Encoding.UTF8.GetString(result), _settings);
                    callback(data.Values, null);
                }
                catch (Exception x)
                {
                    callback(null, x);
                }
            }
        }

        public async void GetAnalysis(double longitude, double latitude, Action<Analysis, Exception> callback)
        {
            var category = "mesan1g";
            using (var wc = new WebClient())
            {
                var lngFmt = longitude.ToString(_floatFormat);
                var latFmt = latitude.ToString(_floatFormat);
                var uri = new Uri($"{EntryAnl}/category/{category}/version/{Version}/geotype/point/lon/{lngFmt}/lat/{latFmt}/data.json");
                try
                {
                    var result = await wc.DownloadDataTaskAsync(uri);
                    var data = await JsonConvert.DeserializeObjectAsync<Analysis>(Encoding.UTF8.GetString(result), _settings);
                    callback(data, null);
                }
                catch (Exception x)
                {
                    callback(null, x);
                }
            }
        }
    }
}
