using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Signals;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Data data = new Data()
            {
                Amplitude = 1,
                Frequency = 2,
                SamplingFrequency = 16,
                StartPhase = 0
            };
            var time = 1;
            var dutyFactor = 0.3;

            ImpulseSignal impulseSignal = new ImpulseSignal(dutyFactor);
            var results = impulseSignal.GetResultValues(data, time);

            for (int n = 0; n <= time * data.SamplingFrequency; n++)
            {
                Console.WriteLine("{0, -20} {1}", (double)n / data.SamplingFrequency, results[n]);
            }

            Console.ReadKey();
        }
    }
}
