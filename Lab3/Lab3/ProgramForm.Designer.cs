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
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.SettingPanel = new System.Windows.Forms.Panel();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblHarmonicCount = new System.Windows.Forms.Label();
            this.txtHarmonicCount = new System.Windows.Forms.TextBox();
            this.lblSignal = new System.Windows.Forms.Label();
            this.cmbFunction = new System.Windows.Forms.ComboBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.chartFunctions = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.chartAmplitude = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartPhase = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chkLowPassFilter = new System.Windows.Forms.CheckBox();
            this.chkHighPassFilter = new System.Windows.Forms.CheckBox();
            this.txtLowPassFilter = new System.Windows.Forms.TextBox();
            this.txtHighPassFilter = new System.Windows.Forms.TextBox();
            this.SettingPanel.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunctions)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartAmplitude)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartPhase)).BeginInit();
            this.SuspendLayout();
            // 
            // SettingPanel
            // 
            this.SettingPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SettingPanel.Controls.Add(this.txtHighPassFilter);
            this.SettingPanel.Controls.Add(this.txtLowPassFilter);
            this.SettingPanel.Controls.Add(this.chkHighPassFilter);
            this.SettingPanel.Controls.Add(this.chkLowPassFilter);
            this.SettingPanel.Controls.Add(this.btnCalculate);
            this.SettingPanel.Controls.Add(this.lblHarmonicCount);
            this.SettingPanel.Controls.Add(this.txtHarmonicCount);
            this.SettingPanel.Controls.Add(this.lblSignal);
            this.SettingPanel.Controls.Add(this.cmbFunction);
            this.SettingPanel.Location = new System.Drawing.Point(654, 12);
            this.SettingPanel.Name = "SettingPanel";
            this.SettingPanel.Size = new System.Drawing.Size(230, 602);
            this.SettingPanel.TabIndex = 1;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(12, 102);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(118, 23);
            this.btnCalculate.TabIndex = 4;
            this.btnCalculate.Text = "Вычислить";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblHarmonicCount
            // 
            this.lblHarmonicCount.AutoSize = true;
            this.lblHarmonicCount.Location = new System.Drawing.Point(12, 59);
            this.lblHarmonicCount.Name = "lblHarmonicCount";
            this.lblHarmonicCount.Size = new System.Drawing.Size(118, 13);
            this.lblHarmonicCount.TabIndex = 3;
            this.lblHarmonicCount.Text = "Количество гармоник";
            // 
            // txtHarmonicCount
            // 
            this.txtHarmonicCount.Location = new System.Drawing.Point(15, 75);
            this.txtHarmonicCount.Name = "txtHarmonicCount";
            this.txtHarmonicCount.Size = new System.Drawing.Size(115, 20);
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
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series4.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            series4.Legend = "Legend1";
            series4.Name = "Отфильтр.";
            this.chartFunctions.Series.Add(series1);
            this.chartFunctions.Series.Add(series2);
            this.chartFunctions.Series.Add(series3);
            this.chartFunctions.Series.Add(series4);
            this.chartFunctions.Size = new System.Drawing.Size(624, 291);
            this.chartFunctions.TabIndex = 0;
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
            // chartAmplitude
            // 
            this.chartAmplitude.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea2.Name = "ChartArea1";
            this.chartAmplitude.ChartAreas.Add(chartArea2);
            this.chartAmplitude.Location = new System.Drawing.Point(3, 3);
            this.chartAmplitude.Name = "chartAmplitude";
            series5.ChartArea = "ChartArea1";
            series5.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            series5.Name = "Series1";
            this.chartAmplitude.Series.Add(series5);
            this.chartAmplitude.Size = new System.Drawing.Size(306, 286);
            this.chartAmplitude.TabIndex = 1;
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
            series6.ChartArea = "ChartArea1";
            series6.Name = "Series1";
            this.chartPhase.Series.Add(series6);
            this.chartPhase.Size = new System.Drawing.Size(306, 286);
            this.chartPhase.TabIndex = 2;
            this.chartPhase.Text = "chart3";
            // 
            // chkLowPassFilter
            // 
            this.chkLowPassFilter.AutoSize = true;
            this.chkLowPassFilter.Location = new System.Drawing.Point(15, 143);
            this.chkLowPassFilter.Name = "chkLowPassFilter";
            this.chkLowPassFilter.Size = new System.Drawing.Size(85, 17);
            this.chkLowPassFilter.TabIndex = 5;
            this.chkLowPassFilter.Text = "Фильтр НЧ";
            this.chkLowPassFilter.UseVisualStyleBackColor = true;
            // 
            // chkHighPassFilter
            // 
            this.chkHighPassFilter.AutoSize = true;
            this.chkHighPassFilter.Location = new System.Drawing.Point(15, 167);
            this.chkHighPassFilter.Name = "chkHighPassFilter";
            this.chkHighPassFilter.Size = new System.Drawing.Size(84, 17);
            this.chkHighPassFilter.TabIndex = 6;
            this.chkHighPassFilter.Text = "Фильтр ВЧ";
            this.chkHighPassFilter.UseVisualStyleBackColor = true;
            // 
            // txtLowPassFilter
            // 
            this.txtLowPassFilter.Location = new System.Drawing.Point(106, 143);
            this.txtLowPassFilter.Name = "txtLowPassFilter";
            this.txtLowPassFilter.Size = new System.Drawing.Size(100, 20);
            this.txtLowPassFilter.TabIndex = 7;
            this.txtLowPassFilter.Text = "3";
            // 
            // txtHighPassFilter
            // 
            this.txtHighPassFilter.Location = new System.Drawing.Point(105, 169);
            this.txtHighPassFilter.Name = "txtHighPassFilter";
            this.txtHighPassFilter.Size = new System.Drawing.Size(100, 20);
            this.txtHighPassFilter.TabIndex = 8;
            this.txtHighPassFilter.Text = "10";
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
            ((System.ComponentModel.ISupportInitialize)(this.chartFunctions)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartAmplitude)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartPhase)).EndInit();
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
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox txtHighPassFilter;
        private System.Windows.Forms.TextBox txtLowPassFilter;
        private System.Windows.Forms.CheckBox chkHighPassFilter;
        private System.Windows.Forms.CheckBox chkLowPassFilter;
    }
}