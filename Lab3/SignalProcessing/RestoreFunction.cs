using System;

namespace SignalProcessing
{
    public static class RestoreFunction
    {
        public static Func<double, double> FromHarmonics(Harmonic[] harmonics)
        {
            if (harmonics.Length <= 0)
            {
                throw new ArgumentException( "Length should greater than 0.", nameof(harmonics));
            }

            return (double x) =>
            {
                double value = harmonics[0].Amplitude / 2;

                for (int i = 1; i < harmonics.Length; i++)
                {
                    value += harmonics[i].Amplitude *
                             Math.Cos(2 * Math.PI * harmonics[i].Frequency * x - harmonics[i].Phase);
                }

                return value;
            };
        }

        public static Func<double, double> FromHarmonicsWithoutPhase(Harmonic[] harmonics)
        {
            if (harmonics.Length <= 0)
            {
                throw new ArgumentException("Length should greater than 0.", nameof(harmonics));
            }

            return (double x) =>
            {
                double value = harmonics[0].Amplitude / 2;

                for (int i = 1; i < harmonics.Length; i++)
                {
                    value += harmonics[i].Amplitude *
                             Math.Cos(2 * Math.PI * harmonics[i].Frequency * x);
                }

                return value;
            };
        }
    }
}