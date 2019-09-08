namespace Lab1
{
    partial class Lab1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.barAmplitude = new System.Windows.Forms.TrackBar();
            this.barFrequency = new System.Windows.Forms.TrackBar();
            this.barPhase = new System.Windows.Forms.TrackBar();
            this.lblAmplitude = new System.Windows.Forms.Label();
            this.lblFrequency = new System.Windows.Forms.Label();
            this.lblPhase = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.barTime = new System.Windows.Forms.TrackBar();
            this.txtAmplitude = new System.Windows.Forms.TextBox();
            this.txtFrequency = new System.Windows.Forms.TextBox();
            this.txtPhase = new System.Windows.Forms.TextBox();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barAmplitude)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barFrequency)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barPhase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barTime)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(0, -3);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series1.BorderColor = System.Drawing.Color.Transparent;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Color = System.Drawing.Color.Red;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series1.YValuesPerPoint = 2;
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(837, 300);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // barAmplitude
            // 
            this.barAmplitude.LargeChange = 1;
            this.barAmplitude.Location = new System.Drawing.Point(98, 400);
            this.barAmplitude.Minimum = 1;
            this.barAmplitude.Name = "barAmplitude";
            this.barAmplitude.Size = new System.Drawing.Size(798, 45);
            this.barAmplitude.TabIndex = 1;
            this.barAmplitude.Value = 1;
            this.barAmplitude.Scroll += new System.EventHandler(this.BarAmplitude_Scroll);
            // 
            // barFrequency
            // 
            this.barFrequency.LargeChange = 1;
            this.barFrequency.Location = new System.Drawing.Point(98, 451);
            this.barFrequency.Minimum = 1;
            this.barFrequency.Name = "barFrequency";
            this.barFrequency.Size = new System.Drawing.Size(798, 45);
            this.barFrequency.TabIndex = 2;
            this.barFrequency.Value = 1;
            this.barFrequency.Scroll += new System.EventHandler(this.BarFrequency_Scroll);
            // 
            // barPhase
            // 
            this.barPhase.LargeChange = 1;
            this.barPhase.Location = new System.Drawing.Point(98, 502);
            this.barPhase.Maximum = 4;
            this.barPhase.Name = "barPhase";
            this.barPhase.Size = new System.Drawing.Size(798, 45);
            this.barPhase.TabIndex = 3;
            this.barPhase.Scroll += new System.EventHandler(this.BarPhase_Scroll);
            // 
            // lblAmplitude
            // 
            this.lblAmplitude.AutoSize = true;
            this.lblAmplitude.Location = new System.Drawing.Point(0, 400);
            this.lblAmplitude.Name = "lblAmplitude";
            this.lblAmplitude.Size = new System.Drawing.Size(53, 13);
            this.lblAmplitude.TabIndex = 4;
            this.lblAmplitude.Text = "Amplitude";
            // 
            // lblFrequency
            // 
            this.lblFrequency.AutoSize = true;
            this.lblFrequency.Location = new System.Drawing.Point(0, 451);
            this.lblFrequency.Name = "lblFrequency";
            this.lblFrequency.Size = new System.Drawing.Size(57, 13);
            this.lblFrequency.TabIndex = 5;
            this.lblFrequency.Text = "Frequency";
            // 
            // lblPhase
            // 
            this.lblPhase.AutoSize = true;
            this.lblPhase.Location = new System.Drawing.Point(-3, 502);
            this.lblPhase.Name = "lblPhase";
            this.lblPhase.Size = new System.Drawing.Size(37, 13);
            this.lblPhase.TabIndex = 6;
            this.lblPhase.Text = "Phase";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(-3, 553);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(30, 13);
            this.lblTime.TabIndex = 8;
            this.lblTime.Text = "Time";
            // 
            // barTime
            // 
            this.barTime.LargeChange = 1;
            this.barTime.Location = new System.Drawing.Point(98, 553);
            this.barTime.Maximum = 3;
            this.barTime.Minimum = 1;
            this.barTime.Name = "barTime";
            this.barTime.Size = new System.Drawing.Size(798, 45);
            this.barTime.TabIndex = 7;
            this.barTime.Value = 1;
            this.barTime.Scroll += new System.EventHandler(this.BarTime_Scroll);
            // 
            // txtAmplitude
            // 
            this.txtAmplitude.Location = new System.Drawing.Point(914, 400);
            this.txtAmplitude.Name = "txtAmplitude";
            this.txtAmplitude.ReadOnly = true;
            this.txtAmplitude.Size = new System.Drawing.Size(58, 20);
            this.txtAmplitude.TabIndex = 9;
            // 
            // txtFrequency
            // 
            this.txtFrequency.Location = new System.Drawing.Point(914, 448);
            this.txtFrequency.Name = "txtFrequency";
            this.txtFrequency.ReadOnly = true;
            this.txtFrequency.Size = new System.Drawing.Size(58, 20);
            this.txtFrequency.TabIndex = 10;
            // 
            // txtPhase
            // 
            this.txtPhase.Location = new System.Drawing.Point(914, 499);
            this.txtPhase.Name = "txtPhase";
            this.txtPhase.ReadOnly = true;
            this.txtPhase.Size = new System.Drawing.Size(58, 20);
            this.txtPhase.TabIndex = 11;
            // 
            // txtTime
            // 
            this.txtTime.Location = new System.Drawing.Point(914, 546);
            this.txtTime.Name = "txtTime";
            this.txtTime.ReadOnly = true;
            this.txtTime.Size = new System.Drawing.Size(58, 20);
            this.txtTime.TabIndex = 12;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(880, 88);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(75, 23);
            this.btnGenerate.TabIndex = 13;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.BtnGenerate_Click);
            // 
            // Lab1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 755);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.txtTime);
            this.Controls.Add(this.txtPhase);
            this.Controls.Add(this.txtFrequency);
            this.Controls.Add(this.txtAmplitude);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.barTime);
            this.Controls.Add(this.lblPhase);
            this.Controls.Add(this.lblFrequency);
            this.Controls.Add(this.lblAmplitude);
            this.Controls.Add(this.barPhase);
            this.Controls.Add(this.barFrequency);
            this.Controls.Add(this.barAmplitude);
            this.Controls.Add(this.chart1);
            this.Name = "Lab1";
            this.Text = "Lab work 1";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barAmplitude)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barFrequency)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barPhase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barTime)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.TrackBar barAmplitude;
        private System.Windows.Forms.TrackBar barFrequency;
        private System.Windows.Forms.TrackBar barPhase;
        private System.Windows.Forms.Label lblAmplitude;
        private System.Windows.Forms.Label lblFrequency;
        private System.Windows.Forms.Label lblPhase;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.TrackBar barTime;
        private System.Windows.Forms.TextBox txtAmplitude;
        private System.Windows.Forms.TextBox txtFrequency;
        private System.Windows.Forms.TextBox txtPhase;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.Button btnGenerate;
    }
}

