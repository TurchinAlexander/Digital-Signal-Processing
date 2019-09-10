using System;

namespace Signals
{
    public class SawtoothSignal : BaseSignal
    {
        private readonly double SinBound = Math.PI / 2;

        public override double GetFunc(double x)
        {
            var temp = 2 * Math.PI * Frequency * x + Phase;
            temp /= 2;

            var funcResult = Amplitude * Math.Atan(Math.Tan(temp)) / SinBound;

            return funcResult;
        }
    }
}