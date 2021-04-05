using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITApp11
{
  //Здесь будет практика №9
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void Form1_Paint(object sender, PaintEventArgs e)
    {
      Graphics painting = e.Graphics;
      painting.Clear(Color.White);
      Pen blackPen = new Pen(Color.Black, 3);
      Rectangle rect = new Rectangle(0, 0, 200, 100);
      e.Graphics.DrawRectangle(blackPen, 0, 0, 500, 500);
    }
  }
}
