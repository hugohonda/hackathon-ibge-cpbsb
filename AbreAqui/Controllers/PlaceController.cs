using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;
using System.Collections.Generic;
using System.Text;
using System.Net.Http.Formatting;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using AbreAqui.Models;

namespace AbreAqui.Controllers
{
    public class PlaceController : Controller
    {
        // GET: Place
        public ActionResult Index()
        {
            return View();
        }

        public static void teste() {

            HttpClient client = new HttpClient();
            string baseApiAddress = "http://api.sidra.ibge.gov.br/";

            client.BaseAddress = new Uri(baseApiAddress);
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage response = client.GetAsync("/values/t/1612/n2/all/v/all/p/last/c81/2702/f/u").Result;
            if (response.IsSuccessStatusCode)
            {
                IEnumerable<ValorDescritoPorSuasDimensoes> valores = response.Content.ReadAsAsync<IEnumerable<ValorDescritoPorSuasDimensoes>>().Result;
                foreach (ValorDescritoPorSuasDimensoes valor in valores)
                {
                    Console.WriteLine(valor.D1C + " - " + valor.D1N + " - " + valor.D2N + " - " + valor.D3N + " - " + valor.D4N + " - " + valor.MN + " - " + valor.V);
                }
            }
            else
            {
                Console.WriteLine("Error Code" + response.StatusCode + " : Message - " + response.ReasonPhrase);
            }
        }
    }
}