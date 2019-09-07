using System;

namespace Signals
{
    public class SinSignal : BaseSignal
    {
        protected override double GetResult(
            Data data,
            int step)
        {
            var x = 2 * Math.PI * data.Frequency * step / data.SamplingFrequency;
            x += data.StartPhase;

            var result = data.Amplitude * Math.Sin(x);

            return result;
        }
    }
}