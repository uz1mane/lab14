using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Lab14
{
    public partial class Form1 : Form
    {
        Stats statistic = new Stats();
        int time;
        enum button
        {
            Sum,
            Enh,
            BoxMuller
        }
        public Form1()
        {
            InitializeComponent();
            chart.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            chart.Series[0].IsValueShownAsLabel = true;
            chart.ChartAreas[0].Axes[1].Maximum = 1.1;
        }

        private void btSumming_Click(object sender, EventArgs e)
        {
            freq(button.Sum);            
            time = 0;
        }

        private void btEnchanced_Click(object sender, EventArgs e)
        {
            freq(button.Enh);            
            time = 0;
        }

        private void btBoxMuller_Click(object sender, EventArgs e)
        {
            freq(button.BoxMuller);            
            time = 0;
        }

        private void freq(button Alhoritm)
        {
            switch (Alhoritm)
            {
                case button.Sum:
                    statistic.GetSum((int)nudNumber.Value, nudMean.Value, numericUpDown2.Value);
                    break;

                case button.Enh:
                    statistic.GetAbsSum((int)nudNumber.Value, nudMean.Value, numericUpDown2.Value);
                    break;

                case button.BoxMuller:
                    statistic.GetBox((int)nudNumber.Value, nudMean.Value, numericUpDown2.Value);
                    break;
            }

            decimal[] Freq = statistic.GetStats();
            chart.Series[0].Points.Clear();
            double ai = statistic.a;
            chart.ChartAreas[0].Axes[0].Interval = ((double)(statistic.b - statistic.a)) / 5;

            for (int i = 0; i < Freq.Length; i++)
            {
                chart.Series[0].Points.AddXY(ai + ((double)(statistic.b - statistic.a)) / 10, Math.Round((double)Freq[i], 3));
                ai += ((double)(statistic.b - statistic.a)) / 5;
            }

            chart.ChartAreas[0].Axes[0].Maximum = statistic.b;            

            statistic.GetMean();

            average.Text = "Average: " + statistic.absAvg + "(" + statistic.error1 + "% error)";
            variance.Text = "Variance: " + statistic.absVar + "(" + statistic.error2 + "% error)";

            chi.Text = statistic.GetChi();
            dist(nudMean.Value, numericUpDown2.Value);
        }

        private void dist(decimal E, decimal D)
        {
            chart.Series[1].Points.Clear();
            double ai = statistic.a;

            for (int i = 0; i < 5; i++)
            {
                chart.Series[1].Points.AddXY(ai + ((double)(statistic.b - statistic.a)) / 10, statistic.GetProb(ai + ((double)(statistic.b - statistic.a)) / 10));
                ai += ((double)(statistic.b - statistic.a)) / 5;
            }
        }        
    }
}