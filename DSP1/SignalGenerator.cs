using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSP1
{
    public class SignalGenerator
    {
        public double[] GenerateSinusoid(double amplitude, int frequency, double initialPhaseRad, int sampling, int duration, ModulationData modulationData)
        {
            double[] result = new double[sampling *  duration];
            double phaseMod = 0;
            for (int i = 1; i <= sampling * duration; i++)
            {
                double phase = 2 * Math.PI * frequency * (i / (double)sampling);
                phaseMod += CalculateModPhase(frequency, i, sampling, modulationData);
                phase += phaseMod;

                double x = amplitude * Math.Sin(phase + initialPhaseRad);

                result[i - 1] = modulationData.Type == ModulationType.AMPLITUDE
                    ? modulationData.Data[i-1] * x
                    : x;
            }

            return result;
        }

        public double[] GeneratePulse(double amplitude, int frequency, double initialPhaseRad, int sampling, double fillFactor, int duration, ModulationData modulationData)
        {
            double[] result = new double[sampling * duration];
            double phaseMod = 0;

            for (int i = 1; i <= sampling * duration; i++)
            {
                double phase = 2 * Math.PI * frequency * (i / (double)sampling);
                phaseMod += CalculateModPhase(frequency, i, sampling, modulationData);
                phase += phaseMod;

                double x = (((phase + initialPhaseRad) % (2 * Math.PI)) / (2 * Math.PI)) < fillFactor
                    ? amplitude
                    : -amplitude;

                result[i - 1] = modulationData.Type == ModulationType.AMPLITUDE
                    ? modulationData.Data[i - 1] * x
                    : x;
            }

            return result;
        }

        public double[] GenerateTriangle(double amplitude, int frequency, double initialPhaseRad, int sampling, int duration, ModulationData modulationData)
        {
            double[] result = new double[sampling * duration];
            double phaseMod = 0;

            for (int i = 1; i <= sampling * duration; i++)
            {
                double phase = 2 * Math.PI * frequency * (i / (double)sampling);
                phaseMod += CalculateModPhase(frequency, i, sampling, modulationData);
                phase += phaseMod;

                double x = amplitude * ((4 * Math.Abs(((((phase + initialPhaseRad) / (2 * Math.PI)) - 0.25) % 1) - 0.5)) - 1);

                result[i - 1] = modulationData.Type == ModulationType.AMPLITUDE
                    ? modulationData.Data[i - 1] * x
                    : x;
            }

            return result;
        }

        public double[] GenerateSawtooth(double amplitude, int frequency, double initialPhaseRad, int sampling, int duration, ModulationData modulationData)
        {
            double[] result = new double[sampling * duration];
            double phaseMod = 0;

            for (int i = 1; i <= sampling * duration; i++)
            {
                double phase = 2 * Math.PI * frequency * (i / (double)sampling);
                phaseMod += CalculateModPhase(frequency, i, sampling, modulationData);
                phase += phaseMod;

                double x = amplitude * (2 * ((((phase + initialPhaseRad) / (2 * Math.PI)) - 0.5) % 1) - 1);

                result[i - 1] = modulationData.Type == ModulationType.AMPLITUDE
                    ? modulationData.Data[i - 1] * x
                    : x;
            }

            return result;
        }

        public double[] GenerateWhiteNoise(double amplitude, int sampling, int duration, ModulationData modulationData)
        {
            double[] result = new double[sampling * duration];
            Random r = new Random();

            for (int i = 1; i <= sampling * duration; i++)
            {
                double x = amplitude * (2 * r.NextDouble() - 1);

                result[i - 1] = modulationData.Type == ModulationType.AMPLITUDE
                    ? modulationData.Data[i - 1] * x
                    : x;
            }

            return result;
        }

        private double CalculateModPhase(double frequency, int i, int sampling, ModulationData modulationData)
        {
            if (modulationData.Type == ModulationType.FREQUENCY)
            {
                return 2 * Math.PI * modulationData.Data[i - 1] / (double)sampling * frequency;
            }

            return 0;
        }
    }
}
