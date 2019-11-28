using System;

namespace SignalProcessing
{
    public static class SignalSmoothing
    {
        private static readonly Parabola Parabola4 = new Parabola(4, 231, new int[] {5, -30, 75, 131, 75, -30, 5});


        public static double[] ByParabola4(double[] values)
        {
            if (values.Length < Parabola4.Coefficients.Length)
            {
                throw new ArgumentOutOfRangeException(nameof(values),
                    $"Length of {nameof(values)} elements can not be lower than {Parabola4.Coefficients.Length}");
            }

            double[] output = new double[values.Length];

            int halfCoefLength = Parabola4.Coefficients.Length / 2;

            for (int i = 0; i < halfCoefLength; i++)
            {
                output[i] = values[i];
                output[values.Length - i - 1] = values[values.Length - i - 1];
            }

            for (int i = halfCoefLength; i < values.Length - halfCoefLength; i++)
            {
                double value = 0;

                for (int j = 0; j < Parabola4.Coefficients.Length; j++)
                {
                    value += Parabola4.Coefficients[j] * values[i - halfCoefLength + j];
                }

                output[i] = value / Parabola4.Divider;
            }

            return output;
        }

        public static double[] ByArithmeticAveraging(double[] funcValues, int window)
        {
            if (window % 2 == 1)
            {
                window += 1;
            }
            
            int offset = window / 2;
            

            double[] output = new double[funcValues.Length];

            for (int i = 0; i < offset; i++)
            {
                output[i] = funcValues[i];
                output[funcValues.Length - offset - 1] = funcValues[funcValues.Length - offset - 1];
            }

            for (int i = offset; i < funcValues.Length - offset; i++)
            {
                double value = 0;
                for (int j = 0; j < window; j++)
                {
                    value += funcValues[i - offset + j];
                }

                output[i] = value / window;
            }

            return output;
        }

        public static double[] ByMedianFiltering(double[] funcValues, int window)
        {
            if (window % 2 == 1)
            {
                window += 1;
            }

            int offset = window / 2;

            double[] output = new double[funcValues.Length];

            for (int i = 0; i < offset; i++)
            {
                output[i] = funcValues[i];
                output[funcValues.Length - offset - 1] = funcValues[funcValues.Length - offset - 1];
            }

            double[] array = new double[window];

            for (int i = offset; i < funcValues.Length - offset; i++)
            {
                Array.Copy(funcValues, i - offset, array, 0, window);
                Array.Sort(array);

                output[i] = array[offset];
            }

            return output;

        }
    }

    class Parabola
    {
        public int Degree { get; set; }

        public int Divider { get; set; }

        public int[] Coefficients { get; set; }

        public Parabola(int degree, int divider, params int[] coefficients)
        {
            this.Degree = degree;
            this.Divider = divider;
            this.Coefficients = coefficients;
        }
    }
}