using System;

namespace SignalExamples
{
    public class PolyharmonicSignal : ISignal
    {
        private static Random rnd = new Random();
        private static readonly double[] AmplitudeArray = new double[] { 1, 3, 5, 8, 10, 12, 16 };
        private static readonly double[] PhaseArray = new double[]
            {Math.PI / 6, Math.PI / 4, Math.PI / 3, Math.PI / 2, 3 * Math.PI / 4, Math.PI};

        private const int ArraySize = 30;
        private const int Amplitude = 0;
        private const int Phase = 1;

        private readonly double[][] arr;


        public PolyharmonicSignal()
        {
             arr = CalculateAmplitudesAndPhases();

        }

        private double[][] CalculateAmplitudesAndPhases()
        {
            double[][] result = new double[ArraySize][];

            for (int i = 0; i < ArraySize; i++)
            {
                result[i] = new double[2];

                //result[i][Amplitude] = AmplitudeArray[rnd.Next(0, AmplitudeArray.Length - 1)];
                //result[i][Phase] = PhaseArray[rnd.Next(0, PhaseArray.Length - 1)];

                result[i][Amplitude] = AmplitudeArray[i % AmplitudeArray.Length];
                result[i][Phase] = PhaseArray[i % PhaseArray.Length];
            }

            return result;
        }

        public double Calculate(double x)
        {
            double value = arr[0][Amplitude] / 2;

            for (int i = 1; i < arr.Length; i++)
            {
                
                value += arr[i][Amplitude] * Math.Cos(2 * Math.PI * i * x - arr[i][Phase]);
            }

            return value;
        }
    }
}