using Integrationflow_Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Integrationflow_DAL
{
    public class Update
    {
        Context Context;
        public Update(Context context)
        {
            Context = context;
        }
        public void SaveData(ConversionRate conversionrate)
        {
            Context.Add(conversionrate);
        }
        public void CheckIfExists(ConvesionCollection collection)
        {
            foreach (ConversionRate conversionrate in collection.valutaKurser)
            {
                var oldConversion = Context.ConvertionsRate.FirstOrDefault(x => x.FromCurrency == conversionrate.FromCurrency && x.ToCurrency == conversionrate.ToCurrency);
     
                //in case the conversion dose not exist we give it a new id.
                if(oldConversion == null)
                {

                    conversionrate.ID = generateID();
                    SaveData(conversionrate);
                }
                else
                {
                    //if the data is the same there is no reason to update it, so we check if the data is outdated.
                    if (oldConversion.Rate != conversionrate.Rate)
                    {
                        oldConversion.Rate = conversionrate.Rate;
                        SaveData(oldConversion);
                    }

                }
            }
            //when every item has been prosseced we save data to the database.
            Context.SaveChanges();
        }
        public int generateID()
        {
            Random random = new Random();
            return random.Next();
        }
    }
}
