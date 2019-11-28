using System;

namespace SignalExamples
{
    public class HighFrequenciesSignal : ISignal
    {
        private const int AmplitudeValue1 = 5;
        private const int AmplitudeValue2 = 10;

        private const int StartFrequency = 50;
        private const int EndFrequency = 70;

        private static readonly Random rnd = new Random();
        private readonly int[] signes;
        private readonly int frequencyArraySize = EndFrequency - StartFrequency + 1;

        public HighFrequenciesSignal()
        {
            CreateSignValues(out signes);
        }

        private void CreateSignValues(out int[] signValues)
        {
            signValues = new int[frequencyArraySize];

            for (int i = 0; i < frequencyArraySize; i++)
            {
                signValues[i] = Math.Sign(rnd.NextDouble() - 1);
            }
        }

        public double Calculate(double x)
        {
            double value = AmplitudeValue1 * Math.Sin(2 * Math.PI * x);

            for (int i = 0; i < frequencyArraySize; i++)
            {
                value += signes[i] * AmplitudeValue2 * Math.Sin(2 * Math.PI * (StartFrequency + i) * x);
            }

            return value;
        }
    }
}