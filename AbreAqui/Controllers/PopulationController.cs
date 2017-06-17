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
    public class PopulationController
    {
        public static void teste(string idCounty)
        {

            HttpClient client = new HttpClient();
            string baseApiAddress = "http://api.sidra.ibge.gov.br/";

            client.BaseAddress = new Uri(baseApiAddress);
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage response = client.GetAsync("/values/t/1552/n6/" + idCounty + "/c2/all").Result;
            if (response.IsSuccessStatusCode)
            {
                IEnumerable<Population> values = response.Content.ReadAsAsync<IEnumerable<Population>>().Result;
                foreach (Population value in values)
                {
                    Debug.WriteLine(value.D2N + " - " + value.D4N + " - " + value.V);
                }
            }
            else
            {
                Console.WriteLine("Error Code" + response.StatusCode + " : Message - " + response.ReasonPhrase);
            }
        }
    }
}