using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSP1
{
    public class SignalGenerator
    {
        public double[] GenerateSinusoid(int amplitude, int frequency, double initialPhaseRad, int sampling)
        {
            double[] result = new double[sampling];

            for (int i = 1; i <= sampling; i++)
            {
                double sin = Math.Sin(2 * Math.PI * frequency * (i / (double) sampling) + initialPhaseRad);
                double x = amplitude * sin;
                result[i - 1] = x;
            }

            return result;
        }

        public double[] GeneratePulse(int amplitude, int frequency, double initialPhaseRad, int sampling, double fillFactor)
        {
            double[] result = new double[sampling];

            for (int i = 1; i <= sampling; i++)
            {
                result[i - 1] = (Math.PI * 2 * frequency * (i / (double) sampling) + initialPhaseRad) % (2 * Math.PI) / Math.PI * 2 < fillFactor
                    ? amplitude
                    : -amplitude;
            }

            return result;
        }

        public double[] GenerateTriangle(int amplitude, int frequency, double initialPhaseRad, int sampling)
        {
            double[] result = new double[sampling];

            for (int i = 1; i <= sampling; i++)
            {
                result[i - 1] = (2 * amplitude / Math.PI * Math.Pow(Math.Sin(Math.Sin(2 * Math.PI * frequency * (i / (double) sampling) + initialPhaseRad)), -1));
            }

            return result;
        }

        public double[] GenerateSawtooth(int amplitude, int frequency, double initialPhaseRad, int sampling)
        {
            double[] result = new double[sampling];

            for (int i = 1; i <= sampling; i++)
            {
                double sin = Math.Sin(Math.PI * frequency * (i / (double)sampling) + initialPhaseRad);
                double cos = Math.Cos(Math.PI * frequency * (i / (double)sampling) + initialPhaseRad);
                result[i - 1] = (-2 * amplitude / Math.PI * Math.Pow(Math.Tan(cos / sin), -1));
            }

            return result;
        }

        public double[] GenerateWhiteNoise(int amplitude, int sampling)
        {
            double[] result = new double[sampling];
            Random r = new Random();

            for (int i = 1; i <= sampling; i++)
            {
                result[i - 1] = amplitude * (2 * r.NextDouble() - 1);
            }

            return result;
        }
    }
}
