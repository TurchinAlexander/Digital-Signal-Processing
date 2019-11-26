using System;
using System.Numerics;

namespace SignalProcessing
{
    public class FastFourierTransform
    {
        private readonly int cosOffset;

        private readonly int samplingFrequency;
        private readonly double[] sinArray;
        private readonly Complex[] complexMatrix;

        public FastFourierTransform(int samplingFrequency)
        {
            this.samplingFrequency = samplingFrequency;

            cosOffset = samplingFrequency / 4;

            CreateSinArray(out sinArray);
            CreateComplexMatrix(out complexMatrix);
        }

        public Harmonic[] GetResponse(double[] funcValues)
        { 
            Complex[] result = FFT(funcValues, 1, 0);

            return ParseComplex(result);
        }

        private Harmonic[] ParseComplex(Complex[] array)
        {
            Harmonic[] result = new Harmonic[array.Length / 2 + 1];

            double amplitude = array[0].Magnitude / samplingFrequency;
            double phase = Math.Atan2(array[0].Imaginary, array[0].Real);

            result[0] = new Harmonic(0, amplitude, phase);

            for (int i = 0; i < result.Length; i++)
            {
                var simmetric = samplingFrequency - i;
                int coef = (simmetric == i)
                    ? 1
                    : 2;

                amplitude = coef * array[i].Magnitude / samplingFrequency;
                phase = Math.Atan2(array[i].Imaginary, array[i].Real);

                result[i] = new Harmonic(i, amplitude, phase);
            }

            return result;
        }

        private Complex[] FFT(double[] funcValues, int step, int start)
        {
            if (step == samplingFrequency)
            {
                return new Complex[] {new Complex(funcValues[start], 0)};
            }

            Complex[] even = FFT(funcValues, 2 * step, start);
            Complex[] odd = FFT(funcValues,  2 * step, start + step);


            int resultLength = even.Length + odd.Length;
            int t = samplingFrequency / resultLength;
            Complex[] result = new Complex[resultLength];

            for (int i = 0; i < resultLength / 2; i++)
            {
                result[i] = even[i] + complexMatrix[i * t] * odd[i];
                result[i + resultLength / 2] = even[i] - complexMatrix[i * t] * odd[i];
            }

            return result;
        }



        private void CreateComplexMatrix(out Complex[] matrix)
        {
            matrix = new Complex[samplingFrequency];

            for (int i = 0; i < samplingFrequency; i++)
            {
                double re = sinArray[(cosOffset + i) % samplingFrequency];
                double im = sinArray[i];

                matrix[i] = new Complex(re, -im);
            }
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