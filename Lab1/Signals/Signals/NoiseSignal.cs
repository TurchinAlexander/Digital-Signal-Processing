using System;

namespace Signals
{
    public class NoiseSignal : BaseSignal
    {
        private readonly Random random = new Random();

        public override double GetFunc(double x)
        {
            return (random.Next() + random.Next()) % random.Next();
        }
    }
}