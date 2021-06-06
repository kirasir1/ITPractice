using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace SQLapp
{
  public partial class LoginForm : Form
  {
    Point lastPoint;
    public LoginForm()
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

    private void LoginForm_MouseMove(object sender, MouseEventArgs e)
    {
      if(e.Button == MouseButtons.Left)
      {
        Left += e.X - lastPoint.X;
        Top += e.Y - lastPoint.Y;
      }
    }

    private void LoginForm_MouseDown(object sender, MouseEventArgs e)
    {
      lastPoint = new Point(e.X, e.Y);
    }

    private void label1_MouseDown(object sender, MouseEventArgs e)
    {
      lastPoint = new Point(e.X, e.Y);
    }

    private void label1_MouseMove(object sender, MouseEventArgs e)
    {
      if (e.Button == MouseButtons.Left)
      {
        Left += e.X - lastPoint.X;
        Top += e.Y - lastPoint.Y;
      }
    }

    private void buttonLogin_Click(object sender, EventArgs e)
    {
 
      DB db = new DB();
      DataTable table = new DataTable();
      MySqlDataAdapter adapter = new MySqlDataAdapter();
      MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @uL AND `password` = @uP", db.getConnection());
      command.Parameters.Add("@uL",MySqlDbType.VarChar).Value = loginField.Text;
      command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = passField.Text;
      adapter.SelectCommand = command;
      adapter.Fill(table);
      if (table.Rows.Count > 0)
      { Hide();
        MainForm mainForm = new MainForm();
        mainForm.Show();  }
      else
        MessageBox.Show("No");
    }

    private void RegisterLabel_Click(object sender, EventArgs e)
    {
      Hide();
      RegisterForm registerForm = new RegisterForm();
      registerForm.Show();
    }
  }
}
