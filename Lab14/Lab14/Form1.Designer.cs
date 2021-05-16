namespace Lab14
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nudVariance = new System.Windows.Forms.Label();
            this.nudMean = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.nudNumber = new System.Windows.Forms.NumericUpDown();
            this.btSumming = new System.Windows.Forms.Button();
            this.btEnchanced = new System.Windows.Forms.Button();
            this.btBoxMuller = new System.Windows.Forms.Button();
            this.average = new System.Windows.Forms.Label();
            this.variance = new System.Windows.Forms.Label();
            this.chi = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.nudMean)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(77, 205);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number of experiments";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(70, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mean";
            // 
            // nudVariance
            // 
            this.nudVariance.AutoSize = true;
            this.nudVariance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nudVariance.Location = new System.Drawing.Point(70, 79);
            this.nudVariance.Name = "nudVariance";
            this.nudVariance.Size = new System.Drawing.Size(70, 16);
            this.nudVariance.TabIndex = 2;
            this.nudVariance.Text = "Variance";
            // 
            // nudMean
            // 
            this.nudMean.DecimalPlaces = 2;
            this.nudMean.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nudMean.Location = new System.Drawing.Point(146, 44);
            this.nudMean.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nudMean.Name = "nudMean";
            this.nudMean.Size = new System.Drawing.Size(74, 20);
            this.nudMean.TabIndex = 3;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.DecimalPlaces = 2;
            this.numericUpDown2.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDown2.Location = new System.Drawing.Point(146, 79);
            this.numericUpDown2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(74, 20);
            this.numericUpDown2.TabIndex = 4;
            this.numericUpDown2.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            // 
            // chart
            // 
            chartArea1.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea1);
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            this.chart.Legends.Add(legend1);
            this.chart.Location = new System.Drawing.Point(325, 12);
            this.chart.Name = "chart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "freq.";
            series2.BorderWidth = 3;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Color = System.Drawing.Color.Green;
            series2.Legend = "Legend1";
            series2.Name = "distr.";
            this.chart.Series.Add(series1);
            this.chart.Series.Add(series2);
            this.chart.Size = new System.Drawing.Size(463, 350);
            this.chart.TabIndex = 5;
            this.chart.Text = "freq.";
            // 
            // nudNumber
            // 
            this.nudNumber.Location = new System.Drawing.Point(80, 224);
            this.nudNumber.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudNumber.Name = "nudNumber";
            this.nudNumber.Size = new System.Drawing.Size(164, 20);
            this.nudNumber.TabIndex = 6;
            this.nudNumber.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // btSumming
            // 
            this.btSumming.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btSumming.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btSumming.Location = new System.Drawing.Point(12, 330);
            this.btSumming.Name = "btSumming";
            this.btSumming.Size = new System.Drawing.Size(304, 32);
            this.btSumming.TabIndex = 7;
            this.btSumming.Text = "Summing";
            this.btSumming.UseVisualStyleBackColor = false;
            this.btSumming.Click += new System.EventHandler(this.btSumming_Click);
            // 
            // btEnchanced
            // 
            this.btEnchanced.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btEnchanced.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btEnchanced.Location = new System.Drawing.Point(12, 368);
            this.btEnchanced.Name = "btEnchanced";
            this.btEnchanced.Size = new System.Drawing.Size(304, 32);
            this.btEnchanced.TabIndex = 8;
            this.btEnchanced.Text = "Enhanced";
            this.btEnchanced.UseVisualStyleBackColor = false;
            this.btEnchanced.Click += new System.EventHandler(this.btEnchanced_Click);
            // 
            // btBoxMuller
            // 
            this.btBoxMuller.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btBoxMuller.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btBoxMuller.Location = new System.Drawing.Point(12, 406);
            this.btBoxMuller.Name = "btBoxMuller";
            this.btBoxMuller.Size = new System.Drawing.Size(304, 32);
            this.btBoxMuller.TabIndex = 9;
            this.btBoxMuller.Text = "Box Muller";
            this.btBoxMuller.UseVisualStyleBackColor = false;
            this.btBoxMuller.Click += new System.EventHandler(this.btBoxMuller_Click);
            // 
            // average
            // 
            this.average.AutoSize = true;
            this.average.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.average.Location = new System.Drawing.Point(341, 384);
            this.average.Name = "average";
            this.average.Size = new System.Drawing.Size(0, 13);
            this.average.TabIndex = 10;
            // 
            // variance
            // 
            this.variance.AutoSize = true;
            this.variance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.variance.Location = new System.Drawing.Point(341, 416);
            this.variance.Name = "variance";
            this.variance.Size = new System.Drawing.Size(0, 13);
            this.variance.TabIndex = 11;
            // 
            // chi
            // 
            this.chi.AutoSize = true;
            this.chi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chi.Location = new System.Drawing.Point(550, 400);
            this.chi.Name = "chi";
            this.chi.Size = new System.Drawing.Size(0, 13);
            this.chi.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chi);
            this.Controls.Add(this.variance);
            this.Controls.Add(this.average);
            this.Controls.Add(this.btBoxMuller);
            this.Controls.Add(this.btEnchanced);
            this.Controls.Add(this.btSumming);
            this.Controls.Add(this.nudNumber);
            this.Controls.Add(this.chart);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.nudMean);
            this.Controls.Add(this.nudVariance);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "lab14";
            ((System.ComponentModel.ISupportInitialize)(this.nudMean)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label nudVariance;
        private System.Windows.Forms.NumericUpDown nudMean;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.NumericUpDown nudNumber;
        private System.Windows.Forms.Button btSumming;
        private System.Windows.Forms.Button btEnchanced;
        private System.Windows.Forms.Button btBoxMuller;
        private System.Windows.Forms.Label average;
        private System.Windows.Forms.Label variance;
        private System.Windows.Forms.Label chi;
        private System.Windows.Forms.Timer timer1;
    }
}

