using System;

namespace Signals
{
    public class SawtoothSignal : BaseSignal
    {
        private readonly double SinBound = Math.PI / 2;

        protected override double GetResult(Data data, int step)
        {
            var x = 2 * Math.PI * data.frequency * step / SamplingFrequency;
            x += data.startPhase;
            x /= 2;

            var funcResult = data.amplitude * Math.Atan(Math.Tan(x)) / SinBound;

            return funcResult;
        }

        public override string ToString()
        {
            return "Sawtooth";
        }
    }
}