using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITApp2
{
  public partial class Form1 : Form
  {
    Random randevent = new Random();
    int event1, event2, event3, event4 = 0;

    private void button1_Click(object sender, EventArgs e)
    {
      event1 = randevent.Next(0, 4);
      if (event1 == 3)
      {
        label1.Text = " ";
      }
      if (label1.Text == " " && label2.Text == " " && label1.Text == " " && label1.Text == " ")
      {
        label5.Text = "Ты выиграл!";

      }
    }
    private void button2_Click(object sender, EventArgs e)
    {
      event2 = randevent.Next(0, 4);
      if (event2 == 3)
      {
        label2.Text = " ";
      }
      if (label1.Text == " " && label2.Text == " " && label3.Text == " " && label4.Text == " ")
      {
        label5.Text = "Ты выиграл!";
      }
  }
    private void button3_Click(object sender, EventArgs e)
    {
      event3 = randevent.Next(0, 4);
      if (event3 == 3)
      {
        label3.Text = " ";
      }
      if (label1.Text == " " && label2.Text == " " && label3.Text == " " && label4.Text == " ")
      {
        label5.Text = "Ты выиграл!";
      }
    }
    private void button4_Click(object sender, EventArgs e)
    {
      event4 = randevent.Next(0, 4);
      if (event4 == 3)
      {
        label4.Text = " ";
      }
      if (label1.Text == " " && label2.Text == " " && label3.Text == " " && label4.Text == " ")
      {
        label5.Text = "Ты выиграл!";
      }
    }

    public Form1()
    {
      InitializeComponent();
    }
  }
}
