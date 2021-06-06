using System;
using MySql.Data.MySqlClient;
using System.Data;
using System.Drawing;

using System.Windows.Forms;

namespace SQLapp
{
  public partial class MainForm : Form
  {

    Point lastPoint;
    public MainForm()
    {
      InitializeComponent();
    }

    private void ExitButton_Click(object sender, EventArgs e)
    {
      Application.Exit();
    }

    private void ExitButton_MouseEnter(object sender, EventArgs e)
    {
      ExitButton.ForeColor = Color.DarkGray;
    }

    private void ExitButton_MouseLeave(object sender, EventArgs e)
    {
      ExitButton.ForeColor = Color.White;
    }

    private void MainForm_MouseDown(object sender, MouseEventArgs e)
    {
      lastPoint = new Point(e.X, e.Y);
    }

    private void MainForm_MouseMove(object sender, MouseEventArgs e)
    {
      if (e.Button == MouseButtons.Left)
      {
        Left += e.X - lastPoint.X;
        Top += e.Y - lastPoint.Y;
      }
    }

    private void button1_Click(object sender, EventArgs e)
    {
      DB db = new DB();
      DataTable table = new DataTable();
      MySqlDataAdapter adapter = new MySqlDataAdapter();
      MySqlCommand command = new MySqlCommand("SELECT * FROM `users`", db.getConnection());
      adapter.SelectCommand = command;
      adapter.Fill(table);
      dataGridView1.DataSource = table;
    }
  }
}
