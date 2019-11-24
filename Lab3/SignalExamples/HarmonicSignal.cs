using System;

namespace SignalExamples
{
    public class HarmonicSignal : ISignal
    {
        private readonly double Amplitude = 10;
        private readonly double Frequency = 1;
        //private readonly double Phase = Math.PI / 2;
        private readonly double Phase = Math.PI;
        //private readonly double Phase = 0;
        private readonly Func<double, double> function = Math.Cos;


        public double Calculate(double x)
        {
            return Amplitude * function(2 * Math.PI * Frequency * x - Phase);
        }
    }
}