namespace Lab2
{
    partial class Form1
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
            this.ch_Graph = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lbl_M = new System.Windows.Forms.Label();
            this.lbl_Phase = new System.Windows.Forms.Label();
            this.btn_Calculate = new System.Windows.Forms.Button();
            this.txt_M = new System.Windows.Forms.TextBox();
            this.txt_Phase = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ch_Graph)).BeginInit();
            this.SuspendLayout();
            // 
            // ch_Graph
            // 
            chartArea1.Name = "ChartArea1";
            this.ch_Graph.ChartAreas.Add(chartArea1);
            this.ch_Graph.Location = new System.Drawing.Point(12, 12);
            this.ch_Graph.Name = "ch_Graph";
            this.ch_Graph.Size = new System.Drawing.Size(777, 426);
            this.ch_Graph.TabIndex = 0;
            this.ch_Graph.Text = "chart1";
            // 
            // lbl_M
            // 
            this.lbl_M.AutoSize = true;
            this.lbl_M.Location = new System.Drawing.Point(819, 21);
            this.lbl_M.Name = "lbl_M";
            this.lbl_M.Size = new System.Drawing.Size(16, 13);
            this.lbl_M.TabIndex = 3;
            this.lbl_M.Text = "M";
            // 
            // lbl_Phase
            // 
            this.lbl_Phase.AutoSize = true;
            this.lbl_Phase.Location = new System.Drawing.Point(819, 68);
            this.lbl_Phase.Name = "lbl_Phase";
            this.lbl_Phase.Size = new System.Drawing.Size(37, 13);
            this.lbl_Phase.TabIndex = 4;
            this.lbl_Phase.Text = "Phase";
            // 
            // btn_Calculate
            // 
            this.btn_Calculate.Location = new System.Drawing.Point(822, 114);
            this.btn_Calculate.Name = "btn_Calculate";
            this.btn_Calculate.Size = new System.Drawing.Size(161, 23);
            this.btn_Calculate.TabIndex = 5;
            this.btn_Calculate.Text = "Calculate";
            this.btn_Calculate.UseVisualStyleBackColor = true;
            this.btn_Calculate.Click += new System.EventHandler(this.btn_Calculate_Click);
            // 
            // txt_M
            // 
            this.txt_M.Location = new System.Drawing.Point(862, 18);
            this.txt_M.Name = "txt_M";
            this.txt_M.Size = new System.Drawing.Size(100, 20);
            this.txt_M.TabIndex = 6;
            // 
            // txt_Phase
            // 
            this.txt_Phase.Location = new System.Drawing.Point(862, 61);
            this.txt_Phase.Name = "txt_Phase";
            this.txt_Phase.Size = new System.Drawing.Size(100, 20);
            this.txt_Phase.TabIndex = 7;
            this.txt_Phase.Text = "v";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 450);
            this.Controls.Add(this.txt_Phase);
            this.Controls.Add(this.txt_M);
            this.Controls.Add(this.btn_Calculate);
            this.Controls.Add(this.lbl_Phase);
            this.Controls.Add(this.lbl_M);
            this.Controls.Add(this.ch_Graph);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.ch_Graph)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart ch_Graph;
        private System.Windows.Forms.Label lbl_M;
        private System.Windows.Forms.Label lbl_Phase;
        private System.Windows.Forms.Button btn_Calculate;
        private System.Windows.Forms.TextBox txt_M;
        private System.Windows.Forms.TextBox txt_Phase;
    }
}

