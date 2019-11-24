using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SignalExamples;
using SignalProcessing;

namespace Lab3
{
    public partial class ProgramForm : Form
    {
        private const int SamplingFrequency = 1024;
        private const int InitialFunctionSeries = 0;
        private const int RestoredFunctionSeries = 1;
        private const int RestoredWithoutPhaseFunctionSeries = 2;


        private readonly ISignal harmonicSignal = new HarmonicSignal();
        private readonly ISignal polyharmonicSignal = new PolyharmonicSignal();

        private readonly DigitalFourierTransform dft = new DigitalFourierTransform(SamplingFrequency);

        private ISignal signal;
        private int countOfHarmonics = 0;

        public ProgramForm()
        {
            InitializeComponent();

            cmbFunction.SelectedIndex = 0;
        }

        private void cmbFunction_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = ((ComboBox) sender).SelectedIndex;
            countOfHarmonics = int.Parse(txtHarmonicCount.Text);

            ChooseSignal(index);
            DrawCharts();
        }

        private void ChooseSignal(int index)
        {
            switch (index)
            {
                case 0:
                    signal = harmonicSignal;
                    break;
                case 1:
                    signal = polyharmonicSignal;
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(index));
            }
        }

        private void DrawCharts()
        {
            double[] funcValues = GetFuncValues();

            DrawInitialFunction(funcValues);

            Harmonic[] harmonics = dft.GetFrequencyResponse(funcValues, countOfHarmonics);

            DrawSpectrums(harmonics);
        }

        private void DrawSpectrums(Harmonic[] harmonics)
        {
            var amplitudePoints = chartAmplitude.Series[0].Points;
            var phasePoints = chartPhase.Series[0].Points;

            amplitudePoints.Clear();
            phasePoints.Clear();

            for (int i = 0; i < harmonics.Length; i++)
            {
                amplitudePoints.AddXY(i, harmonics[i].Amplitude);
                phasePoints.AddXY(i, harmonics[i].Phase);
            }
        }

        private void DrawInitialFunction(double[] funcValues)
        {
            var series = chartFunctions.Series[InitialFunctionSeries];

            series.Points.Clear();

            for (int i = 0; i < SamplingFrequency; i++)
            {
                series.Points.AddXY(i, funcValues[i]);
            }

        }

        private double[] GetFuncValues()
        {
            double[] result = new double[SamplingFrequency];

            for (int i = 0; i < SamplingFrequency; i++)
            {
                result[i] = signal.Calculate((double) i / SamplingFrequency);
            }

            return result;
        }
    }
}
