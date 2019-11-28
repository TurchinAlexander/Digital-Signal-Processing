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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.SettingPanel = new System.Windows.Forms.Panel();
            this.cmbFilter = new System.Windows.Forms.ComboBox();
            this.chkSmoothing = new System.Windows.Forms.CheckBox();
            this.txtHighPassFilter = new System.Windows.Forms.TextBox();
            this.txtLowPassFilter = new System.Windows.Forms.TextBox();
            this.chkHighPassFilter = new System.Windows.Forms.CheckBox();
            this.chkLowPassFilter = new System.Windows.Forms.CheckBox();
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
            this.tabSpectrums = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.chartFilteredAmplitude = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartFilteredPhase = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.SettingPanel.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunctions)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartAmplitude)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartPhase)).BeginInit();
            this.tabSpectrums.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFilteredAmplitude)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartFilteredPhase)).BeginInit();
            this.SuspendLayout();
            // 
            // SettingPanel
            // 
            this.SettingPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SettingPanel.Controls.Add(this.cmbFilter);
            this.SettingPanel.Controls.Add(this.chkSmoothing);
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
            // cmbFilter
            // 
            this.cmbFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFilter.Items.AddRange(new object[] {
            "1. Скользящее усреднение",
            "2. Парабола 4 степени",
            "3. Медианная фильтрация"});
            this.cmbFilter.Location = new System.Drawing.Point(15, 202);
            this.cmbFilter.Name = "cmbFilter";
            this.cmbFilter.Size = new System.Drawing.Size(194, 21);
            this.cmbFilter.TabIndex = 10;
            // 
            // chkSmoothing
            // 
            this.chkSmoothing.AutoSize = true;
            this.chkSmoothing.Location = new System.Drawing.Point(19, 179);
            this.chkSmoothing.Name = "chkSmoothing";
            this.chkSmoothing.Size = new System.Drawing.Size(94, 17);
            this.chkSmoothing.TabIndex = 9;
            this.chkSmoothing.Text = "Сглаживание";
            this.chkSmoothing.UseVisualStyleBackColor = true;
            // 
            // txtHighPassFilter
            // 
            this.txtHighPassFilter.Location = new System.Drawing.Point(109, 140);
            this.txtHighPassFilter.Name = "txtHighPassFilter";
            this.txtHighPassFilter.Size = new System.Drawing.Size(100, 20);
            this.txtHighPassFilter.TabIndex = 8;
            this.txtHighPassFilter.Text = "10";
            // 
            // txtLowPassFilter
            // 
            this.txtLowPassFilter.Location = new System.Drawing.Point(110, 114);
            this.txtLowPassFilter.Name = "txtLowPassFilter";
            this.txtLowPassFilter.Size = new System.Drawing.Size(100, 20);
            this.txtLowPassFilter.TabIndex = 7;
            this.txtLowPassFilter.Text = "3";
            // 
            // chkHighPassFilter
            // 
            this.chkHighPassFilter.AutoSize = true;
            this.chkHighPassFilter.Location = new System.Drawing.Point(19, 138);
            this.chkHighPassFilter.Name = "chkHighPassFilter";
            this.chkHighPassFilter.Size = new System.Drawing.Size(84, 17);
            this.chkHighPassFilter.TabIndex = 6;
            this.chkHighPassFilter.Text = "Фильтр ВЧ";
            this.chkHighPassFilter.UseVisualStyleBackColor = true;
            // 
            // chkLowPassFilter
            // 
            this.chkLowPassFilter.AutoSize = true;
            this.chkLowPassFilter.Location = new System.Drawing.Point(19, 114);
            this.chkLowPassFilter.Name = "chkLowPassFilter";
            this.chkLowPassFilter.Size = new System.Drawing.Size(85, 17);
            this.chkLowPassFilter.TabIndex = 5;
            this.chkLowPassFilter.Text = "Фильтр НЧ";
            this.chkLowPassFilter.UseVisualStyleBackColor = true;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(15, 271);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(195, 23);
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
            "2. Полигармонический",
            "3. Высокочастотный"});
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
            this.tableLayoutPanel2.Controls.Add(this.tabSpectrums, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.chartFunctions, 0, 0);
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
            chartArea5.Name = "ChartArea1";
            this.chartFunctions.ChartAreas.Add(chartArea5);
            this.chartFunctions.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            legend1.Title = "Сигналы";
            this.chartFunctions.Legends.Add(legend1);
            this.chartFunctions.Location = new System.Drawing.Point(3, 3);
            this.chartFunctions.Name = "chartFunctions";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series5.Color = System.Drawing.Color.Red;
            series5.Legend = "Legend1";
            series5.Name = "Исходный";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series6.Legend = "Legend1";
            series6.Name = "Восст.";
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series7.Legend = "Legend1";
            series7.Name = "Восст. без фаз";
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series8.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            series8.Legend = "Legend1";
            series8.Name = "Отфильтр.";
            series9.ChartArea = "ChartArea1";
            series9.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series9.Color = System.Drawing.Color.Black;
            series9.Legend = "Legend1";
            series9.Name = "Сглаженный";
            this.chartFunctions.Series.Add(series5);
            this.chartFunctions.Series.Add(series6);
            this.chartFunctions.Series.Add(series7);
            this.chartFunctions.Series.Add(series8);
            this.chartFunctions.Series.Add(series9);
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
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 6);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(607, 257);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // chartAmplitude
            // 
            chartArea1.Name = "ChartArea1";
            this.chartAmplitude.ChartAreas.Add(chartArea1);
            this.chartAmplitude.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartAmplitude.Location = new System.Drawing.Point(3, 3);
            this.chartAmplitude.Name = "chartAmplitude";
            series1.ChartArea = "ChartArea1";
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            series1.Name = "Series1";
            this.chartAmplitude.Series.Add(series1);
            this.chartAmplitude.Size = new System.Drawing.Size(297, 251);
            this.chartAmplitude.TabIndex = 1;
            // 
            // chartPhase
            // 
            chartArea2.Name = "ChartArea1";
            this.chartPhase.ChartAreas.Add(chartArea2);
            this.chartPhase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartPhase.Location = new System.Drawing.Point(306, 3);
            this.chartPhase.Name = "chartPhase";
            series2.ChartArea = "ChartArea1";
            series2.Name = "Series1";
            this.chartPhase.Series.Add(series2);
            this.chartPhase.Size = new System.Drawing.Size(298, 251);
            this.chartPhase.TabIndex = 2;
            this.chartPhase.Text = "chart3";
            // 
            // tabSpectrums
            // 
            this.tabSpectrums.Controls.Add(this.tabPage1);
            this.tabSpectrums.Controls.Add(this.tabPage2);
            this.tabSpectrums.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabSpectrums.Location = new System.Drawing.Point(3, 300);
            this.tabSpectrums.Name = "tabSpectrums";
            this.tabSpectrums.SelectedIndex = 0;
            this.tabSpectrums.Size = new System.Drawing.Size(624, 292);
            this.tabSpectrums.TabIndex = 5;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tableLayoutPanel3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(616, 266);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Спектры фильтра";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tableLayoutPanel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(616, 266);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Спекты сигнала";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.chartFilteredAmplitude, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.chartFilteredPhase, 1, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(5, 5);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(607, 257);
            this.tableLayoutPanel3.TabIndex = 5;
            // 
            // chartFilteredAmplitude
            // 
            chartArea3.Name = "ChartArea1";
            this.chartFilteredAmplitude.ChartAreas.Add(chartArea3);
            this.chartFilteredAmplitude.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartFilteredAmplitude.Location = new System.Drawing.Point(3, 3);
            this.chartFilteredAmplitude.Name = "chartFilteredAmplitude";
            series3.ChartArea = "ChartArea1";
            series3.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            series3.Name = "Series1";
            this.chartFilteredAmplitude.Series.Add(series3);
            this.chartFilteredAmplitude.Size = new System.Drawing.Size(297, 251);
            this.chartFilteredAmplitude.TabIndex = 1;
            // 
            // chartFilteredPhase
            // 
            chartArea4.Name = "ChartArea1";
            this.chartFilteredPhase.ChartAreas.Add(chartArea4);
            this.chartFilteredPhase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartFilteredPhase.Location = new System.Drawing.Point(306, 3);
            this.chartFilteredPhase.Name = "chartFilteredPhase";
            series4.ChartArea = "ChartArea1";
            series4.Name = "Series1";
            this.chartFilteredPhase.Series.Add(series4);
            this.chartFilteredPhase.Size = new System.Drawing.Size(298, 251);
            this.chartFilteredPhase.TabIndex = 2;
            this.chartFilteredPhase.Text = "chart3";
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
            this.tabSpectrums.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartFilteredAmplitude)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartFilteredPhase)).EndInit();
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
        private System.Windows.Forms.CheckBox chkSmoothing;
        private System.Windows.Forms.ComboBox cmbFilter;
        private System.Windows.Forms.TabControl tabSpectrums;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFilteredAmplitude;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFilteredPhase;
    }
}