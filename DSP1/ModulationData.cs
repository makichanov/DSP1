using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSP1
{
    public class ModulationData
    {
        public ModulationType Type { get; set; }

        public double[] Data { get; set; }

        public ModulationData(ModulationType type, double[] data)
        {
            Type = type;
            Data = data;
        }
    }
}
