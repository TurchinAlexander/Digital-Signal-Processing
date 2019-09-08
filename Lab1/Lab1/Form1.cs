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
using Signals;

namespace Lab1
{
    public partial class Lab1 : Form
    {
        private static double PI = Math.PI;

        private readonly double[] phases = {0, PI / 6, PI / 4, PI / 2, PI};
        private readonly string[] phasesText = {"0", "π/6", "π/4", "π/2", "π"};

        private Data data;

        public Lab1()
        {
            InitializeComponent();
            ShowBarValue(barAmplitude, txtAmplitude, out data.amplitude);
            ShowBarValue(barFrequency, txtFrequency, out data.frequency);
            ShowBarValue(barTime, txtTime, out data.time);
            ShowBarPhaseValue(barPhase, txtPhase, out data.startPhase);

            data.samplingFrequency = 800;

            ConfigureAxis(chart1.ChartAreas[0].AxisX);
            ConfigureAxis(chart1.ChartAreas[0].AxisY);

            chart1.ChartAreas[0].AxisY.Maximum = 10;

        }

        #region ControlEvents

        private void BarAmplitude_Scroll(object sender, EventArgs e)
        {
            ShowBarValue(sender, txtAmplitude, out data.amplitude);
        }

        private void BarFrequency_Scroll(object sender, EventArgs e)
        {
            ShowBarValue(sender, txtFrequency, out data.frequency);
        }

        private void BarTime_Scroll(object sender, EventArgs e)
        {
            ShowBarValue(sender, txtTime, out data.time);
        }

        private void BarPhase_Scroll(object sender, EventArgs e)
        {
            ShowBarPhaseValue(sender, txtPhase, out data.startPhase);
        }

        private void BtnGenerate_Click(object sender, EventArgs e)
        {
            BaseSignal signal = new ImpulseSignal(0.5);

            var results = signal.GetResultValues(data);

            CreateChartFunction(results);
        }

        #endregion

        private void ConfigureAxis(Axis axis)
        {
            axis.IsMarginVisible = false;
            //axis.LineWidth = 2;
            axis.Crossing = 0;
        }

        private void ShowBarPhaseValue(object trackBar, TextBox textBox, out double value)
        {
            var bar = trackBar as TrackBar;
            if (bar == null)
            {
                throw new ArgumentException(nameof(trackBar));
            }

            var text = textBox as TextBox;
            if (text == null)
            {
                throw new ArgumentException(nameof(textBox));
            }

            if (bar.Value >= phases.Length)
            {
                throw new ArgumentOutOfRangeException(nameof(bar.Value));
            }

            text.Text = phasesText[bar.Value];
            value = phases[bar.Value];
        }

        private void ShowBarValue(object trackBar, object textBox, out int value)
        {
            var bar = trackBar as TrackBar;
            if (bar == null)
            {
                throw new ArgumentException(nameof(trackBar));
            }

            var text = textBox as TextBox;
            if (text == null)
            {
                throw new ArgumentException(nameof(textBox));
            }

            value = bar.Value;
            text.Text = bar.Value.ToString();
            
        }
        
        private void CreateChartFunction(double[][] results)
        {
            chart1.Series[0].Points.Clear();
            //chart1.Series.Add("Series1");

            foreach (var point in results)
            {
                chart1.Series[0].Points.AddXY(point[0], point[1]);
            }

            
        }
    }
}
