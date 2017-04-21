using Piksel.SMHISharp.Structures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using Newtonsoft.Json;
using System.Globalization;
using System.Threading.Tasks;

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

        #region Legacy wrappers

        public async void GetResources(Action<Resource[]> callback, bool refresh = false)
        {
            callback(await GetResources(refresh));
        }

        public async void GetStations(string parameter, Action<Station[]> callback)
        {
            callback(await GetStations(parameter));
        }

        public async void GetPeriods(string parameter, string station, Action<PeriodResult[]> callback)
        {
            callback(await GetPeriods(parameter, station));
        }

        public async void GetAnalysis(double longitude, double latitude, Action<Analysis, Exception> callback)
        {
            try
            {
                callback(await GetAnalysis(longitude, latitude), null);
            }
            catch (Exception x)
            {
                callback(null, x);
            }

        }

        public async void GetData(string parameter, string station, string period, Action<DataPoint[], Exception> callback)
        {
            try
            {
                callback(await GetData(parameter, station, period), null);
            }
            catch (Exception x)
            {
                callback(null, x);
            }
        }

        #endregion

        public async Task<Resource[]> GetResources(bool refresh = false)
        {
            using (var wc = new WebClient())
            {
                var uri = new Uri($"{EntryObs}/version/{Version}.json");
                var result = await wc.DownloadDataTaskAsync(uri);
                var version = await JsonConvert.DeserializeObjectAsync<VersionResult>(Encoding.UTF8.GetString(result), _settings);
                return version.Resources;
            }
        }


        public async Task<Station[]> GetStations(string parameter)
        {
            using (var wc = new WebClient())
            {
                var uri = new Uri($"{EntryObs}/version/{Version}/parameter/{parameter}.json");
                var result = await wc.DownloadDataTaskAsync(uri);
                var param = await JsonConvert.DeserializeObjectAsync<ParameterResult>(Encoding.UTF8.GetString(result), _settings);
                return param.Stations;
            }
        }


        public async Task<PeriodResult[]> GetPeriods(string parameter, string station)
        {
            using (var wc = new WebClient())
            {
                var uri = new Uri($"{EntryObs}/version/{Version}/parameter/{parameter}/station/{station}.json");
                var result = await wc.DownloadDataTaskAsync(uri);
                var stat = await JsonConvert.DeserializeObjectAsync<StationResult>(Encoding.UTF8.GetString(result), _settings);
                return stat.Periods;
            }
        }



        public async Task<DataPoint[]> GetData(string parameter, string station, string period)
        {
            using (var wc = new WebClient())
            {
                var uri = new Uri($"{EntryObs}/version/{Version}/parameter/{parameter}/station/{station}/period/{period}/data.json");
                var result = await wc.DownloadDataTaskAsync(uri);
                var data = await JsonConvert.DeserializeObjectAsync<DataResult>(Encoding.UTF8.GetString(result), _settings);
                return data.Values;
            }
        }


        public async Task<Analysis> GetAnalysis(double longitude, double latitude)
        {
            var category = "mesan1g";
            using (var wc = new WebClient())
            {
                var lngFmt = longitude.ToString(_floatFormat);
                var latFmt = latitude.ToString(_floatFormat);
                var uri = new Uri($"{EntryAnl}/category/{category}/version/{Version}/geotype/point/lon/{lngFmt}/lat/{latFmt}/data.json");

                var result = await wc.DownloadDataTaskAsync(uri);
                return await JsonConvert.DeserializeObjectAsync<Analysis>(Encoding.UTF8.GetString(result), _settings);

            }
        }

    }
}
