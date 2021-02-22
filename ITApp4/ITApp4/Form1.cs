using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITApp4
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      string textx = textBox1.Text;
      double x = 0.0;
      try
      {
        x = int.Parse(textx);
      }
      catch (Exception eex)
      {
        richTextBox1.Text = eex.Message;
      }
      double y = Math.Pow((3 + Math.Log(x) + 15 - x), 0.5) / (1 + Math.Sin((2 + Math.Pow(x,2)) / (1 + x)));
      richTextBox1.Text += "Ответ: " + Convert.ToString(y) + "\n";
    }
  }
}
