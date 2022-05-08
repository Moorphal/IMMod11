using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace lab11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int N;
        double[] chiTable = { 3.881, 5.991, 7.815, 9.488, 11.070, 12.592, 14.067,
                              15.507, 16.919, 18.307, 19.675, 21.026, 22.362,
                              23.685, 24.996, 26.296, 27.587, 28.869, 30.144, 31.410 };

        private void button1_Click(object sender, EventArgs e)
        {
            func f = new func();
            N = getN();

            double a = (double)meanBox.Value;
            double sigma = (double)varBox.Value;
            double[] Ps = f.gaussianDist(a, sigma, N);
            double[,] intervals = f.getIntervals(Ps, N);
            double[] stats = f.getStat(Ps, intervals);
            double[] rP = f.getRelFreq(stats, N);
            double[] tP = f.getTheoryPs(intervals);
            double EAverage = f.getEAverage(Ps, N);
            double EVar = f.getEVar(Ps, N, EAverage);


            ChiFromFreqs(rP, tP);


            getErrors(EAverage, EVar, a, sigma);
            getChart(intervals, rP);
            getText(rP, tP, EAverage, EVar);
        }

        public void getChart(double[,] intervals, double[] PsOut)
        {
            chart1.Series[0].Points.Clear();
            chart1.Series[1].Points.Clear();
            chart1.ChartAreas[0].AxisX.CustomLabels.Clear();
            chart1.Series[0]["PointWidth"] = "1";
            double length = intervals[0, 0] - intervals[0, 1];

            for (int i = 0; i < intervals.GetLength(0); i++)
            {
                CustomLabel label = new CustomLabel();
                label.Text = "(" + String.Format("{0:n1}", intervals[i, 0]) + ";"
                    + String.Format("{0:n1}", intervals[i, 1]) + "]";

                label.FromPosition = i - length;
                label.ToPosition = i + length;

                chart1.ChartAreas[0].AxisX.CustomLabels.Add(label);
            }

            for (int i = 0; i < PsOut.Length; i++) chart1.Series[1].Points.AddXY(i, PsOut[i]);
            for (int i = 0; i < PsOut.Length; i++) chart1.Series[0].Points.AddXY(i, PsOut[i]);
        }
        public int getN()
        {
            if (((int)NBox.Value % 2) == 0) { return (int)NBox.Value; }
            else
            {
                NBox.Value++;
                return (int)NBox.Value;
            }

        }
        public void getText(double[] rP, double[] tP, double E, double V)
        {
            tPBox.Text = "";
            rPBox.Text = "";
            double sumtP = 0, sumrP = 0;
            for (int i = 0; i < rP.Length; i++)
            {
                tPBox.Text += String.Format("{0:n3}", tP[i]) + "\n";
                sumtP += tP[i];
                rPBox.Text += String.Format("{0:n3}", rP[i]) + "\n";
                sumrP += rP[i];
            }
            tPBox.Text += "total: " + String.Format("{0:n3}", sumtP);
            rPBox.Text += "total: " + String.Format("{0}", sumrP);

            eMBox.Text = String.Format("{0:n6}", E);
            eVarBox.Text = String.Format("{0:n6}", V);
        }
        public void getErrors(double E, double V, double a, double sigma)
        {
            double absErrE, absErrD, relErrE, relErrD;

            if (a == 0) a += 0.0000001; 
            absErrE = Math.Abs(E - a);

            absErrD = Math.Abs(V - Math.Abs(Math.Sqrt(sigma)));
            relErrE = absErrE / Math.Abs(a);
            relErrD = absErrD / Math.Abs(Math.Sqrt(sigma));


            eMErr.Text = String.Format("{0:n2}", relErrE)+"%";
            eVarErr.Text = String.Format("{0:n2}", relErrD) + "%";
        }

        public void ChiFromFreqs(double[] observed, double[] expected)
        {
            double chi = 0.0;
            for (int i = 0; i < observed.Length; ++i)
            {
                chi += ((observed[i] - expected[i]) * (observed[i] - expected[i])) / expected[i];
            }

            // Вывод
            chiBox.Text = String.Format("{0:n6}", chi);
            double chiVal = 0;
            if (observed.Length <= chiTable.Length)
            {
                chiVal = chiTable[observed.Length - 2];
                tableChiBox.Text = chiVal + "";
            }
            else { tableChiBox.Text = "unknown"; }

            if (tableChiBox.Text == "unknown") mark.Text = "?";
            else if (chi > chiVal) mark.Text = ">";
            else mark.Text = "<";
        }
    }

    class func
    {
        public double[] gaussianDist(double E, double V, int N)
        {
            Random random = new Random();
            List<double> P = new List<double>();

            for (int i = 0; i < N/2; i++)
            {
                double[] a = boxMuller(random);
                for (int j = 0; j < 2; j++)
                { 
                    a[j] = Math.Sqrt(V) * a[j] + E;
                    P.Add(a[j]);
                }     
            }
            return P.ToArray();
        }

        public double[] boxMuller(Random random)
        {
            double[] z = new double[2];
            double alfa1 = random.NextDouble(), alfa2 = random.NextDouble();

            z[0] = Math.Sqrt(-2 * Math.Log(alfa1)) * Math.Cos(2 * Math.PI * alfa2);
            z[1] = Math.Sqrt(-2 * Math.Log(alfa1)) * Math.Sin(2 * Math.PI * alfa2);

            return z;
        }

        public double[,] getIntervals(double[] Ps, int N)
        {
            double k = Math.Log(N,2)+1;
            double max = Ps.Max() + 0.05;
            double min = Ps.Min() - 0.05;
            
            double length = (max - min) / k;
            k = Math.Ceiling(k);
            double[,] intervals = new double[(int)k, 2];
            int i = 0;
            while (i<k)
            {
                intervals[i, 0] = min;
                min += length;
                intervals[i, 1] = min;
                i++;
            }

            return intervals;
        }

        public double[] getStat(double[] Ps, double[,] intervals)
        {
            double[] stat = new double[intervals.GetLength(0)];
            
            for(int i = 0; i < Ps.Length; i++)
            {
                for (int j = 0; j < intervals.GetLength(0); j++)
                {
                    if(Ps[i] > intervals[j,0] && Ps[i] <= intervals[j, 1])
                    { stat[j]++; break; }
                }
            }
            return stat;
        }

        public double[] getRelFreq(double[] stat, int N)
        {
            double[] PsOut = new double[stat.Length];
            

            for(int i =0; i < stat.Length; i++)
            {
                PsOut[i] = stat[i] / (double)N;
            }

            return PsOut;
        }

        public double[] getDensity(double[] PsOut, double[,] intervals, double sigma, double a)
        {
            double length = intervals[0, 1] - intervals[0, 0];
            double[] density = new double[PsOut.Length];

            for (int i = 0; i < PsOut.Length; i++)
            {
                
                density[i] = (1 / Math.Sqrt(2 * Math.PI)) * Math.Exp(-(Math.Pow(PsOut[i], 2) / 2));
            }

            return density;
        }

        public double[] getTheoryPs(double[,] intervals)
        {
            double a, b;
            double[] tP = new double[intervals.GetLength(0)];

            for(int i = 0; i < intervals.GetLength(0); i++)
            {
                a = intervals[i, 0];
                b = intervals[i, 1];
                tP[i] = Math.Abs((b - a) * gaussLight((b+a)/2));
            }

            return tP;
        }
        public double gaussLight(double x)
        {
            return (1 / Math.Sqrt(2 * Math.PI)) * Math.Exp(-(Math.Pow(x, 2) / 2));
        }

        public double getEAverage(double[] Ps, int N)
        {
            double sum = 0;
            for (int i = 0; i < Ps.Length; i++)
            {
                sum += Ps[i];
            }
            return sum / N;
        }

        public double getEVar(double[] Ps, int N, double E)
        {
            double sum = 0;
            for (int i = 0; i < Ps.Length; i++)
            {
                sum += Math.Pow(Ps[i],2);
            }
            return (sum / N) - Math.Pow(E,2);
        }

        public void getChiTest(double[] stat, double[] P, int N, double[] chiTable, TextBox chiBox, TextBox tableChiValBox, Label mark)
        {
            double chi = 0;

            for (int i = 0; i < stat.Length; i++)
            {
                chi += Math.Pow(stat[i], 2) / (N * P[i]);
            }
            chi -= N;


            // Вывод
            chiBox.Text = String.Format("{0:n6}", chi);
            double chiVal = 0;
            if (stat.Length <= chiTable.Length)
            {
                chiVal = chiTable[stat.Length - 2];
                tableChiValBox.Text = chiVal + "";
            }
            else { tableChiValBox.Text = "unknown"; }

            if (tableChiValBox.Text == "unknown") mark.Text = "?";
            else if (chi > chiVal) mark.Text = ">";
            else mark.Text = "<";
        }

    }
}
