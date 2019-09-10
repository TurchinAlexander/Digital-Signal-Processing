using System;

namespace Signals
{
    public class ImpulseSignal : BaseSignal
    {
        public double DutyFactor { get; set; }

        public override double GetFunc(double x)
        {
            var temp = 2 * Math.PI * Frequency * x + Phase;
            var sin = Math.Sin(temp);

            var funcResult = sin >= 1 - 2 * DutyFactor;

            return funcResult ? Amplitude : 0;
        }

    }
}