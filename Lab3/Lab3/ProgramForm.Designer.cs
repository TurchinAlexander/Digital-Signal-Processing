namespace Lab3
{
    partial class ProgramForm
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
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.SettingPanel = new System.Windows.Forms.Panel();
            this.lblHarmonicCount = new System.Windows.Forms.Label();
            this.txtHarmonicCount = new System.Windows.Forms.TextBox();
            this.lblSignal = new System.Windows.Forms.Label();
            this.cmbFunction = new System.Windows.Forms.ComboBox();
            this.ChartPanel = new System.Windows.Forms.Panel();
            this.chartPhase = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartAmplitude = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartFunctions = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SettingPanel.SuspendLayout();
            this.ChartPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartPhase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartAmplitude)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunctions)).BeginInit();
            this.SuspendLayout();
            // 
            // SettingPanel
            // 
            this.SettingPanel.Controls.Add(this.lblHarmonicCount);
            this.SettingPanel.Controls.Add(this.txtHarmonicCount);
            this.SettingPanel.Controls.Add(this.lblSignal);
            this.SettingPanel.Controls.Add(this.cmbFunction);
            this.SettingPanel.Location = new System.Drawing.Point(654, 12);
            this.SettingPanel.Name = "SettingPanel";
            this.SettingPanel.Size = new System.Drawing.Size(230, 602);
            this.SettingPanel.TabIndex = 1;
            // 
            // lblHarmonicCount
            // 
            this.lblHarmonicCount.AutoSize = true;
            this.lblHarmonicCount.Location = new System.Drawing.Point(38, 181);
            this.lblHarmonicCount.Name = "lblHarmonicCount";
            this.lblHarmonicCount.Size = new System.Drawing.Size(118, 13);
            this.lblHarmonicCount.TabIndex = 3;
            this.lblHarmonicCount.Text = "Количество гармоник";
            // 
            // txtHarmonicCount
            // 
            this.txtHarmonicCount.Location = new System.Drawing.Point(41, 197);
            this.txtHarmonicCount.Name = "txtHarmonicCount";
            this.txtHarmonicCount.Size = new System.Drawing.Size(100, 20);
            this.txtHarmonicCount.TabIndex = 2;
            this.txtHarmonicCount.Text = "10";
            // 
            // lblSignal
            // 
            this.lblSignal.AutoSize = true;
            this.lblSignal.Location = new System.Drawing.Point(12, 4);
            this.lblSignal.Name = "lblSignal";
            this.lblSignal.Size = new System.Drawing.Size(43, 13);
            this.lblSignal.TabIndex = 1;
            this.lblSignal.Text = "Сигнал";
            // 
            // cmbFunction
            // 
            this.cmbFunction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFunction.Items.AddRange(new object[] {
            "1. Гармонический",
            "2. Полигармонический"});
            this.cmbFunction.Location = new System.Drawing.Point(12, 25);
            this.cmbFunction.Name = "cmbFunction";
            this.cmbFunction.Size = new System.Drawing.Size(198, 21);
            this.cmbFunction.TabIndex = 0;
            this.cmbFunction.SelectedIndexChanged += new System.EventHandler(this.cmbFunction_SelectedIndexChanged);
            // 
            // ChartPanel
            // 
            this.ChartPanel.Controls.Add(this.chartPhase);
            this.ChartPanel.Controls.Add(this.chartAmplitude);
            this.ChartPanel.Controls.Add(this.chartFunctions);
            this.ChartPanel.Location = new System.Drawing.Point(12, 12);
            this.ChartPanel.Name = "ChartPanel";
            this.ChartPanel.Size = new System.Drawing.Size(636, 602);
            this.ChartPanel.TabIndex = 2;
            // 
            // chartPhase
            // 
            chartArea1.Name = "ChartArea1";
            this.chartPhase.ChartAreas.Add(chartArea1);
            this.chartPhase.Location = new System.Drawing.Point(314, 330);
            this.chartPhase.Name = "chartPhase";
            series1.ChartArea = "ChartArea1";
            series1.Name = "Series1";
            this.chartPhase.Series.Add(series1);
            this.chartPhase.Size = new System.Drawing.Size(311, 260);
            this.chartPhase.TabIndex = 2;
            this.chartPhase.Text = "chart3";
            // 
            // chartAmplitude
            // 
            chartArea2.Name = "ChartArea1";
            this.chartAmplitude.ChartAreas.Add(chartArea2);
            this.chartAmplitude.Location = new System.Drawing.Point(12, 330);
            this.chartAmplitude.Name = "chartAmplitude";
            series2.ChartArea = "ChartArea1";
            series2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            series2.Name = "Series1";
            this.chartAmplitude.Series.Add(series2);
            this.chartAmplitude.Size = new System.Drawing.Size(296, 260);
            this.chartAmplitude.TabIndex = 1;
            // 
            // chartFunctions
            // 
            this.chartFunctions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea3.Name = "ChartArea1";
            this.chartFunctions.ChartAreas.Add(chartArea3);
            legend1.Name = "Legend1";
            legend1.Title = "Сигналы";
            this.chartFunctions.Legends.Add(legend1);
            this.chartFunctions.Location = new System.Drawing.Point(12, 3);
            this.chartFunctions.Name = "chartFunctions";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.Color = System.Drawing.Color.Red;
            series3.Legend = "Legend1";
            series3.Name = "Исходный";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series4.Legend = "Legend1";
            series4.Name = "Восст.";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series5.Legend = "Legend1";
            series5.Name = "Восст. без фаз";
            this.chartFunctions.Series.Add(series3);
            this.chartFunctions.Series.Add(series4);
            this.chartFunctions.Series.Add(series5);
            this.chartFunctions.Size = new System.Drawing.Size(613, 310);
            this.chartFunctions.TabIndex = 0;
            // 
            // ProgramForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 627);
            this.Controls.Add(this.ChartPanel);
            this.Controls.Add(this.SettingPanel);
            this.Name = "ProgramForm";
            this.Text = "ProgramForm";
            this.SettingPanel.ResumeLayout(false);
            this.SettingPanel.PerformLayout();
            this.ChartPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartPhase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartAmplitude)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunctions)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel SettingPanel;
        private System.Windows.Forms.Panel ChartPanel;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartPhase;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartAmplitude;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunctions;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ComboBox cmbFunction;
        private System.Windows.Forms.Label lblHarmonicCount;
        private System.Windows.Forms.TextBox txtHarmonicCount;
        private System.Windows.Forms.Label lblSignal;
    }
}