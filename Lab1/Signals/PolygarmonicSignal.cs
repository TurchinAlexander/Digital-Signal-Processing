namespace Signals
{
    public class PolygarmonicSignal
    {
        private BaseSignal[] signals;

        public PolygarmonicSignal(BaseSignal[] signals)
        {
            this.signals = signals;
        }

        public double GetFunc(double x)
        {
            double result = 0;
            foreach (var signal in signals)
            {
                result += signal.GetFunc(x);
            }

            return result;
        }
    }
}