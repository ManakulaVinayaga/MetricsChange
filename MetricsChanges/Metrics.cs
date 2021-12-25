using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MetricsChanges
{
    public class Metrics : IMetrics
    {
        public TempModel TempratureMetrics(int val, string CorF)
        {
            TempModel tempModel = new TempModel();
            try
            {
                switch(CorF)
                {
                    case "C":
                        tempModel.TemperatureName = "Celcius";
                        tempModel.Temperature= 5 / 9 *(val - 32);
                        break;
                    case "F":
                        tempModel.TemperatureName = "Fahrenheit";
                        tempModel.Temperature = (val * 9 / 5) +32;
                        break;
                    default:
                        tempModel.TemperatureName= "Unknown conversion";
                        break;
                }
            }
            catch(Exception ex)
            {
                
            }
            return tempModel;
        }
    }
}
