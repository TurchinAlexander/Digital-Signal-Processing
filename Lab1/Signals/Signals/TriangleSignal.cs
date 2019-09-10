using System;

namespace Signals
{
    public class TriangleSignal : BaseSignal
    {
        private readonly double SinBound = Math.PI / 2;

        public override double GetFunc(double x)
        {
            var temp = 2 * Math.PI * Frequency * x + Phase;

            var funcResult = Amplitude * Math.Asin(Math.Sin(x)) / SinBound;

            return funcResult;
        }
    }
}