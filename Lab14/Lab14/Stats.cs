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
    class Stats
    {
        public Stopwatch stopwatch = new Stopwatch();
        public decimal absAvg, absVar;
        public double error1, error2;
        public int a, b;
        public decimal[] values, probs;
        decimal[] freq = new decimal[5];
        decimal avg, var, Chi;
        int[] stats = new int[5];
        Random rand = new Random();

        public decimal[] GetStats()
        {
            decimal min = values[0], max = values[0];
            int j;

            for (int i = 1; i < values.Length; i++)
            {
                if (values[i] < min)
                {
                    min = values[i];
                }
                if (values[i] > max)
                {
                    max = values[i];
                }
            }

            a = (int)Math.Floor(min); b = (int)Math.Ceiling(max);

            for (int i = 0; i < 5; i++)
            {
                stats[i] = 0;
            }

            for (int i = 0; i < values.Length; i++)
            {
                j = 0;
                while
                    (a + j * ((decimal)(b - a)) / 5 >= values[i]
                    ||
                    a + (j + 1) * ((decimal)(b - a)) / 5 < values[i])
                    j++;
                stats[j]++;
            }
            for (int i = 0; i < 5; i++)
            {
                freq[i] = (decimal)stats[i] / values.Length;
            }
            return freq;
        }
        public void GetMean()
        {
            Chi = absAvg = absVar = 0;
            probs = new decimal[5];

            for (int i = 0; i < 5; i++)
            {
                probs[i] = (decimal)((b - a) * GetProb((2 * a + i * ((double)(b - a)) / 5 + (i + 1) * ((double)(b - a)) / 5) / 2) / 5);

                Chi += stats[i] * stats[i] / (probs[i] * values.Length);
            }

            Chi -= values.Length;

            for (int i = 0; i < values.Length; i++)
            {
                absAvg += values[i];
                absVar += values[i] * values[i];
            }

            absAvg /= values.Length;
            absVar /= values.Length;
            absVar -= absAvg * absAvg;
            absAvg = Math.Round(absAvg, 3);
            absVar = Math.Round(absVar, 3);
            error1 = Math.Round(Math.Abs((double)(absAvg - avg)) * 100 / Math.Abs((double)avg), 3);
            error2 = Math.Round(Math.Abs((double)(absVar - var)) * 100 / Math.Abs((double)var), 3);
        }
        public void GetSum(int n, decimal avg, decimal variance)
        {
            this.avg = avg; var = variance;
            values = new decimal[n];
            stopwatch.Restart();
            double x;

            for (int i = 0; i < n; i++)
            {
                x = 0;

                for (int j = 0; j < 12; j++)
                {
                    x += rand.NextDouble();
                }

                values[i] = (decimal)((x - 6) * Math.Sqrt((double)var)) + this.avg;
            }

            stopwatch.Stop();
        }

        public void GetAbsSum(int n, decimal avg, decimal variance)
        {
            this.avg = avg; variance = variance;
            values = new decimal[n];
            stopwatch.Restart();
            double x;

            for (int i = 0; i < n; i++)
            {
                x = 0;
                for (int j = 0; j < 12; j++)
                {
                    x += rand.NextDouble();
                }
                x -= 6;

                values[i] = (decimal)((x + (x * x * x - 3 * x) / 240) * Math.Sqrt((double)variance)) + this.avg;
            }

            stopwatch.Stop();
        }
        public void GetBox(int n, decimal avg, decimal variance)
        {
            this.avg = avg; var = variance;
            values = new decimal[n];
            stopwatch.Restart();
            double a1, a2;

            for (int i = 0; i < n; i += 2)
            {
                do
                {
                    a1 = rand.NextDouble();
                } while (a1 == 0);

                do
                {
                    a2 = rand.NextDouble();
                } while (a2 == 0);

                values[i] = (decimal)(Math.Sqrt(-2 * Math.Log(a1)) * Math.Cos(2 * Math.PI * a2) * Math.Sqrt((double)var)) + this.avg;
                values[i + 1] = (decimal)(Math.Sqrt(-2 * Math.Log(a1)) * Math.Sin(2 * Math.PI * a2) * Math.Sqrt((double)var)) + this.avg;
            }
            stopwatch.Stop();
        }
        public string GetChi()
        {
            if ((double)Chi < 11.07)
                return "Chi-squared: " + Math.Round((double)Chi, 3) + " < 11.07 is true";
            return "Chi-squared: " + Math.Round((double)Chi, 3) + " > 11.07 is false";
        }

        public double GetProb(double x)
        {
            return Math.Exp(-(x - (double)avg) * (x - (double)avg) / (2 * (double)var)) / Math.Sqrt(2 * Math.PI * (double)var);
        }
    }
}
