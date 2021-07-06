using System;
using Integrationflow_BL;
using Integrationflow_Model;

namespace Main
{
    class Program
    {
        static void Main(string[] args)
        {
            Program myProgram = new Program();
            myProgram.Integrationflow();
        }

        public void Integrationflow()
        {
            //Implementing dependency inversion and single responsability patterns to create a loose coupling, and make it easy to test with muck data
            Business business = new Business();

            ConvesionCollection collection = business.GetData();
            business.SaveData(collection);
        }
    }
}
