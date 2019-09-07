using System;
using System.Collections.Generic;

namespace Signals
{
    public abstract class BaseSignal
    {
        private const double Precision = 10E-12;

        public double[] GetResultValues(Data data, int time)
        {
            double[] results = new double[data.SamplingFrequency + 1];
            double temp;

            for (int n = 0; n <= time * data.SamplingFrequency; n++)
            {
                temp = GetResult(data, n);

                if (Math.Abs(temp) < Precision)
                {
                    temp = 0;
                }

                results[n] = temp;
            }

            return results;
        }

        protected abstract double GetResult(Data data, int time);
    }
}