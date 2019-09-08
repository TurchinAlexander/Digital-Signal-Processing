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
            var x = 2 * Math.PI * data.frequency * step / data.samplingFrequency;
            x += data.startPhase;

            var funcResult = Math.Asin(Math.Sin(x)) / SinBound + (DutyFactor / DefaultRelation - 1);

            return Math.Sign(funcResult) >= 0 ? data.amplitude : 0;
        }
    }
}