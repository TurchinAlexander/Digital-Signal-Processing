using System;

namespace Signals
{
    public class SinSignal : BaseSignal
    {
        public override double GetFunc(double x)
        {
            var temp = 2 * Math.PI * Frequency * x + Phase;
            var result = Amplitude * Math.Sin(temp);

            return result;
        }

    }
}