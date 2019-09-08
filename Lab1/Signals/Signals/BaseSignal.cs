using System;
using System.Collections.Generic;

namespace Signals
{
    public abstract class BaseSignal
    {
        private const int PrecisionDigits = 7;
        private const int SubArraySize = 2;
        private readonly double Precision = Math.Pow(10, -PrecisionDigits);


        public double[][] GetResultValues(Data data)
        {
            double[][] results = new double[data.time * data.samplingFrequency + 1][];
            double funcResult;

            for (int n = 0; n <= data.time * data.samplingFrequency; n++)
            {
                results[n] = new double[SubArraySize];
                funcResult = GetResult(data, n);

                var roundFuncResult = Math.Round(funcResult, PrecisionDigits);

                if (Math.Abs(roundFuncResult - funcResult) < Precision)
                {
                    results[n][1] = roundFuncResult;
                }
                else
                {
                    results[n][1] = funcResult;
                }

                results[n][0] = (double)n / data.samplingFrequency;
            }

            return results;
        }

        protected abstract double GetResult(Data data, int step);
    }
}