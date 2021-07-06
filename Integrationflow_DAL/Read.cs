using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Http;
using System.Net.Http.Json;
using Integrationflow_Model;
using System.Threading.Tasks;

namespace Integrationflow_DAL
{
    public class Read
    {
        HttpClient Client { get; set; }
        string Url { get; set; }

        public Read(HttpClient client, string url)
        {
            Client = client;
            Url = url;
        }
        public ConvesionCollection GetData()
        {
            ConvesionCollection collection = Client.GetFromJsonAsync<ConvesionCollection>(Url).Result;
            return collection;
        }
    }
}
