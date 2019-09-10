using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using NAudio.Wave;
using Signals;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var amplitude = 1;
            var maxValue = Int16.MaxValue;
            var sampleRate = 44100;
            var frequency = 1000;
            var phase = 0;
            var seconds = 3;
            var dutyFactor = 0.5;

            BaseSignal signal = new NoiseSignal()
            {
                Amplitude = amplitude * maxValue,
                Frequency = frequency,
                Phase = phase,
                //DutyFactor = dutyFactor
            };

            var raw = new byte[sampleRate * seconds * 2];

            for (int n = 0; n < sampleRate * seconds; n++)
            {
                var x = (double)n / sampleRate;
                var sampleValue = signal.GetFunc(x);
                var sample = (short)(sampleValue);
                var bytes = BitConverter.GetBytes(sample);

                raw[n * 2] = bytes[0];
                raw[n * 2 + 1] = bytes[1];
            }

            //var multiple = 2.0 * frequency / sampleRate;
            //for (int n = 0; n < sampleRate * seconds; n++)
            //{
            //    var sampleSaw = ((n * multiple) % 2) - 1;
            //    var sampleValue = sampleSaw > 0 ? amplitude : -amplitude;
            //    var sample = (short)(sampleValue * Int16.MaxValue);
            //    var bytes = BitConverter.GetBytes(sample);
            //    raw[n * 2] = bytes[0];
            //    raw[n * 2 + 1] = bytes[1];
            //}

            var ms = new MemoryStream(raw);
            var rs =
                new RawSourceWaveStream(ms, new WaveFormat(sampleRate, 16, 1));

            //var outpath = "example.wav";
            //WaveFileWriter.CreateWaveFile(outpath, rs);

            var wo = new WaveOutEvent();
            wo.Init(rs);
            wo.Play();
            while (wo.PlaybackState == PlaybackState.Playing)
            {
                Thread.Sleep(500);
            }
            wo.Dispose();

            //Console.ReadKey();
        }
    }
}
