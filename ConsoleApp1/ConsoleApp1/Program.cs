using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string url = "https://restcountries.eu/rest/v2/name/eesti";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";

            var WebResponse = request.GetResponse();
            var webStream = WebResponse.GetResponseStream();

            using(var responseReader = new StreamReader(webStream))
            {
                var response = responseReader.ReadToEnd();
                var info = JsonConvert.DeserializeObject<List<CountryDetails>>(response);
                Console.WriteLine($"Name: {info[0].Name}"); ;
                Console.WriteLine($"Cioc: {info[0].Cioc}");
                Console.WriteLine($"Domain: {info[0].Domain}");
                Console.WriteLine($"Capital: {info[0].Capital}");
                Console.WriteLine($"Region: {info[0].Region}");
                Console.WriteLine($"Population: {info[0].Population}");
                Console.WriteLine($"Language: {info[0].Languages[0].Name}");
            }
        }
    }
}
