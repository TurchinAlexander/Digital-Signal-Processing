using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
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
        private const int FilteredFunction = 3;
        private const int SmoothingFunction = 4;


        private readonly ISignal harmonicSignal = new HarmonicSignal();
        private readonly ISignal polyharmonicSignal = new PolyharmonicSignal();
        private readonly ISignal highFrequenciesSignal = new HighFrequenciesSignal();

        private readonly DigitalFourierTransform dft = new DigitalFourierTransform(SamplingFrequency);

        private ISignal signal;
        private int countOfHarmonics = 0;

        public ProgramForm()
        {
            InitializeComponent();

            cmbFunction.SelectedIndex = 0;
            cmbFilter.SelectedIndex = 0;
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
                case 2:
                    signal = highFrequenciesSignal;
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(index));
            }
        }

        private void DrawCharts()
        {
            double[] funcValues = GetFuncValues();

            ClearChartFunction();
            DrawInitialFunction(funcValues);

            Harmonic[] harmonics = dft.GetFrequencyResponse(funcValues, countOfHarmonics);

            DrawSpectrums(harmonics);

            Func<double, double> restoredFunction = RestoreFunction.FromHarmonics(harmonics);
            Func<double, double> restoredWithoutPhaseFunction = RestoreFunction.FromHarmonicsWithoutPhase(harmonics);

            DrawFunction(restoredFunction, chartFunctions.Series[RestoredFunctionSeries]);
            DrawFunction(restoredWithoutPhaseFunction, chartFunctions.Series[RestoredWithoutPhaseFunctionSeries]);
            
            DrawFilteredFunction(harmonics);

            if (chkSmoothing.Checked)
            {
                double[] filterValues = DrawSmoothingFunction(funcValues);
                Harmonic[] filterHarmonics = dft.GetFrequencyResponse(filterValues, countOfHarmonics);

                DrawFilteredSpectrums(filterHarmonics);
            }
        }

        private void DrawFilteredSpectrums(Harmonic[] harmonics)
        {
            var amplitudePoints = chartFilteredAmplitude.Series[0].Points;
            var phasePoints = chartFilteredPhase.Series[0].Points;

            amplitudePoints.Clear();
            phasePoints.Clear();

            for (int i = 0; i < harmonics.Length; i++)
            {
                amplitudePoints.AddXY(i, harmonics[i].Amplitude);
                phasePoints.AddXY(i, harmonics[i].Phase);
            }
        }

        private void ClearChartFunction()
        {
            foreach (var series in chartFunctions.Series)
            {
                series.Points.Clear();
            }
        }

        private double[] DrawSmoothingFunction(double[] funcValues)
        {
            double[] output;

            switch (cmbFilter.SelectedIndex)
            {
                case 0:
                    output = SignalSmoothing.ByArithmeticAveraging(funcValues, 5);
                    break;
                case 1:
                    output = SignalSmoothing.ByParabola4(funcValues);
                    break;
                case 2:
                    output = SignalSmoothing.ByMedianFiltering(funcValues, 5);
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(cmbFilter.SelectedIndex));
            }

            DrawFunctionByPoints(output, chartFunctions.Series[SmoothingFunction]);

            return output;
        }

        private void DrawFunctionByPoints(double[] output, Series series)
        {
            for (int i = 0; i < SamplingFrequency; i++)
            {
                series.Points.AddXY(i, output[i]);
            }
        }

        private void DrawFilteredFunction(Harmonic[] harmonics)
        {
            int start = 0;
            int end = 0;
            bool noChecked = true;

            if (chkLowPassFilter.Checked)
            {
                end = int.Parse(txtLowPassFilter.Text);
                noChecked = false;
            }

            if (chkHighPassFilter.Checked)
            {
                start = int.Parse(txtHighPassFilter.Text);
                noChecked = false;
            }

            if (noChecked)
            {
                if (chartFunctions.Series[FilteredFunction].Points.Count > 0)
                {
                    chartFunctions.Series[FilteredFunction].Points.Clear();
                }

                return;
            }

            Func<double, double> filteredFunction = RestoreFunction.FromHarmonics(harmonics, start, end);

            DrawFunction(filteredFunction, chartFunctions.Series[FilteredFunction]);
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

            for (int i = 0; i < SamplingFrequency; i++)
            {
                series.Points.AddXY(i, funcValues[i]);
            }

        }

        private void DrawFunction(Func<double, double> func, Series series)
        {
            for (int i = 0; i < SamplingFrequency; i++)
            {
                series.Points.AddXY(i, func((double) i / SamplingFrequency));
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

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int index = cmbFunction.SelectedIndex;
            countOfHarmonics = int.Parse(txtHarmonicCount.Text);

            ChooseSignal(index);
            DrawCharts();
        }
    }
}
