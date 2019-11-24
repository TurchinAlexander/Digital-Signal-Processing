using System;

namespace SignalProcessing
{
    public class DigitalFourierTransform
    {
        private const int AmplitudeAndPhaseSize = 2;
        private const int Amplitude = 0;
        private const int Phase = 1;

        private readonly int samplingFrequency;
        private readonly int cosOffset;
        private readonly double[] sinArray;

        /// <summary>
        /// Constructor to create Digital Fourier Transform.
        /// </summary>
        /// <param name="samplingFrequency">How accurately should the function be obtained.</param>
        public DigitalFourierTransform(int samplingFrequency)
        {
            if (samplingFrequency <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(samplingFrequency),
                    "Sampling Frequency can not be lower or equal to 0");
            }

            this.samplingFrequency = samplingFrequency;
            cosOffset = samplingFrequency / 4;
            
            CreateSinArray(out sinArray);
        }

        /// <summary>
        /// Get Amplitude Frequency and Phase Frequency response;
        /// </summary>
        /// <param name="func">The function which should be researched.</param>
        /// <param name="countOfHarmonics">The number of harmonics into which <paramref name="func"/> should be divided.</param>
        /// <returns>Array of <see cref="double"/> where each element contains Amplitude and Phase of a harmonic.</returns>
        public double[][] GetFrequencyResponse(Func<double, double> func, int countOfHarmonics/*, FrequencyResponse responseType*/)
        {
            double[] funcValues = GetFuncValues(func);

            double[][] result = new double[countOfHarmonics][];

            for (int i = 0; i < countOfHarmonics; i++)
            {
                result[i] = GetHarmonicAmplitudeAndPhase(funcValues, i);
            }

            return result;
        }

        private double[] GetFuncValues(Func<double, double> func)
        {
            double[] result = new double[samplingFrequency];

            for (int i = 0; i < samplingFrequency; i++)
            {
                double x = (double) i / samplingFrequency;

                result[i] = func(x);
            }

            return result;
        }

        private double[] GetHarmonicAmplitudeAndPhase(double [] funcValues, int harmonicNumber)
        {
            double[] result = new double[2];

            double re = 0;
            double im = 0;
            double amplitudeCos = 0;
            double amplitudeSin = 0;


            int sinIndex = 0;
            int cosIndex = cosOffset;

            for (int i = 0; i < samplingFrequency; i++)
            {
                re += funcValues[i] * sinArray[cosIndex];
                im += funcValues[i] * sinArray[sinIndex];

                sinIndex = (sinIndex + harmonicNumber) % samplingFrequency;
                cosIndex = (cosIndex + harmonicNumber) % samplingFrequency;
            }

            amplitudeCos = re / samplingFrequency;
            amplitudeSin = im / samplingFrequency;

            result[Amplitude] = Math.Sqrt(Math.Pow(amplitudeCos, 2) + Math.Pow(amplitudeSin, 2));
            result[Phase] = Math.Atan(amplitudeSin / amplitudeCos);

            return result;
        }

        private void CreateSinArray(out double[] sinValues)
        {
            sinValues = new double[samplingFrequency];

            for (int i = 0; i < samplingFrequency; i++)
            {
                sinValues[i] = Math.Sin(2 * Math.PI * i / samplingFrequency);
            }
        }
    }
}