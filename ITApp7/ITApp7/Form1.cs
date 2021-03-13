using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITApp7
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

   private void button1_Click(object sender, EventArgs e)
   {
      listBox1.Items.Add(textBox1.Text);
      textBox1.Text = "";
   }
    //Индивидуальное задание 5
    private void button2_Click(object sender, EventArgs e)
    {
      int number = listBox1.SelectedIndex;
      string word = (string)listBox1.Items[number];
      label3.Text = "Полученное слово: " + Reverse(word);
    }
    public static string Reverse(string s)
    {
      char[] charArray = s.ToCharArray();
      Array.Reverse(charArray);
      return new string(charArray);
    }

  }
}
