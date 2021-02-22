using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITApp3
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

        private void Form1_Click(object sender, EventArgs e)
        {
      if (button1.Visible == false)
      {
        button1.Visible = true;
      }
      if (button2.Visible == false)
      {
        button2.Visible = true;
      }
      if (button3.Visible == false)
      {
        button3.Visible = true;
      }
      if (button4.Visible == false)
      {
        button4.Visible = true;
      }
    }

    private void button1_Click(object sender, EventArgs e)
    {
      button2.Visible = false;
    }

    private void button2_Click(object sender, EventArgs e)
    {
      button3.Visible = false;
    }

    private void button3_Click(object sender, EventArgs e)
    {
      button4.Visible = false;
    }

    private void button4_Click(object sender, EventArgs e)
    {
      button1.Visible = false;
    }

    private void label1_Click(object sender, EventArgs e)
    {
      if (button1.Visible == false)
      {
        button1.Visible = true;
      }
      if (button2.Visible == false)
      {
        button2.Visible = true;
      }
      if (button3.Visible == false)
      {
        button3.Visible = true;
      }
      if (button4.Visible == false)
      {
        button4.Visible = true;
      }
    }
  }
}
