using AbreAqui.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web;

namespace AbreAqui.Controllers
{
    public class YieldController
    {
        public static void teste(string idCounty)
        {

            HttpClient client = new HttpClient();
            string baseApiAddress = "http://api.sidra.ibge.gov.br/";

            client.BaseAddress = new Uri(baseApiAddress);
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage response = client.GetAsync("/values/t/1381/n6/" + idCounty).Result;
            if (response.IsSuccessStatusCode)
            {
                IEnumerable<Yield> values = response.Content.ReadAsAsync<IEnumerable<Yield>>().Result;
                foreach (Yield value in values)
                {
                    Debug.WriteLine(value.D2N + " - " + value.D3N + " - " + value.MN + " - " + value.V);
                }
            }
            else
            {
                Console.WriteLine("Error Code" + response.StatusCode + " : Message - " + response.ReasonPhrase);
            }
        }
    }
}