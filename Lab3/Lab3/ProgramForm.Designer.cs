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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.SettingPanel = new System.Windows.Forms.Panel();
            this.lblHarmonicCount = new System.Windows.Forms.Label();
            this.txtHarmonicCount = new System.Windows.Forms.TextBox();
            this.lblSignal = new System.Windows.Forms.Label();
            this.cmbFunction = new System.Windows.Forms.ComboBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.chartPhase = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartAmplitude = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartFunctions = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.SettingPanel.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartPhase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartAmplitude)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunctions)).BeginInit();
            this.SuspendLayout();
            // 
            // SettingPanel
            // 
            this.SettingPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.txtHarmonicCount.Text = "100";
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
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.chartFunctions, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel1, 0, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(630, 595);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.chartAmplitude, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.chartPhase, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 300);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(624, 292);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // chartPhase
            // 
            this.chartPhase.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea3.Name = "ChartArea1";
            this.chartPhase.ChartAreas.Add(chartArea3);
            this.chartPhase.Location = new System.Drawing.Point(315, 3);
            this.chartPhase.Name = "chartPhase";
            series5.ChartArea = "ChartArea1";
            series5.Name = "Series1";
            this.chartPhase.Series.Add(series5);
            this.chartPhase.Size = new System.Drawing.Size(306, 286);
            this.chartPhase.TabIndex = 2;
            this.chartPhase.Text = "chart3";
            // 
            // chartAmplitude
            // 
            this.chartAmplitude.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea2.Name = "ChartArea1";
            this.chartAmplitude.ChartAreas.Add(chartArea2);
            this.chartAmplitude.Location = new System.Drawing.Point(3, 3);
            this.chartAmplitude.Name = "chartAmplitude";
            series4.ChartArea = "ChartArea1";
            series4.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            series4.Name = "Series1";
            this.chartAmplitude.Series.Add(series4);
            this.chartAmplitude.Size = new System.Drawing.Size(306, 286);
            this.chartAmplitude.TabIndex = 1;
            // 
            // chartFunctions
            // 
            this.chartFunctions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.chartFunctions.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            legend1.Title = "Сигналы";
            this.chartFunctions.Legends.Add(legend1);
            this.chartFunctions.Location = new System.Drawing.Point(3, 3);
            this.chartFunctions.Name = "chartFunctions";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Color = System.Drawing.Color.Red;
            series1.Legend = "Legend1";
            series1.Name = "Исходный";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Legend = "Legend1";
            series2.Name = "Восст.";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.Legend = "Legend1";
            series3.Name = "Восст. без фаз";
            this.chartFunctions.Series.Add(series1);
            this.chartFunctions.Series.Add(series2);
            this.chartFunctions.Series.Add(series3);
            this.chartFunctions.Size = new System.Drawing.Size(624, 291);
            this.chartFunctions.TabIndex = 0;
            // 
            // ProgramForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 627);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.SettingPanel);
            this.Name = "ProgramForm";
            this.Text = "ProgramForm";
            this.SettingPanel.ResumeLayout(false);
            this.SettingPanel.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartPhase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartAmplitude)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunctions)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel SettingPanel;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ComboBox cmbFunction;
        private System.Windows.Forms.Label lblHarmonicCount;
        private System.Windows.Forms.TextBox txtHarmonicCount;
        private System.Windows.Forms.Label lblSignal;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunctions;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartAmplitude;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartPhase;
    }
}