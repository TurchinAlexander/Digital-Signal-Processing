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
            this.btnGenerate = new System.Windows.Forms.Button();
            this.panelValues = new System.Windows.Forms.Panel();
            this.lblTimeValue = new System.Windows.Forms.Label();
            this.lblPhaseValue = new System.Windows.Forms.Label();
            this.lblFrequencyValue = new System.Windows.Forms.Label();
            this.lblAmplitudeValue = new System.Windows.Forms.Label();
            this.cmbSignals = new System.Windows.Forms.ComboBox();
            this.lboxSignals = new System.Windows.Forms.ListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnModulate = new System.Windows.Forms.Button();
            this.lblDutyCycleValue = new System.Windows.Forms.Label();
            this.lblDutyCycle = new System.Windows.Forms.Label();
            this.barDutyCycle = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barAmplitude)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barFrequency)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barPhase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barTime)).BeginInit();
            this.panelValues.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barDutyCycle)).BeginInit();
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
            this.chart1.Size = new System.Drawing.Size(742, 468);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // barAmplitude
            // 
            this.barAmplitude.Enabled = false;
            this.barAmplitude.LargeChange = 1;
            this.barAmplitude.Location = new System.Drawing.Point(62, 14);
            this.barAmplitude.Minimum = 1;
            this.barAmplitude.Name = "barAmplitude";
            this.barAmplitude.Size = new System.Drawing.Size(129, 45);
            this.barAmplitude.TabIndex = 1;
            this.barAmplitude.Value = 1;
            this.barAmplitude.Scroll += new System.EventHandler(this.BarAmplitude_Scroll);
            // 
            // barFrequency
            // 
            this.barFrequency.Enabled = false;
            this.barFrequency.LargeChange = 1;
            this.barFrequency.Location = new System.Drawing.Point(62, 65);
            this.barFrequency.Minimum = 1;
            this.barFrequency.Name = "barFrequency";
            this.barFrequency.Size = new System.Drawing.Size(129, 45);
            this.barFrequency.TabIndex = 2;
            this.barFrequency.Value = 1;
            this.barFrequency.Scroll += new System.EventHandler(this.BarFrequency_Scroll);
            // 
            // barPhase
            // 
            this.barPhase.Enabled = false;
            this.barPhase.LargeChange = 1;
            this.barPhase.Location = new System.Drawing.Point(62, 116);
            this.barPhase.Maximum = 4;
            this.barPhase.Name = "barPhase";
            this.barPhase.Size = new System.Drawing.Size(129, 45);
            this.barPhase.TabIndex = 3;
            this.barPhase.Scroll += new System.EventHandler(this.BarPhase_Scroll);
            // 
            // lblAmplitude
            // 
            this.lblAmplitude.AutoSize = true;
            this.lblAmplitude.Location = new System.Drawing.Point(3, 14);
            this.lblAmplitude.Name = "lblAmplitude";
            this.lblAmplitude.Size = new System.Drawing.Size(53, 13);
            this.lblAmplitude.TabIndex = 4;
            this.lblAmplitude.Text = "Amplitude";
            // 
            // lblFrequency
            // 
            this.lblFrequency.AutoSize = true;
            this.lblFrequency.Location = new System.Drawing.Point(3, 65);
            this.lblFrequency.Name = "lblFrequency";
            this.lblFrequency.Size = new System.Drawing.Size(57, 13);
            this.lblFrequency.TabIndex = 5;
            this.lblFrequency.Text = "Frequency";
            // 
            // lblPhase
            // 
            this.lblPhase.AutoSize = true;
            this.lblPhase.Location = new System.Drawing.Point(3, 116);
            this.lblPhase.Name = "lblPhase";
            this.lblPhase.Size = new System.Drawing.Size(37, 13);
            this.lblPhase.TabIndex = 6;
            this.lblPhase.Text = "Phase";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(3, 167);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(30, 13);
            this.lblTime.TabIndex = 8;
            this.lblTime.Text = "Time";
            // 
            // barTime
            // 
            this.barTime.Enabled = false;
            this.barTime.LargeChange = 1;
            this.barTime.Location = new System.Drawing.Point(62, 167);
            this.barTime.Maximum = 3;
            this.barTime.Minimum = 1;
            this.barTime.Name = "barTime";
            this.barTime.Size = new System.Drawing.Size(129, 45);
            this.barTime.TabIndex = 7;
            this.barTime.Value = 1;
            this.barTime.Scroll += new System.EventHandler(this.BarTime_Scroll);
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(888, 442);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(75, 23);
            this.btnGenerate.TabIndex = 13;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.BtnGenerate_Click);
            // 
            // panelValues
            // 
            this.panelValues.Controls.Add(this.lblDutyCycleValue);
            this.panelValues.Controls.Add(this.lblDutyCycle);
            this.panelValues.Controls.Add(this.barDutyCycle);
            this.panelValues.Controls.Add(this.lblTimeValue);
            this.panelValues.Controls.Add(this.lblPhaseValue);
            this.panelValues.Controls.Add(this.lblFrequencyValue);
            this.panelValues.Controls.Add(this.lblAmplitudeValue);
            this.panelValues.Controls.Add(this.lblAmplitude);
            this.panelValues.Controls.Add(this.barAmplitude);
            this.panelValues.Controls.Add(this.lblTime);
            this.panelValues.Controls.Add(this.barFrequency);
            this.panelValues.Controls.Add(this.barTime);
            this.panelValues.Controls.Add(this.barPhase);
            this.panelValues.Controls.Add(this.lblPhase);
            this.panelValues.Controls.Add(this.lblFrequency);
            this.panelValues.Location = new System.Drawing.Point(764, 152);
            this.panelValues.Name = "panelValues";
            this.panelValues.Size = new System.Drawing.Size(200, 275);
            this.panelValues.TabIndex = 14;
            // 
            // lblTimeValue
            // 
            this.lblTimeValue.AutoSize = true;
            this.lblTimeValue.Location = new System.Drawing.Point(3, 180);
            this.lblTimeValue.Name = "lblTimeValue";
            this.lblTimeValue.Size = new System.Drawing.Size(41, 13);
            this.lblTimeValue.TabIndex = 12;
            this.lblTimeValue.Text = "PValue";
            // 
            // lblPhaseValue
            // 
            this.lblPhaseValue.AutoSize = true;
            this.lblPhaseValue.Location = new System.Drawing.Point(3, 134);
            this.lblPhaseValue.Name = "lblPhaseValue";
            this.lblPhaseValue.Size = new System.Drawing.Size(41, 13);
            this.lblPhaseValue.TabIndex = 11;
            this.lblPhaseValue.Text = "PValue";
            // 
            // lblFrequencyValue
            // 
            this.lblFrequencyValue.AutoSize = true;
            this.lblFrequencyValue.Location = new System.Drawing.Point(3, 82);
            this.lblFrequencyValue.Name = "lblFrequencyValue";
            this.lblFrequencyValue.Size = new System.Drawing.Size(40, 13);
            this.lblFrequencyValue.TabIndex = 10;
            this.lblFrequencyValue.Text = "FValue";
            // 
            // lblAmplitudeValue
            // 
            this.lblAmplitudeValue.AutoSize = true;
            this.lblAmplitudeValue.Location = new System.Drawing.Point(3, 34);
            this.lblAmplitudeValue.Name = "lblAmplitudeValue";
            this.lblAmplitudeValue.Size = new System.Drawing.Size(41, 13);
            this.lblAmplitudeValue.TabIndex = 9;
            this.lblAmplitudeValue.Text = "AValue";
            // 
            // cmbSignals
            // 
            this.cmbSignals.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSignals.FormattingEnabled = true;
            this.cmbSignals.Items.AddRange(new object[] {
            "Sinus",
            "Impulse",
            "Triangle",
            "Sawtooth"});
            this.cmbSignals.Location = new System.Drawing.Point(763, 13);
            this.cmbSignals.Name = "cmbSignals";
            this.cmbSignals.Size = new System.Drawing.Size(200, 21);
            this.cmbSignals.TabIndex = 17;
            this.cmbSignals.SelectedIndexChanged += new System.EventHandler(this.CmbSignals_SelectedIndexChanged);
            // 
            // lboxSignals
            // 
            this.lboxSignals.FormattingEnabled = true;
            this.lboxSignals.Location = new System.Drawing.Point(763, 51);
            this.lboxSignals.Name = "lboxSignals";
            this.lboxSignals.Size = new System.Drawing.Size(120, 95);
            this.lboxSignals.TabIndex = 18;
            this.lboxSignals.SelectedIndexChanged += new System.EventHandler(this.LboxSignals_SelectedIndexChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(889, 51);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 19;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(889, 80);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 20;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // btnModulate
            // 
            this.btnModulate.Location = new System.Drawing.Point(785, 442);
            this.btnModulate.Name = "btnModulate";
            this.btnModulate.Size = new System.Drawing.Size(75, 23);
            this.btnModulate.TabIndex = 21;
            this.btnModulate.Text = "Modulate";
            this.btnModulate.UseVisualStyleBackColor = true;
            this.btnModulate.Click += new System.EventHandler(this.BtnModulate_Click);
            // 
            // lblDutyCycleValue
            // 
            this.lblDutyCycleValue.AutoSize = true;
            this.lblDutyCycleValue.Location = new System.Drawing.Point(3, 221);
            this.lblDutyCycleValue.Name = "lblDutyCycleValue";
            this.lblDutyCycleValue.Size = new System.Drawing.Size(41, 13);
            this.lblDutyCycleValue.TabIndex = 15;
            this.lblDutyCycleValue.Text = "PValue";
            // 
            // lblDutyCycle
            // 
            this.lblDutyCycle.AutoSize = true;
            this.lblDutyCycle.Location = new System.Drawing.Point(3, 208);
            this.lblDutyCycle.Name = "lblDutyCycle";
            this.lblDutyCycle.Size = new System.Drawing.Size(55, 13);
            this.lblDutyCycle.TabIndex = 14;
            this.lblDutyCycle.Text = "DutyCycle";
            // 
            // barDutyCycle
            // 
            this.barDutyCycle.Enabled = false;
            this.barDutyCycle.LargeChange = 1;
            this.barDutyCycle.Location = new System.Drawing.Point(62, 208);
            this.barDutyCycle.Name = "barDutyCycle";
            this.barDutyCycle.Size = new System.Drawing.Size(129, 45);
            this.barDutyCycle.TabIndex = 13;
            this.barDutyCycle.Value = 1;
            // 
            // Lab1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 477);
            this.Controls.Add(this.btnModulate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lboxSignals);
            this.Controls.Add(this.cmbSignals);
            this.Controls.Add(this.panelValues);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.chart1);
            this.Name = "Lab1";
            this.Text = "Lab work 1";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barAmplitude)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barFrequency)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barPhase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barTime)).EndInit();
            this.panelValues.ResumeLayout(false);
            this.panelValues.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.barDutyCycle)).EndInit();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Panel panelValues;
        private System.Windows.Forms.ComboBox cmbSignals;
        private System.Windows.Forms.Label lblTimeValue;
        private System.Windows.Forms.Label lblPhaseValue;
        private System.Windows.Forms.Label lblFrequencyValue;
        private System.Windows.Forms.Label lblAmplitudeValue;
        private System.Windows.Forms.ListBox lboxSignals;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnModulate;
        private System.Windows.Forms.Label lblDutyCycleValue;
        private System.Windows.Forms.Label lblDutyCycle;
        private System.Windows.Forms.TrackBar barDutyCycle;
    }
}

