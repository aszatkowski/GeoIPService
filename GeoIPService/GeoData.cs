// dodać NuGet 'Newtonsoft.Json' i dalej:
//
//    using GeoService;
//
//    var geoData = GeoData.FromJson(jsonString);


namespace GeoService
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class GeoData
    {
        [JsonProperty("Data", NullValueHandling = NullValueHandling.Ignore)]
        public Data Data { get; set; }
    }

    public partial class Data
    {
        [JsonProperty("City", NullValueHandling = NullValueHandling.Ignore)]
        public City City { get; set; }

        [JsonProperty("Continent", NullValueHandling = NullValueHandling.Ignore)]
        public Continent Continent { get; set; }

        [JsonProperty("Country", Required = Required.Always)]
        public Country Country { get; set; }

        [JsonProperty("Location", NullValueHandling = NullValueHandling.Ignore)]
        public Location Location { get; set; }

        [JsonProperty("Postal", NullValueHandling = NullValueHandling.Ignore)]
        public Postal Postal { get; set; }

        [JsonProperty("RegisteredCountry", NullValueHandling = NullValueHandling.Ignore)]
        public Country RegisteredCountry { get; set; }

        [JsonProperty("RepresentedCountry", NullValueHandling = NullValueHandling.Ignore)]
        public Country RepresentedCountry { get; set; }

        [JsonProperty("Subdivisions", NullValueHandling = NullValueHandling.Ignore)]
        public List<Country> Subdivisions { get; set; }

        [JsonProperty("Traits", NullValueHandling = NullValueHandling.Ignore)]
        public Traits Traits { get; set; }
    }

    public partial class City
    {
        [JsonProperty("GeoNameID", NullValueHandling = NullValueHandling.Ignore)]
        public long? GeoNameId { get; set; }

        [JsonProperty("Names", NullValueHandling = NullValueHandling.Ignore)]
        public Names Names { get; set; }
    }

    public partial class Names
    {
        [JsonProperty("zh-CN", NullValueHandling = NullValueHandling.Ignore)]
        public string ZhCn { get; set; }

        [JsonProperty("de", NullValueHandling = NullValueHandling.Ignore)]
        public string De { get; set; }

        [JsonProperty("en", NullValueHandling = NullValueHandling.Ignore)]
        public string En { get; set; }

        [JsonProperty("es", NullValueHandling = NullValueHandling.Ignore)]
        public string Es { get; set; }

        [JsonProperty("fr", NullValueHandling = NullValueHandling.Ignore)]
        public string Fr { get; set; }

        [JsonProperty("ja", NullValueHandling = NullValueHandling.Ignore)]
        public string Ja { get; set; }

        [JsonProperty("pt-BR", NullValueHandling = NullValueHandling.Ignore)]
        public string PtBr { get; set; }

        [JsonProperty("ru", NullValueHandling = NullValueHandling.Ignore)]
        public string Ru { get; set; }
    }

    public partial class Continent
    {
        [JsonProperty("Code", NullValueHandling = NullValueHandling.Ignore)]
        public string Code { get; set; }

        [JsonProperty("GeoNameID", NullValueHandling = NullValueHandling.Ignore)]
        public long? GeoNameId { get; set; }

        [JsonProperty("Names", NullValueHandling = NullValueHandling.Ignore)]
        public Names Names { get; set; }
    }

    public partial class Country
    {
        [JsonProperty("GeoNameID", NullValueHandling = NullValueHandling.Ignore)]
        public long? GeoNameId { get; set; }

        [JsonProperty("IsoCode", NullValueHandling = NullValueHandling.Ignore)]
        public string IsoCode { get; set; }

        [JsonProperty("Names")]
        public Names Names { get; set; }

        [JsonProperty("Type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }
    }

    public partial class Location
    {
        [JsonProperty("Latitude", NullValueHandling = NullValueHandling.Ignore)]
        public double? Latitude { get; set; }

        [JsonProperty("Longitude", NullValueHandling = NullValueHandling.Ignore)]
        public long? Longitude { get; set; }

        [JsonProperty("MetroCode", NullValueHandling = NullValueHandling.Ignore)]
        public long? MetroCode { get; set; }

        [JsonProperty("TimeZone", NullValueHandling = NullValueHandling.Ignore)]
        public string TimeZone { get; set; }
    }

    public partial class Postal
    {
        [JsonProperty("Code", NullValueHandling = NullValueHandling.Ignore)]
        public string Code { get; set; }
    }

    public partial class Traits
    {
        [JsonProperty("IsAnonymousProxy", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsAnonymousProxy { get; set; }

        [JsonProperty("IsSatelliteProvider", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsSatelliteProvider { get; set; }
    }

    public partial class GeoData
    {
        public static GeoData FromJson(string json) => JsonConvert.DeserializeObject<GeoData>(json, GeoService.Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this GeoData self) => JsonConvert.SerializeObject(self, GeoService.Converter.Settings);
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }
}
