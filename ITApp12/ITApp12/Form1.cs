using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Работа 10, Задание 7
namespace ITApp12
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
      Graphics g = e.Graphics;
      Pen forLine = new Pen(Color.Black, 2);
      g.DrawLine(forLine, 200, 400, 500, 400);
      Rectangle myachique = new Rectangle();
    }
    }
}
