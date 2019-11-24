using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SignalProcessing;

namespace ConsolveTest
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = 10;

            Func<double, double> func = (x) => 10 * Math.Cos(2 * Math.PI * x - Math.PI / 2);

            //for (int i = 0; i < N; i++)
            //{
            //    Console.WriteLine($"{(double) i / N} - {func((double) i / N)}");
            //}

            DigitalFourierTransform dft = new DigitalFourierTransform(1024);

            Harmonic[] result = dft.GetFrequencyResponse(func, 10);

            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine($"Harmonic number {i}: Amplitude - {result[i].Amplitude}, phase - {result[i].Phase}");
            }

            Console.ReadKey();
        }
    }
}
