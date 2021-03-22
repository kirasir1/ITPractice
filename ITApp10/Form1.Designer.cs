namespace Pakindrom4
{
  partial class Form1
  {
    /// <summary>
    /// Обязательная переменная конструктора.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Освободить все используемые ресурсы.
    /// </summary>
    /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Код, автоматически созданный конструктором форм Windows

    /// <summary>
    /// Требуемый метод для поддержки конструктора — не изменяйте 
    /// содержимое этого метода с помощью редактора кода.
    /// </summary>
    private void InitializeComponent()
    {
      this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
      this.SuspendLayout();
      // 
      // vScrollBar1
      // 
      this.vScrollBar1.Dock = System.Windows.Forms.DockStyle.Right;
      this.vScrollBar1.Location = new System.Drawing.Point(1453, 0);
      this.vScrollBar1.Name = "vScrollBar1";
      this.vScrollBar1.Size = new System.Drawing.Size(17, 664);
      this.vScrollBar1.TabIndex = 0;
      this.vScrollBar1.Value = 100;
      this.vScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vScrollBar1_Scroll);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1470, 664);
      this.Controls.Add(this.vScrollBar1);
      this.Name = "Form1";
      this.Text = "Form1";
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.Load += new System.EventHandler(this.Form1_Load);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.VScrollBar vScrollBar1;
  }
}

