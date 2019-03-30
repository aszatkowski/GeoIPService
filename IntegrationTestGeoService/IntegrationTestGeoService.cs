using System;
using System.Net.Http;
using System.Net.Http.Headers;
using GeoService;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace IntegrationTestGeoService
{
    [TestClass]
    public class IntegrationTestGeoService
    {
        [TestMethod]
        public async System.Threading.Tasks.Task TestMethod1Async()
        {
            string Baseurl = "http://localhost:3000/";
            using (var client = new HttpClient())
            {
                //Ustawienie bazowego adresu
                client.BaseAddress = new Uri(Baseurl);

                client.DefaultRequestHeaders.Clear();
                //Definicja formatu  
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                //Wysłanie requestu do serwisu REST przy użyciu HttpClient
                //Jako argument podajemy adres IP
                HttpResponseMessage Res = await client.GetAsync("37.47.46.163");

                //Sprawdzenie odpowiedzi 
                if (Res.IsSuccessStatusCode)
                {
                    //oobranie JSON jako typ String  
                    var jsonString = Res.Content.ReadAsStringAsync().Result;
                    var geoData = GeoData.FromJson(jsonString);
                    Assert.AreEqual("PL", geoData.Data.Country.IsoCode);
                    Assert.AreEqual("Poland", geoData.Data.Country.Names.En);

                }
                else
                {
                    Assert.Fail("sprawdź geoip-service mikroserwis!");
                }
            }
        }
    }
}
