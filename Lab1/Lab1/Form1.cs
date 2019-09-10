using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Signals;

namespace Lab1
{
    public partial class Lab1 : Form
    {
        private static double PI = Math.PI;

        private readonly double[] Phases = {0, PI / 6, PI / 4, PI / 2, PI};
        private readonly string[] PhasesText = {"0", "π/6", "π/4", "π/2", "π"};
        private const double DutyFactor = 0.95;
        private Data data;

        private List<Data> datas = new List<Data>();
        private List<BaseSignal> signals = new List<BaseSignal>();

        private BaseSignal signal = new SinSignal();


        public Lab1()
        {
            InitializeComponent();

            ConfigureAxis(chart1.ChartAreas[0].AxisX);
            ConfigureAxis(chart1.ChartAreas[0].AxisY);

            chart1.ChartAreas[0].AxisY.Maximum = 10;

            cmbSignals.SelectedIndex = 0;
        }

        #region ControlEvents

        private void BarAmplitude_Scroll(object sender, EventArgs e)
        {
            ShowBarValue(sender, lblAmplitudeValue, out data.amplitude);
        }

        private void BarFrequency_Scroll(object sender, EventArgs e)
        {
            ShowBarValue(sender, lblFrequencyValue, out data.frequency);
        }

        private void BarTime_Scroll(object sender, EventArgs e)
        {
            ShowBarValue(sender, lblTimeValue, out data.time);
        }

        private void BarPhase_Scroll(object sender, EventArgs e)
        {
            ShowBarPhaseValue(sender, lblPhaseValue, out data.startPhase);
        }

        private void BtnGenerate_Click(object sender, EventArgs e)
        {
            int index = lboxSignals.SelectedIndex;
            var results = signals[index].GetResultValues(datas[index]);
            CreateChartFunction(results);
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            signals.Add(signal);
            datas.Add(new Data());

            lboxSignals.Items.Add(signal.ToString());
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            int index = lboxSignals.SelectedIndex;

            if (index >= 0)
            {
                signals.RemoveAt(index);
                datas.RemoveAt(index);
                lboxSignals.Items.RemoveAt(index);
                lboxSignals.SelectedIndex = index - 1;
            }
        }

        #endregion

        private void ConfigureAxis(Axis axis)
        {
            axis.IsMarginVisible = false;
            //axis.LineWidth = 2;
            axis.Crossing = 0;
        }

        private void ShowBarPhaseValue(object trackBar, object label, out double value)
        {
            var bar = trackBar as TrackBar;
            if (bar == null)
            {
                throw new ArgumentException(nameof(trackBar));
            }

            var lbl = label as Label;
            if (lbl == null)
            {
                throw new ArgumentException(nameof(label));
            }

            if (bar.Value >= Phases.Length)
            {
                throw new ArgumentOutOfRangeException(nameof(bar.Value));
            }

            lbl.Text = PhasesText[bar.Value];
            value = Phases[bar.Value];
        }

        private void ShowBarValue(object trackBar, object label, out int value)
        {
            var bar = trackBar as TrackBar;
            if (bar == null)
            {
                throw new ArgumentException(nameof(trackBar));
            }

            var lbl = label as Label;
            if (lbl == null)
            {
                throw new ArgumentException(nameof(label));
            }

            value = bar.Value;
            lbl.Text = bar.Value.ToString();
            
        }
        
        private void CreateChartFunction(Point[] points)
        {
            chart1.Series[0].Points.Clear();
            //chart1.Series.Add("Series1");

            foreach (var point in points)
            {
                chart1.Series[0].Points.AddXY(point.X, point.Y);
            }
        }

        private void CmbSignals_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;
            if (comboBox == null)
            {
                throw new NullReferenceException(nameof(sender));
            }

            switch (comboBox.SelectedIndex)
            {
                case 0:
                    signal = new SinSignal();
                    break;
                case 1:
                    signal = new ImpulseSignal();
                    break;
                case 2:
                    signal = new TriangleSignal();
                    break;
                case 3:
                    signal = new SawtoothSignal();
                    break;
            }
        }

        private void BtnModulate_Click(object sender, EventArgs e)
        {
            CreateModulateChart();
        }

        private void CreateModulateChart()
        {
            Point[][] funcResults = new Point[signals.Count][];
            

            for(int i = 0; i < funcResults.Length; i++)
            {
                funcResults[i] = signals[i].GetResultValues(datas[i]);
            }

            Point[] result = new Point[funcResults[0].Length];

            for (int i = 0; i < funcResults[0].Length; i++)
            {
                result[i].X = funcResults[0][i].X;

                for (int y = 0; y < funcResults.Length; y++)
                {
                    result[i].Y += funcResults[y][i].Y;
                }
            }
            CreateChartFunction(result);
        }

        private void LboxSignals_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool enabled = lboxSignals.SelectedIndex >= 0;

            
            barAmplitude.Enabled = enabled;
            barFrequency.Enabled = enabled;
            barTime.Enabled = enabled;
            barDutyCycle.Enabled = enabled;

            if(enabled
                && lboxSignals.SelectedIndex < datas.Count)
            {
                data = datas[lboxSignals.SelectedIndex];
            }
            else
            {
                data = null;
                return;
            }

            barAmplitude.Value = data.amplitude;
            lblAmplitudeValue.Text = data.amplitude.ToString();

            barFrequency.Value = data.frequency;
            lblFrequencyValue.Text = data.frequency.ToString();

            //barPhase.Enabled = enabled;
            //barPhase.Value = data.p;
            //lblAmplitudeValue.Text = data.amplitude.ToString();

            barTime.Value = data.time;
            lblTimeValue.Text = data.time.ToString();

            barDutyCycle.Value = (int)(data.dutyFactor * 10);
            lblDutyCycleValue.Text = barDutyCycle.Value.ToString();
        }
    }
}
