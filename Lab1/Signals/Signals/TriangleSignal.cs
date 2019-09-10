using System;

namespace Signals
{
    public class TriangleSignal : BaseSignal
    {
        private readonly double SinBound = Math.PI / 2;

        protected override double GetResult(Data data, int step)
        {
            var x = 2 * Math.PI * data.frequency * step / SamplingFrequency;
            x += data.startPhase;

            var funcResult = data.amplitude * Math.Asin(Math.Sin(x)) / SinBound;

            return funcResult;
        }

        public override string ToString()
        {
            return "Triangle";
        }
    }
}