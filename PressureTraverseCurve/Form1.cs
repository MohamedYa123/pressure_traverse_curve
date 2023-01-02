
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.IO;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Threading;

namespace PressureTraverseCurve
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            variablvalues = new Dictionary<string, decimal>();
            variablvalues.Add("π", Convert.ToDecimal(3.14159265358979323846));
            variablvalues.Add("e", Convert.ToDecimal(2.71828182846));
            variablvalues.Add("ans", Convert.ToDecimal(0));
            variablvalues.Add("X", Convert.ToDecimal(0));
            variablvalues.Add("Y", Convert.ToDecimal(0));
            variablvalues.Add("Z", Convert.ToDecimal(0));
            sm = new Calculator.smartmodifier(this);
        }
        Dictionary<string, decimal> variablvalues;
        Calculator.smartmodifier sm;
        bool done = false;
        void calc(traversecurvecalculator pv)
        {
            pv.calc(29);
            done = true;
        }
        private  void button1_Click(object sender, EventArgs e)
        {
           // await Task.Run(() => dodrawAsync());
            
            dodrawAsync();
        }
        void dodrawAsync()
        {
            label1.Text = "11";
            progressBar1.Show();
            chart1.Series.Clear();
            var cons = File.ReadAllLines("const.txt");
            var eqs = File.ReadAllLines("equations.txt");
            Stopwatch sp = new Stopwatch();
            sp.Start();
            int y = 0;
            bool first = true;
            double oldglr = 0;
            int totalcounts = 0;
            int plus = 1;
            for (double glr = Convert.ToDouble(from.Text); glr < Convert.ToDouble(to1.Text) + 1; glr += Convert.ToDouble(step1.Text))
            {
                if (glr == Convert.ToDouble(GLR.Text))
                {
                    plus = 0;
                }
                totalcounts++;
            }
            totalcounts += plus;
            y = 0;
            for (double glr = Convert.ToDouble(from.Text); glr < Convert.ToDouble(to1.Text) + 1; glr += Convert.ToDouble(step1.Text))
            {

                traversecurvecalculator pv = new traversecurvecalculator();
                pv.loadparameters();
                pv.load_fromText(cons, eqs);
                pv.paramters2["GLR"].set(glr);
                oldglr = glr;
                foreach (var c in panel1.Controls)
                {
                    try
                    {
                        TextBox t = (TextBox)c;
                        if (t.Name != "GLR" || first)
                        {
                            pv.paramters2[t.Name].set(Convert.ToDouble(t.Text));
                        }
                    }
                    catch
                    {

                    }
                }
                if (first)
                {
                    if (glr != Convert.ToDouble(GLR.Text))
                    {
                        glr = Convert.ToDouble(GLR.Text);
                    }
                    else
                    {
                        first = false;
                    }
                }

                pv.rm = sm;
                pv.variables = variablvalues;
                done = false;
                Task ts = new Task(() => calc(pv));
                ts.Start();
                while (!done)
                {
                    progressBar1.Value = y * 100 / totalcounts + (pv.stepsreached * 100 / totalcounts) / 29;
                    Thread.Sleep(1);
                }
                var pressures = pv.paramters2["P"].values;
                var depths = pv.paramters2["DEPTH"].values;
                chart1.Series.Add($"GLR {glr}");
                chart1.Series[$"GLR {glr}"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
                chart1.ChartAreas[0].AxisY.IsReversed = true;
                chart1.ChartAreas[0].AxisX.Interval = 500;
                chart1.ChartAreas[0].AxisX.Minimum = 0;
                for (int i = 0; i < pressures.Count; i++)
                {
                    chart1.Series[$"GLR {glr}"].Points.AddXY(pressures[i], depths[i]);
                }
                y++;
                if (first)
                {
                    glr = oldglr - Convert.ToDouble(step1.Text);
                }
                first = false;
                progressBar1.Value = y * 100 / totalcounts;
            }
            sp.Stop();
            label1.Text = "Done";
        }
    }
}
