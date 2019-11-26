using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SignalExamples;
using SignalProcessing;

namespace ConsolveTest
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = 1024;

            Func<double, double> func = (x) => 10 * Math.Cos(2 * Math.PI * x - Math.PI / 2);

            //for (int i = 0; i < N; i++)
            //{
            //    Console.WriteLine($"{(double) i / N} - {func((double) i / N)}");
            //}

            DigitalFourierTransform dft = new DigitalFourierTransform(N);

            //Harmonic[] result = dft.GetFrequencyResponse(func, 10);

            //FastFourierTransform fft = new FastFourierTransform(N);

            //double[] values = new double[] {8, 4, 8, 0};

            ISignal signal = new PolyharmonicSignal();

            double[] values = new double[N];

            for (int i = 0; i < N; i++)
            {
                values[i] = signal.Calculate((double)i / N);
            }

            //double[] values = new double[] {0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15};

            Harmonic[] result = dft.FastTransform(values);

            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine($"Harmonic number {i}: Amplitude - {result[i].Amplitude}, phase - {result[i].Phase}");
            }

            Console.ReadKey();
        }
    }
}
