namespace SignalProcessing
{
    /// <summary>
    /// Represents a class to store harmonic values;
    /// </summary>
    public class Harmonic
    {
        public int Frequency { get; }

        public double Amplitude { get;}

        public double Phase { get; }

        public Harmonic(int frequency, double amplitude, double phase)
        {
            Frequency = frequency;
            Amplitude = amplitude;
            Phase = phase;
        }
    }
}