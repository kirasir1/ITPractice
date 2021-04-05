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
    bool flag = false;
    private void Form1_Paint(object sender, PaintEventArgs e)
    {
      Pen blackPen = new Pen(Color.Black, 3);
      Graphics painting = e.Graphics;
      painting.Clear(Color.White);
      SolidBrush blueBrush = new SolidBrush(Color.LightSkyBlue);
      Rectangle rect = new Rectangle(10, 10, 500, 500);
      e.Graphics.FillRectangle(blueBrush, rect);
      SolidBrush sunBrush = new SolidBrush(Color.Yellow);
      Rectangle r = new Rectangle(40, 40, 75, 75);
      e.Graphics.FillEllipse(sunBrush, r);
      SolidBrush brownBrush = new SolidBrush(Color.SaddleBrown);
      Rectangle houseNew = new Rectangle(150, 310, 200, 200);
      e.Graphics.DrawRectangle(blackPen, 150, 310, 200, 200);
      e.Graphics.FillRectangle(brownBrush, houseNew);
      Point point1 = new Point(250, 180);
      Point point2 = new Point(150, 310);
      Point point3 = new Point(350, 310);
      Point[] curvePoints = {point1, point2, point3};
      e.Graphics.DrawPolygon(blackPen, curvePoints);
      e.Graphics.FillPolygon(brownBrush, curvePoints);  
      SolidBrush windowBrush = new SolidBrush(Color.LightGray);
      Rectangle newWindow = new Rectangle(200, 350, 100, 100);
      e.Graphics.DrawRectangle(blackPen, 200, 350, 100, 100);
      e.Graphics.FillRectangle(windowBrush, newWindow);
      e.Graphics.DrawLine(blackPen, 250, 350, 250, 450);
      e.Graphics.DrawLine(blackPen, 200, 400, 300, 400);
      Point newTruba1 = new Point(270, 202);
      Point newTruba2 = new Point(300, 240);
      Point newTruba3 = new Point(270, 180);
      Point newTruba4 = new Point(300, 180);
      SolidBrush grayBrush = new SolidBrush(Color.Gray);
      Point[] truba = {newTruba1, newTruba2, newTruba4, newTruba3};
      e.Graphics.DrawPolygon(blackPen, truba);
      e.Graphics.FillPolygon(grayBrush, truba);
    }
    private void button1_Click(object sender, EventArgs e)
    {
      SolidBrush grayBrush = new SolidBrush(Color.Gray);
      if (flag != true)
      {
        Rectangle makeSmoke = new Rectangle(268, 160, 35, 38);
        float startAngle = 0.0F;
        float sweepAngle = -180.0F;
        this.CreateGraphics().FillPie(grayBrush, makeSmoke, startAngle, sweepAngle);
      }
      else
      {

      }
    }
  }
}
