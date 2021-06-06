using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQLapp
{
  public partial class RegisterForm : Form
  {
    Point lastPoint;
    public RegisterForm()
    {
      InitializeComponent();
      userNameField.Text = "Введите имя";
      userSurnameField.Text = "Введите фамилию";
      loginField.Text = "Введите логин";
      
      userNameField.ForeColor = userSurnameField.ForeColor = loginField.ForeColor =  Color.Silver;
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

    private void RegisterForm_MouseMove(object sender, MouseEventArgs e)
    {
      if (e.Button == MouseButtons.Left)
      {
        Left += e.X - lastPoint.X;
        Top += e.Y - lastPoint.Y;
      }
    }

    private void RegisterForm_MouseDown(object sender, MouseEventArgs e)
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

    private void userNameField_Enter(object sender, EventArgs e)
    {
      if (userNameField.Text == "Введите имя") 
      {
        userNameField.Text = "";
        userNameField.ForeColor = Color.Black;
      }
    }

    private void userNameField_Leave(object sender, EventArgs e)
    {
      if (userNameField.Text == "")
      {
        userNameField.Text = "Введите имя";
        userNameField.ForeColor = Color.Silver;
      }
    }

    private void userSurnameField_Enter(object sender, EventArgs e)
    {
      if (userSurnameField.Text == "Введите фамилию")
      {
        userSurnameField.Text = "";
        userSurnameField.ForeColor = Color.Black;
      }
    }

    private void userSurnameField_Leave(object sender, EventArgs e)
    {
      if (userSurnameField.Text == "")
      {
        userSurnameField.Text = "Введите фамилию";
        userSurnameField.ForeColor = Color.Silver;
      }
    }

    private void loginField_Enter(object sender, EventArgs e)
    {
      if (loginField.Text == "Введите логин")
      {
        loginField.Text = "";
        loginField.ForeColor = Color.Black;
      }
    }

    private void loginField_Leave(object sender, EventArgs e)
    {
      if (loginField.Text == "")
      {
        loginField.Text = "Введите логин";
        loginField.ForeColor = Color.Silver;
      }
    }

    private void buttonRegister_Click(object sender, EventArgs e)
    {
      if (userNameField.Text == "Введите имя")
      {
        MessageBox.Show("Введите имя");
        return;
      }
      if (userSurnameField.Text == "Введите фамилию")
      {
        MessageBox.Show("Введите фамилию");
        return;
      }

      if (isUserExist()) 
        return;

      DB db = new DB();
      MySqlCommand command = new MySqlCommand("INSERT INTO `users` (`login`, `name`, `surname`, `password`) VALUES (@lg, @nm, @sn, @ps)", db.getConnection());
      command.Parameters.Add("@lg", MySqlDbType.VarChar).Value = loginField.Text;
      command.Parameters.Add("@ps", MySqlDbType.VarChar).Value = passField.Text;
      command.Parameters.Add("@nm", MySqlDbType.VarChar).Value = userNameField.Text;
      command.Parameters.Add("@sn", MySqlDbType.VarChar).Value = userSurnameField.Text;
      db.openConnection();


      if (command.ExecuteNonQuery() == 1)
      {
        Hide();
        MainForm mainForm = new MainForm();
        mainForm.Show();
      }
      else 
        MessageBox.Show("Аккаунт не был создан");


      db.closeConnection();
    }

    public bool isUserExist()
    {
      DB db = new DB();
      DataTable table = new DataTable();
      MySqlDataAdapter adapter = new MySqlDataAdapter();
      MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @uL ", db.getConnection());
      command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginField.Text;
      adapter.SelectCommand = command;
      adapter.Fill(table);
      if (table.Rows.Count > 0)
      {
        MessageBox.Show("Такой логин уже используется, введите другой");
        return true;
      }
      else {
        return false;
          };
    }

    private void label2_Click(object sender, EventArgs e)
    {
      Hide();
      LoginForm loginForm = new LoginForm();
      loginForm.Show();
    }
  }
}
