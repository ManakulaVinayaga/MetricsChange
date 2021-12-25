using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MetricsChanges
{
    public interface IMetrics
    {
        TempModel TempratureMetrics(int val, string CorF);

    }
}
