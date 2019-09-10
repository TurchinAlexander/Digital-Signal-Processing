﻿using System;

namespace Signals
{
    public class ImpulseSignal : BaseSignal
    {
        private readonly double SinBound = Math.PI / 2;
        private readonly double DefaultRelation = 0.5;

        public ImpulseSignal()
        {
        }

        protected override double GetResult(Data data, int step)
        {
            var x = 2 * Math.PI * data.frequency * step / SamplingFrequency;
            x += data.startPhase;

            var sin = Math.Sin(x);

            var funcResult = sin >= 1 - 2 * data.dutyFactor;

            return funcResult ? data.amplitude : 0;
        }

        public override string ToString()
        {
            return "Impulse";
        }
    }
}