using System;

namespace MetricsChanges
{
    public class TempModel
    {
        //public DateTime Date { get; set; }

        public string TemperatureName { get;  set; }

        public int Temperature { get; set; }

        // public string Summary { get; set; } F => 32 + (int)(TemperatureC / 0.5556)
    }
}
