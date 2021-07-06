using System;
using System.Collections.Generic;
using System.Text;

namespace Integrationflow_Model
{
    public class ConversionRate
    {
        public int ID { get; set; }
        public string FromCurrency { get; set; }
        public string ToCurrency { get; set; }
        public decimal Rate { get; set; }
    }
}
