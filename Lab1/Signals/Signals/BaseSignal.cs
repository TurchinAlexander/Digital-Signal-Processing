using System;
using System.Collections.Generic;

namespace Signals
{
    public struct Point
    {
        public double X;
        
        public double Y;
    }

    public abstract class BaseSignal
    {
        private const int PrecisionDigits = 7;
        protected const int SamplingFrequency = 800;
        private readonly double Precision = Math.Pow(10, -PrecisionDigits);


        public Point[] GetResultValues(Data data)
        {
            Point[] results = new Point[data.time * SamplingFrequency + 1];
            double funcResult;

            for (int n = 0; n <= data.time * SamplingFrequency; n++)
            {
                funcResult = GetResult(data, n);

                var roundFuncResult = Math.Round(funcResult, PrecisionDigits);

                if (Math.Abs(roundFuncResult - funcResult) < Precision)
                {
                    results[n].Y= roundFuncResult;
                }
                else
                {
                    results[n].Y = funcResult;
                }

                results[n].X = (double)n / SamplingFrequency;
            }

            return results;
        }

        protected abstract double GetResult(Data data, int step);
    }
}