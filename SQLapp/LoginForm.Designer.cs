
namespace SQLapp
{
  partial class LoginForm
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.label1 = new System.Windows.Forms.Label();
      this.ExitButton = new System.Windows.Forms.Label();
      this.loginField = new System.Windows.Forms.TextBox();
      this.passField = new System.Windows.Forms.TextBox();
      this.buttonLogin = new System.Windows.Forms.Button();
      this.RegisterLabel = new System.Windows.Forms.Label();
      this.pictureBox3 = new System.Windows.Forms.PictureBox();
      this.pictureBox2 = new System.Windows.Forms.PictureBox();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(47)))), ((int)(((byte)(61)))));
      this.label1.Dock = System.Windows.Forms.DockStyle.Top;
      this.label1.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label1.ForeColor = System.Drawing.SystemColors.Control;
      this.label1.Location = new System.Drawing.Point(0, 0);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(412, 105);
      this.label1.TabIndex = 0;
      this.label1.Text = "Вход в систему";
      this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
      this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label1_MouseMove);
      // 
      // ExitButton
      // 
      this.ExitButton.AutoSize = true;
      this.ExitButton.Cursor = System.Windows.Forms.Cursors.Hand;
      this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.ExitButton.ForeColor = System.Drawing.SystemColors.Control;
      this.ExitButton.Location = new System.Drawing.Point(383, 9);
      this.ExitButton.Name = "ExitButton";
      this.ExitButton.Size = new System.Drawing.Size(19, 18);
      this.ExitButton.TabIndex = 1;
      this.ExitButton.Text = "Х";
      this.ExitButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
      this.ExitButton.MouseEnter += new System.EventHandler(this.ExitButton_MouseEnter);
      this.ExitButton.MouseLeave += new System.EventHandler(this.ExitButton_MouseLeave);
      // 
      // loginField
      // 
      this.loginField.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.loginField.Location = new System.Drawing.Point(141, 177);
      this.loginField.Name = "loginField";
      this.loginField.Size = new System.Drawing.Size(210, 38);
      this.loginField.TabIndex = 3;
      // 
      // passField
      // 
      this.passField.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.passField.Location = new System.Drawing.Point(141, 274);
      this.passField.Name = "passField";
      this.passField.Size = new System.Drawing.Size(210, 32);
      this.passField.TabIndex = 3;
      this.passField.UseSystemPasswordChar = true;
      // 
      // buttonLogin
      // 
      this.buttonLogin.BackColor = System.Drawing.SystemColors.ActiveBorder;
      this.buttonLogin.Cursor = System.Windows.Forms.Cursors.Hand;
      this.buttonLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
      this.buttonLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
      this.buttonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.buttonLogin.Font = new System.Drawing.Font("Segoe UI Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.buttonLogin.Location = new System.Drawing.Point(123, 377);
      this.buttonLogin.Name = "buttonLogin";
      this.buttonLogin.Size = new System.Drawing.Size(174, 35);
      this.buttonLogin.TabIndex = 6;
      this.buttonLogin.Text = "Войти";
      this.buttonLogin.UseVisualStyleBackColor = false;
      this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
      // 
      // RegisterLabel
      // 
      this.RegisterLabel.AutoSize = true;
      this.RegisterLabel.BackColor = System.Drawing.Color.Transparent;
      this.RegisterLabel.Cursor = System.Windows.Forms.Cursors.Hand;
      this.RegisterLabel.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.RegisterLabel.ForeColor = System.Drawing.Color.White;
      this.RegisterLabel.Location = new System.Drawing.Point(152, 444);
      this.RegisterLabel.Name = "RegisterLabel";
      this.RegisterLabel.Size = new System.Drawing.Size(123, 16);
      this.RegisterLabel.TabIndex = 7;
      this.RegisterLabel.Text = "Ещё нет аккаунта?";
      this.RegisterLabel.Click += new System.EventHandler(this.RegisterLabel_Click);
      // 
      // pictureBox3
      // 
      this.pictureBox3.Image = global::SQLapp.Properties.Resources.user;
      this.pictureBox3.Location = new System.Drawing.Point(71, 161);
      this.pictureBox3.Name = "pictureBox3";
      this.pictureBox3.Size = new System.Drawing.Size(64, 64);
      this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.pictureBox3.TabIndex = 17;
      this.pictureBox3.TabStop = false;
      // 
      // pictureBox2
      // 
      this.pictureBox2.BackgroundImage = global::SQLapp.Properties.Resources._lock;
      this.pictureBox2.Image = global::SQLapp.Properties.Resources._lock;
      this.pictureBox2.InitialImage = global::SQLapp.Properties.Resources._lock;
      this.pictureBox2.Location = new System.Drawing.Point(71, 258);
      this.pictureBox2.Name = "pictureBox2";
      this.pictureBox2.Size = new System.Drawing.Size(64, 64);
      this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.pictureBox2.TabIndex = 20;
      this.pictureBox2.TabStop = false;
      this.pictureBox2.WaitOnLoad = true;
      // 
      // LoginForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(22)))), ((int)(((byte)(33)))));
      this.ClientSize = new System.Drawing.Size(412, 506);
      this.Controls.Add(this.pictureBox2);
      this.Controls.Add(this.pictureBox3);
      this.Controls.Add(this.RegisterLabel);
      this.Controls.Add(this.buttonLogin);
      this.Controls.Add(this.passField);
      this.Controls.Add(this.loginField);
      this.Controls.Add(this.ExitButton);
      this.Controls.Add(this.label1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.Name = "LoginForm";
      this.Text = "LoginForm";
      this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LoginForm_MouseDown);
      this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LoginForm_MouseMove);
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label ExitButton;
    private System.Windows.Forms.TextBox loginField;
    private System.Windows.Forms.TextBox passField;
    private System.Windows.Forms.Button buttonLogin;
    private System.Windows.Forms.Label RegisterLabel;
    private System.Windows.Forms.PictureBox pictureBox3;
    private System.Windows.Forms.PictureBox pictureBox2;
  }
}