using System;
using System.Linq;

namespace SignalProcessing
{
    public class DigitalFourierTransform
    {
        private const int DigitsAfterDot = 4;

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
        public Harmonic[] GetFrequencyResponse(Func<double, double> func, int countOfHarmonics/*, FrequencyResponse responseType*/)
        {
            double[] funcValues = GetFuncValues(func);

            return GetFrequencyResponse(funcValues, countOfHarmonics);
        }

        public Harmonic[] GetFrequencyResponse(double[] funcValues, int countOfHarmonics/*, FrequencyResponse responseType*/)
        {
            if (funcValues.Length < samplingFrequency)
            {
                throw new ArgumentException(nameof(funcValues),
                    $"Size of the array should be equal or greater than {samplingFrequency}");
            }

            Harmonic[] result = new Harmonic[countOfHarmonics];

            //result[0] = GetZeroHarmonic(funcValues);

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

        private Harmonic GetHarmonicAmplitudeAndPhase(double [] funcValues, int harmonicNumber)
        {
            double re = 0;
            double im = 0;

            int sinIndex = 0;
            int cosIndex = cosOffset;

            for (int i = 0; i < samplingFrequency; i++)
            {
                re += funcValues[i] * sinArray[cosIndex];
                im += funcValues[i] * sinArray[sinIndex];

                sinIndex = (sinIndex + harmonicNumber) % samplingFrequency;
                cosIndex = (cosIndex + harmonicNumber) % samplingFrequency;
            }

            double amplitudeCos = 2 * re / samplingFrequency;
            double amplitudeSin = 2 * im / samplingFrequency;

            double amplitude = Math.Sqrt(Math.Pow(amplitudeCos, 2) + Math.Pow(amplitudeSin, 2));
            double phase = Math.Atan2(amplitudeSin, amplitudeCos);

            amplitude = Math.Round(amplitude, DigitsAfterDot);
            phase = Math.Round(phase, DigitsAfterDot);

            Harmonic result = new Harmonic(harmonicNumber, amplitude, phase);

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