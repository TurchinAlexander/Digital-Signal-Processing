using System;

namespace Signals
{
    public class ImpulseSignal : BaseSignal
    {
        private readonly double SinBound = Math.PI / 2;
        private readonly double DefaultRelation = 0.5;

        public double DutyFactor { get; }

        public ImpulseSignal(double dutyFactor)
        {
            DutyFactor = dutyFactor;
        }

        protected override double GetResult(Data data, int step)
        {
            var x = 2 * Math.PI * data.Frequency * step / data.SamplingFrequency;
            x += data.StartPhase;

            var sin = data.Amplitude * Math.Sin(x);
            var funcResult = Math.Asin(sin) / SinBound + (DutyFactor / DefaultRelation - 1);

            return Math.Sign(funcResult) >= 0 ? 1 : 0;
        }
    }
}