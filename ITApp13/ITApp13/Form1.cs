using System;
using System.Drawing;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Threading;

namespace ITApp13
{
  public partial class Form1 : Form
  {
    private Bitmap bmp;
    private Graphics g;

    public Form1()
    {
      InitializeComponent();
    }

    private void button2_Click(object sender, EventArgs e)
    {
      SaveFileDialog savedialog = new SaveFileDialog();
      savedialog.Title = "Сохранить картинку как ...";
      savedialog.OverwritePrompt = true;
      savedialog.CheckPathExists = true;
      savedialog.Filter =
      "Bitmap File(*.bmp)|*.bmp|" +
      "GIF File(*.gif)|*.gif|" +
      "JPEG File(*.jpg)|*.jpg|" +
      "TIF File(*.tif)|*.tif|" +
      "PNG File(*.png)|*.png";
      savedialog.ShowHelp = true;
      // If selected, save
      if (savedialog.ShowDialog() == DialogResult.OK)
      {
        string fileName = savedialog.FileName;
        string strFilExtn = fileName.Remove(0, fileName.Length - 3);
        switch (strFilExtn)
        {
          case "bmp":
            bmp.Save(fileName, System.Drawing.Imaging.ImageFormat.Bmp);
            break;
          case "jpg":
            bmp.Save(fileName, System.Drawing.Imaging.ImageFormat.Jpeg);
            break;
          case "gif":
            bmp.Save(fileName, System.Drawing.Imaging.ImageFormat.Gif);
            break;
          case "tif":
            bmp.Save(fileName, System.Drawing.Imaging.ImageFormat.Tiff);
            break;
          case "png":
            bmp.Save(fileName, System.Drawing.Imaging.ImageFormat.Png);
            break;
          default:
            break;
        }
      }
    }
    void turnRed()
    {
      for (int i = 0; i < bmp.Width; i++)
      {
        for (int j = 0; j < bmp.Height; j++)
        {
          int R = bmp.GetPixel(i, j).R;
          Color p = Color.FromArgb(255, R, 0, 0);
          bmp.SetPixel(i, j, p);
          this.Invoke(new Action(() => { Refresh(); }));
          Thread.Sleep(100);
        }
      }
    }
    void turnGreen()
    {
      for (int i = 0; i < bmp.Width; i++)
      {
        for (int j = 0; j < bmp.Height; j++)
        {
          int R = bmp.GetPixel(i, j).G;
          Color p = Color.FromArgb(255, 0, R, 0);
          bmp.SetPixel(i, j, p);
          this.Invoke(new Action(() => { Refresh(); }));
          Thread.Sleep(100);
        }
      }
    }
    void turnBlue()
    {
      for (int i = 0; i < bmp.Width; i++)
      {
        for (int j = 0; j < bmp.Height; j++)
        {
          int R = bmp.GetPixel(i, j).B;
          Color p = Color.FromArgb(255, 0, 0, R);
          bmp.SetPixel(i, j, p);
          this.Invoke(new Action(() => { Refresh(); }));
          Thread.Sleep(100);
        }
      }
    }
    private async void button3_Click(object sender, EventArgs e)
    {
      button3.Enabled = false;
      button4.Enabled = false;
      button5.Enabled = false;
      await Task.Run(() => { turnRed(); });
      button3.Enabled = true;
      button4.Enabled = true;
      button5.Enabled = true;
    }

    private async void button4_Click(object sender, EventArgs e)
    {
      button3.Enabled = false;
      button4.Enabled = false;
      button5.Enabled = false;
      await Task.Run(() => { turnGreen(); });
      button3.Enabled = true;
      button4.Enabled = true;
      button5.Enabled = true;
    }

    private async void button5_Click(object sender, EventArgs e)
    {
      button3.Enabled = false;
      button4.Enabled = false;
      button5.Enabled = false;
      await Task.Run(() => { turnBlue(); });
      button3.Enabled = true;
      button4.Enabled = true;
      button5.Enabled = true;
    }

    private void button1_Click(object sender, EventArgs e)
      {
        OpenFileDialog dialog = new OpenFileDialog();
        dialog.Filter = "Image files (*.BMP, *.JPG, *.GIF, *.TIF, *.PNG, *.ICO, *.EMF, *.WMF)|*.bmp;*.jpg;*.gif; *.tif; *.png; *.ico; *.emf; *.wmf";
        if (dialog.ShowDialog() == DialogResult.OK)
        {
          Image image = Image.FromFile(dialog.FileName);
          int width = image.Width;
          int height = image.Height;
          pictureBox1.Width = width;
          pictureBox1.Height = height;
          bmp = new Bitmap(image, width, height);
          pictureBox1.Image = bmp;
          g = Graphics.FromImage(pictureBox1.Image);
        }
      }

    private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
    {
      turnRed();
    }

    private void backgroundWorker2_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
    {
      turnGreen();
    }

    private void backgroundWorker3_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
    {
      turnBlue();
    }
  }
  }
