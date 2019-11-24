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

namespace Lab2
{
    public partial class Form1 : Form
    {
        private const int N = 1024;

        private int m;
        private int phase;

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Calculate_Click(object sender, EventArgs e)
        {
            m = int.Parse(txt_M.Text);
            phase = int.Parse(txt_Phase.Text)
        }

        private Series[] GetSeries()
        {

        }
    }
}
