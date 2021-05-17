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
namespace Pakindrom4
{
  public partial class Form1 : Form
  {
    Chart chart;
    private double XMin = 1;
    private double XMax = 300;
    private double Step = (10 * 2) / 10; 
    private double[] x; 
    private double[] y1;
    private void CalcFunction()
    {
      int count = (int)Math.Ceiling((XMax - XMin) / Step) + 1;
      x = new double[count];
      y1 = new double[count];
      for (int i = 0; i < count; i++)
      {
        x[i] = XMin + Step * i;
        y1[i] = Math.Sqrt(1+Math.Exp(Math.Sqrt(x[i]))+Math.Cos(x[i] * x[i])) / Math.Abs(1+Math.Pow(Math.Sin(x[i]),3)) + Math.Log(Math.Abs(2* x[i]));
      }
    }
    private void CreateChart()
    {
      chart = new Chart();
      chart.Parent = this;
      chart.SetBounds(10, 10, ClientSize.Width - 20,
      ClientSize.Height - 20);
      ChartArea area = new ChartArea();
      area.Name = "myGraph";
      area.AxisX.Minimum = XMin;
      area.AxisX.Maximum = XMax;
      area.AxisX.MajorGrid.Interval = Step;
      chart.ChartAreas.Add(area);
      Series series1 = new Series();
      series1.ChartArea = "myGraph";
      series1.ChartType = SeriesChartType.Spline;
      series1.BorderWidth = 3;
      series1.LegendText = "График из практики номер 2";
      chart.Series.Add(series1);
      Legend legend = new Legend();
      chart.Legends.Add(legend);
    }
    public Form1()
    {
      InitializeComponent();
    }
    private void Form1_Load(object sender, EventArgs e)
    {
     CreateChart();
     CalcFunction();
     chart.Series[0].Points.DataBindXY(x, y1);
    }
    private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
    {
      XMax =  XMax * vScrollBar1.Value / 100;
      if (XMax <= 0) XMax = 300;
      ChartArea area = new ChartArea();
      area.Name = "myGraph";
      area.AxisX.Minimum = XMin;
      area.AxisX.Maximum = XMax;
      area.AxisX.MajorGrid.Interval = Step;
      chart.ChartAreas.Clear();
      chart.ChartAreas.Add(area);
      Series series1 = new Series();
      series1.ChartArea = "myGraph";
      series1.ChartType = SeriesChartType.Spline;
      series1.BorderWidth = 3;
      series1.LegendText = "График из практики номер 2";
      chart.Series.Clear();
      chart.Series.Add(series1);
      CalcFunction();
      chart.Series[0].Points.DataBindXY(x, y1);
    }
  }
}

