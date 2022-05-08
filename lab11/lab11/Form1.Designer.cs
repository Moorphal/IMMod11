
namespace lab11
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
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.meanBox = new System.Windows.Forms.NumericUpDown();
            this.varBox = new System.Windows.Forms.NumericUpDown();
            this.NBox = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.eMBox = new System.Windows.Forms.TextBox();
            this.eVarBox = new System.Windows.Forms.TextBox();
            this.chiBox = new System.Windows.Forms.TextBox();
            this.mark = new System.Windows.Forms.Label();
            this.tableChiBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.eMErr = new System.Windows.Forms.TextBox();
            this.eVarErr = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tPBox = new System.Windows.Forms.Label();
            this.rPBox = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.meanBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.varBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NBox)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.Black;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(-1, 162);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series1.BackSecondaryColor = System.Drawing.Color.White;
            series1.BorderColor = System.Drawing.Color.Black;
            series1.ChartArea = "ChartArea1";
            series1.Color = System.Drawing.Color.Magenta;
            series1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            series1.IsValueShownAsLabel = true;
            series1.LabelFormat = "0.000";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            series1.YValuesPerPoint = 6;
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series2.BorderWidth = 3;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Color = System.Drawing.Color.Blue;
            series2.Legend = "Legend1";
            series2.Name = "Series2";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(1093, 601);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mean:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(12, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Var:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(12, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "N:";
            // 
            // meanBox
            // 
            this.meanBox.DecimalPlaces = 2;
            this.meanBox.Location = new System.Drawing.Point(73, 33);
            this.meanBox.Name = "meanBox";
            this.meanBox.Size = new System.Drawing.Size(80, 22);
            this.meanBox.TabIndex = 4;
            // 
            // varBox
            // 
            this.varBox.DecimalPlaces = 2;
            this.varBox.Location = new System.Drawing.Point(73, 71);
            this.varBox.Name = "varBox";
            this.varBox.Size = new System.Drawing.Size(80, 22);
            this.varBox.TabIndex = 5;
            this.varBox.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            // 
            // NBox
            // 
            this.NBox.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.NBox.Location = new System.Drawing.Point(73, 108);
            this.NBox.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.NBox.Name = "NBox";
            this.NBox.Size = new System.Drawing.Size(80, 22);
            this.NBox.TabIndex = 6;
            this.NBox.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(769, 38);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(305, 97);
            this.button1.TabIndex = 7;
            this.button1.Text = "START";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(183, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Average:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(183, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Variance:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(183, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Chi-Squared:";
            // 
            // eMBox
            // 
            this.eMBox.Location = new System.Drawing.Point(264, 35);
            this.eMBox.Name = "eMBox";
            this.eMBox.ReadOnly = true;
            this.eMBox.Size = new System.Drawing.Size(105, 22);
            this.eMBox.TabIndex = 11;
            // 
            // eVarBox
            // 
            this.eVarBox.Location = new System.Drawing.Point(269, 70);
            this.eVarBox.Name = "eVarBox";
            this.eVarBox.ReadOnly = true;
            this.eVarBox.Size = new System.Drawing.Size(105, 22);
            this.eVarBox.TabIndex = 12;
            // 
            // chiBox
            // 
            this.chiBox.Location = new System.Drawing.Point(296, 107);
            this.chiBox.Name = "chiBox";
            this.chiBox.ReadOnly = true;
            this.chiBox.Size = new System.Drawing.Size(84, 22);
            this.chiBox.TabIndex = 13;
            // 
            // mark
            // 
            this.mark.AutoSize = true;
            this.mark.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mark.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.mark.Location = new System.Drawing.Point(407, 107);
            this.mark.Name = "mark";
            this.mark.Size = new System.Drawing.Size(18, 20);
            this.mark.TabIndex = 14;
            this.mark.Text = "?";
            // 
            // tableChiBox
            // 
            this.tableChiBox.Location = new System.Drawing.Point(431, 108);
            this.tableChiBox.Name = "tableChiBox";
            this.tableChiBox.ReadOnly = true;
            this.tableChiBox.Size = new System.Drawing.Size(88, 22);
            this.tableChiBox.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(393, 37);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 20);
            this.label8.TabIndex = 16;
            this.label8.Text = "Error:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(393, 73);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 20);
            this.label9.TabIndex = 17;
            this.label9.Text = "Error:";
            // 
            // eMErr
            // 
            this.eMErr.Location = new System.Drawing.Point(451, 38);
            this.eMErr.Name = "eMErr";
            this.eMErr.ReadOnly = true;
            this.eMErr.Size = new System.Drawing.Size(70, 22);
            this.eMErr.TabIndex = 18;
            // 
            // eVarErr
            // 
            this.eVarErr.Location = new System.Drawing.Point(449, 71);
            this.eVarErr.Name = "eVarErr";
            this.eVarErr.ReadOnly = true;
            this.eVarErr.Size = new System.Drawing.Size(70, 22);
            this.eVarErr.TabIndex = 19;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.Location = new System.Drawing.Point(665, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(90, 18);
            this.label11.TabIndex = 22;
            this.label11.Text = "Theory Ps:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label12.Location = new System.Drawing.Point(564, 9);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(95, 18);
            this.label12.TabIndex = 23;
            this.label12.Text = "Empiric Ps:";
            // 
            // tPBox
            // 
            this.tPBox.AutoSize = true;
            this.tPBox.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tPBox.Location = new System.Drawing.Point(684, 36);
            this.tPBox.Name = "tPBox";
            this.tPBox.Size = new System.Drawing.Size(54, 17);
            this.tPBox.TabIndex = 25;
            this.tPBox.Text = "label14";
            // 
            // rPBox
            // 
            this.rPBox.AutoSize = true;
            this.rPBox.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rPBox.Location = new System.Drawing.Point(588, 35);
            this.rPBox.Name = "rPBox";
            this.rPBox.Size = new System.Drawing.Size(54, 17);
            this.rPBox.TabIndex = 26;
            this.rPBox.Text = "label15";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1102, 775);
            this.Controls.Add(this.rPBox);
            this.Controls.Add(this.tPBox);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.eVarErr);
            this.Controls.Add(this.eMErr);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tableChiBox);
            this.Controls.Add(this.mark);
            this.Controls.Add(this.chiBox);
            this.Controls.Add(this.eVarBox);
            this.Controls.Add(this.eMBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.NBox);
            this.Controls.Add(this.varBox);
            this.Controls.Add(this.meanBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chart1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.meanBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.varBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown meanBox;
        private System.Windows.Forms.NumericUpDown varBox;
        private System.Windows.Forms.NumericUpDown NBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox eMBox;
        private System.Windows.Forms.TextBox eVarBox;
        private System.Windows.Forms.TextBox chiBox;
        private System.Windows.Forms.Label mark;
        private System.Windows.Forms.TextBox tableChiBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox eMErr;
        private System.Windows.Forms.TextBox eVarErr;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label tPBox;
        private System.Windows.Forms.Label rPBox;
    }
}

