using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITApp9
{
  public partial class Form1 : Form
  {

    public Form1()
    {
      InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      dataGridView1.RowCount = 5;
      dataGridView1.ColumnCount = 5;
      double[,] massive = new double[5, 5];
      int i, j;
      Random rand = new Random();
      for (i = 0; i < 5; i++)
        for (j = 0; j < 5; j++)
          massive[i, j] = rand.Next(-50, 50);
      for (i = 0; i < 5; i++)
        for (j = 0; j < 5; j++)
          dataGridView1.Rows[i].Cells[j].Value = Convert.ToString(massive[i, j]);
      //индивидуальное задание №4
      double[] minV = new double[5];
      for (i = 0; i < 5; i++)
      {
        double m = double.MaxValue;
        for (j = 0; j < 5; j++)
        {
          if (massive[i, j] < m)
          {
            m = massive[i, j];
            minV[i] = m;
          }
        }
      }
      double minminmin = double.MinValue;
      for (i = 0; i < 5; i++)
      {
        if (minV[i] > minminmin) minminmin = minV[i];
      }
      textBox1.Text = Convert.ToString(minminmin);
      double fa = GetDeterminant(massive);
      textBox2.Text = Convert.ToString(fa);
    }
    static public double GetDeterminant(double[,] matrix)
    {
      if (matrix.GetLength(0) == 2) return matrix[0, 0] * matrix[1, 1] - matrix[0, 1] * matrix[1, 0];
      double result = 0;
      int j = 0;
      for (int i = 0; i < matrix.GetLength(0); i++)
      {
        if ((i + 1) % 2 == (j + 1) % 2) result += matrix[i, j] * GetDeterminant(GetMinorMatrix(matrix, i, j));
        else result += -matrix[i, j] * GetDeterminant(GetMinorMatrix(matrix, i, j));
      }
      return result;
    }
    static public double[,] GetMinorMatrix(double[,] matrix, int row, int col)
    {
      double[,] result = new double[matrix.GetLength(0) - 1, matrix.GetLength(1) - 1];
      int m = 0, k;
      for (int i = 0; i < matrix.GetLength(0); i++)
      {
        if (i == row) continue;
        k = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
          if (j == col) continue;
          result[m, k++] = matrix[i, j];
        }
        m++;
      }
      return result;
    }
  }
}
