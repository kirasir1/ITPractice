using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITApp5
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }
    // Индивидуальное задание 3
    private void button1_Click(object sender, EventArgs e)
    {
      double x = Convert.ToInt32(textBox1.Text);
      if (radioButton1.Checked == true)
      {
        if (x < 0)
        {
          richTextBox1.Text += "Ответ: -1\n";
        }
        else if (x>=0 && x < 5)
        {
          richTextBox1.Text += "Ответ: " + Convert.ToString(2*Math.Sinh(x))+ "\n";
        }
        else if (x >= 5)
        {
          richTextBox1.Text += "Ответ: " + Convert.ToString(Math.Sinh(x)) + "\n";
        }
      }
      if (radioButton2.Checked == true)
      {
        if (x < 0)
        {
          richTextBox1.Text += "Ответ: -1\n";
        }
        else if (x >= 0 && x < 5)
        {
          richTextBox1.Text += "Ответ: " + Convert.ToString(2 * Math.Cosh(x)) + "\n";
        }
        else if (x >= 5)
        {
          richTextBox1.Text += "Ответ: " + Convert.ToString(Math.Cosh(x)) + "\n";
        }
      }
      if (radioButton3.Checked == true)
      {
        if (x < 0)
        {
          richTextBox1.Text += "Ответ: -1\n";
        }
        else if (x >= 0 && x < 5)
        {
          richTextBox1.Text += "Ответ: " + Convert.ToString(2 * Math.Exp(x)) + "\n";
        }
        else if (x >= 5)
        {
          richTextBox1.Text += "Ответ: " + Convert.ToString(Math.Exp(x)) + "\n";
        }
      }
    }
  }
}
