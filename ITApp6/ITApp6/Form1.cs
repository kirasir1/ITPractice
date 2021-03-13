using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITApp6
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }
    //Индивидуальное задание 2
        private void button1_Click(object sender, EventArgs e)
        {
      double n = Convert.ToDouble(textBox1.Text);
      if (radioButton1.Checked)
      {
        double res = Summing(n);
        richTextBox1.Text += "Сумма ряда равна " + res.ToString() + "\n";
      }
      else if (radioButton2.Checked)
      {
        double res = Summing2(n);
        richTextBox1.Text += "Произведение ряда равно " + res.ToString() + "\n";
      }
        }
    static int Fact(int x)
    {
      if (x == 0)
      {
        return 1;
      }
      else
      {
        return x * Fact(x - 1);
      }
    }
    public double Summing(double x)
    {
      double sum = 0;
      double sum1 = 0;
      if (x < 1)
      {
        for (int i = 1; (1 / (2 * i + Fact(i))) <= x; i++)
        {
          sum1 = (2 * i) + Fact(i);
          sum = sum + (1 / sum1);
        }
      }
      if (x >= 1)
      {
        for (int i = 1; i <= x; i++)
        {
          sum1 = (2 * i) + Fact(i);
          sum = sum + (1 / sum1);
        }
      }
      return sum;
    }
    public double Summing2(double x)
    {
      double sum = 1;
      double sum1 = 0;
      if (x < 1)
      {
        for (int i = 1; (1 / (2 * i + Fact(i))) <= x; i++)
        {
          sum1 = (2 * i) + Fact(i);
          sum *= (1 / sum1);
        }
      }
      if (x >= 1)
      {
        for (int i = 1; i <= x; i++)
        {
          sum1 = (2 * i) + Fact(i);
          sum = sum * (1 / sum1);
        }
      }
      return sum;
    }
  }
}
