using System;
using System.Linq;
using System.Numerics;

namespace SignalProcessing
{
    public class DigitalFourierTransform
    {
        private const int DigitsAfterDot = 4;

        private readonly int samplingFrequency;
        private readonly int halfSamplingFrequency;
        private readonly int cosOffset;
        private readonly double[] sinArray;
        private readonly Complex[] complexRoots;

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
            this.halfSamplingFrequency = this.samplingFrequency / 2;
            cosOffset = samplingFrequency / 4;
            
            CreateSinArray(out sinArray);
            CreateComplexMatrix(out complexRoots);
        }

        /// <summary>
        /// Get Amplitude Frequency and Phase Frequency response.
        /// </summary>
        /// <param name="func">The function which should be researched.</param>
        /// <param name="countOfHarmonics">The number of harmonics into which <paramref name="func"/> should be divided.</param>
        /// <returns>Array of <see cref="Harmonic"/> where each element contains Amplitude and Phase of a harmonic.</returns>
        public Harmonic[] GetFrequencyResponse(Func<double, double> func, int countOfHarmonics/*, FrequencyResponse responseType*/)
        {
            double[] funcValues = GetFuncValues(func);

            return GetFrequencyResponse(funcValues, countOfHarmonics);
        }

        /// <summary>
        /// Get Amplitude Frequency and Phase Frequency response. 
        /// </summary>
        /// <param name="funcValues">Array of values from what should be Amplitude and Phase spectrums created.</param>
        /// <param name="countOfHarmonics">The number of harmonics into which <paramref name="funcValues"/> should be divided.</param>
        /// <returns>Array of <see cref="Harmonic"/> where each element contains Amplitude and Phase of a harmonic.</returns>
        /// <exception cref="ArgumentException">if the length of <see cref="funcValues"/> is not equal to Sampling Frequency.</exception>
        public Harmonic[] GetFrequencyResponse(double[] funcValues, int countOfHarmonics/*, FrequencyResponse responseType*/)
        {
            if (funcValues.Length < samplingFrequency)
            {
                throw new ArgumentException(nameof(funcValues),
                    $"Size of the array should be equal or greater than {samplingFrequency}");
            }

            Harmonic[] result = new Harmonic[countOfHarmonics];

            for (int i = 0; i < countOfHarmonics; i++)
            {
                result[i] = GetHarmonicAmplitudeAndPhase(funcValues, i);
            }


            return result;
        }

        public Harmonic[] FastTransform(double[] funcValues)
        {
            Complex[] result = FastFourierTransform(funcValues, 1, 0);

            return ParseComplex(result);
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

        private Harmonic[] ParseComplex(Complex[] array)
        {
            int halfFrequencyArray = array.Length / 2;

            Harmonic[] result = new Harmonic[halfFrequencyArray];

            double amplitude = array[0].Magnitude / samplingFrequency;
            double phase = 0;

            result[0] = new Harmonic(0, amplitude, phase);

            for (int i = 0; i < halfFrequencyArray; i++)
            {
                amplitude = Math.Round(array[i].Magnitude / halfSamplingFrequency, DigitsAfterDot);
                phase = Math.Round(Math.Atan2(array[i].Imaginary, array[i].Real), DigitsAfterDot);

                result[i] = new Harmonic(i, amplitude, phase);
            }

            return result;
        }

        private Complex[] FastFourierTransform(double[] funcValues, int step, int start)
        {
            if (step == samplingFrequency)
            {
                return new[] { new Complex(funcValues[start], 0) };
            }

            Complex[] evenValues = FastFourierTransform(funcValues, 2 * step, start);
            Complex[] oddValues = FastFourierTransform(funcValues, 2 * step, start + step);


            int outputLength = evenValues.Length + oddValues.Length;
            int complexRootCoefficient = samplingFrequency / outputLength;
            Complex[] output = new Complex[outputLength];

            for (int i = 0; i < outputLength / 2; i++)
            {
                output[i] = evenValues[i] + complexRoots[i * complexRootCoefficient] * oddValues[i];
                output[i + outputLength / 2] = evenValues[i] - complexRoots[i * complexRootCoefficient] * oddValues[i];
            }

            return output;
        }

        private void CreateSinArray(out double[] sinValues)
        {
            sinValues = new double[samplingFrequency];

            for (int i = 0; i < samplingFrequency; i++)
            {
                sinValues[i] = Math.Sin(2 * Math.PI * i / samplingFrequency);
            }
        }

        private void CreateComplexMatrix(out Complex[] matrix)
        {
            matrix = new Complex[halfSamplingFrequency];

            for (int i = 0; i < halfSamplingFrequency; i++)
            {
                double re = sinArray[(cosOffset + i) % samplingFrequency];
                double im = sinArray[i];

                matrix[i] = new Complex(re, -im);
            }
        }

    }
}