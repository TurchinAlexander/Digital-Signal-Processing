using System;

namespace Signals
{
    public class SinSignal : BaseSignal
    {
        protected override double GetResult(
            Data data,
            int step)
        {
            var x = 2 * Math.PI * data.frequency * step / data.samplingFrequency;
            x += data.startPhase;

            var result = data.amplitude * Math.Sin(x);

            return result;
        }
    }
}