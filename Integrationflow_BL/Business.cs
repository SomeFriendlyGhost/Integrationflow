using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Http;
using Integrationflow_DAL;
using Integrationflow_Model;

namespace Integrationflow_BL
{
    public class Business
    {
        public ConvesionCollection GetData()
        {
            string url = "http://valutakurstest.azurewebsites.net/ValutaKurs";
            HttpClient client = new HttpClient();

            Read read = new Read(client, url);
            return read.GetData();
        }

        public void SaveData(ConvesionCollection collection)
        {
            Context context = new Context();
            Update update = new Update(context);

            update.CheckIfExists(collection);
        }
    }
}
