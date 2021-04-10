using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Работа 10, Задание 2
namespace ITApp12
{
  public partial class Form1 : Form
  {
    private int[] x1 = new int[3];
    private int[] y1 = new int[3];
    private int[] x2 = new int[3];
    private int[] y2 = new int[3];
    private int r;
    private double[] a = new double[3];
    public Form1()
    {
      InitializeComponent();
    }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
      Graphics g = e.Graphics;
      Pen forLine = new Pen(Color.Black, 10);
      g.DrawLine(forLine, x1[0], y1[0], x2[0], y2[0]);
      g.DrawLine(forLine, x1[1], y1[1], x2[1], y2[1]);
      g.DrawLine(forLine, x1[2], y1[2], x2[2], y2[2]);
      SolidBrush recBrush = new SolidBrush(Color.Black);
      Rectangle r = new Rectangle(350, 178, 100, 100);
      g.FillEllipse(recBrush, r);
      //g.DrawLine(forLine, x1, y1, x2, y2);
      //g.DrawLine(forLine, x1, y1, x2, y2);
      /*SolidBrush newBrush = new SolidBrush(Color.Black);
      Rectangle myachique = new Rectangle(40, 40, 75, 75);
      g.FillEllipse(newBrush, myachique);*/
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      for (int i = 0; i<3; i++)
      {
        x1[i] = ClientSize.Width / 2;
        y1[i] = ClientSize.Height / 2;
      }
      r = 150;
      a[0] = 1.5708;
      a[1] = 5.49779;
      a[2] = 3.92699;
      for (int i = 0; i < 3; i++)
      {
        x2[i] = x1[i] + (int)(r * Math.Cos(a[i]));
        y2[i] = y1[i] - (int)(r * Math.Sin(a[i]));
      }
    }

    private void timer1_Tick(object sender, EventArgs e)
    {
      a[0] -= 0.1;
      a[1] -= 0.1;
      a[2] -= 0.1;
      for (int i = 0; i < 3; i++)
      {
        x2[i] = x1[i] + (int)(r * Math.Cos(a[i]));
        y2[i] = y1[i] - (int)(r * Math.Sin(a[i]));
      }
      Invalidate();

    }
  }
}
