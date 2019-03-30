using Microsoft.VisualStudio.TestTools.UnitTesting;
using GeoService;

namespace UnitTestGeoService
{
    [TestClass]
    public class UnitTestGeoService
    {
        [TestMethod]
        public void TestGetCountryFromJSON()
        {
            var jsonString = "{ \"Data\":{\"City\":{\"GeoNameID\":756135,\"Names\":{ \"zh-CN\":\"\u534E\u6C99\",\"de\":\"Warschau\",\"en\":\"Warsaw\",\"es\":\"Varsovia\",\"fr\":\"Varsovie\",\"ja\":\"\u30EF\u30EB\u30B7\u30E3\u30EF\",\"pt-BR\":\"Vars\u00F3via\",\"ru\":\"\u0412\u0430\u0440\u0448\u0430\u0432\u0430\"}},\"Continent\":{\"Code\":\"EU\",\"GeoNameID\":6255148,\"Names\":{ \"ru\":\"\u0415\u0432\u0440\u043E\u043F\u0430\",\"zh-CN\":\"\u6B27\u6D32\",\"de\":\"Europa\",\"en\":\"Europe\",\"es\":\"Europa\",\"fr\":\"Europe\",\"ja\":\"\u30E8\u30FC\u30ED\u30C3\u30D1\",\"pt-BR\":\"Europa\"}},\"Country\":{\"GeoNameID\":798544,\"IsoCode\":\"PL\",\"Names\":{ \"ja\":\"\u30DD\u30FC\u30E9\u30F3\u30C9\u5171\u548C\u56FD\",\"pt-BR\":\"Pol\u00F4nia\",\"ru\":\"\u041F\u043E\u043B\u044C\u0448\u0430\",\"zh-CN\":\"\u6CE2\u5170\",\"de\":\"Polen\",\"en\":\"Poland\",\"es\":\"Polonia\",\"fr\":\"Pologne\"}},\"Location\":{\"Latitude\":52.25,\"Longitude\":21,\"MetroCode\":0,\"TimeZone\":\"Europe/Warsaw\"},\"Postal\":{\"Code\":\"00-202\"},\"RegisteredCountry\":{\"GeoNameID\":798544,\"IsoCode\":\"PL\",\"Names\":{ \"de\":\"Polen\",\"en\":\"Poland\",\"es\":\"Polonia\",\"fr\":\"Pologne\",\"ja\":\"\u30DD\u30FC\u30E9\u30F3\u30C9\u5171\u548C\u56FD\",\"pt-BR\":\"Pol\u00F4nia\",\"ru\":\"\u041F\u043E\u043B\u044C\u0448\u0430\",\"zh-CN\":\"\u6CE2\u5170\"}},\"RepresentedCountry\":{\"GeoNameID\":0,\"IsoCode\":\"\",\"Names\":null,\"Type\":\"\"},\"Subdivisions\":[{\"GeoNameID\":858787,\"IsoCode\":\"MZ\",\"Names\":{ \"de\":\"Woiwodschaft Masowien\",\"en\":\"Mazovia\",\"es\":\"Voivodato de Mazovia\",\"fr\":\"Vo\u00EFvodie de Mazovie\",\"ja\":\"\u30DE\u30BE\u30D5\u30B7\u30A7\u770C\",\"pt-BR\":\"Voivodia da Maz\u00F3via\",\"ru\":\"\u041C\u0430\u0437\u043E\u0432\u0435\u0446\u043A\u043E\u0435 \u0432\u043E\u0435\u0432\u043E\u0434\u0441\u0442\u0432\u043E\"}}],\"Traits\":{\"IsAnonymousProxy\":false,\"IsSatelliteProvider\":false}}}";
            var geoData = GeoData.FromJson(jsonString);
            Assert.AreEqual("PL", geoData.Data.Country.IsoCode);
            Assert.AreEqual("Poland", geoData.Data.Country.Names.En);
        }
    }
}


