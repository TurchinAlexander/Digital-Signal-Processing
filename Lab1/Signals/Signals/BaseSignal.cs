namespace Signals
{
    public abstract class BaseSignal
    {
        public double Amplitude { get; set; }

        public int Frequency { get; set; }

        public double Phase { get; set; }

        public abstract double GetFunc(double x);
    }
}