using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication16
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("انقر على الواجهة للحصول على الوان مختلفه","ترحيب",MessageBoxButtons.OKCancel);
            this.CenterToParent();
            txt_show.Text = "منور محمد حزام" + "\r\n";
            button2.Text = "اغلاق";
            this.Text = "المشروع الاول المحاظره الرابعه";
            label1.Text = "ادخل النص";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
          
            if (txt_enter.Text.Trim() != "" && !isnumber(txt_enter.Text))
            {
                txt_show.Text += txt_enter.Text + "\r\n".ToString();
                txt_enter.Focus();
                txt_enter.Clear();
            }
            else {
                MessageBox.Show("خطاء في مربع النص");
                txt_enter.Focus();
                txt_enter.Clear();
            }
        }
        private bool isnumber(string str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] >= 48 && str[i] <= 57)
                {
                    return true;
                }
            }
            return false;
        }
        private void btn_add_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            Random r = new Random();
            this.BackColor = Color.FromArgb(r.Next(0,255),r.Next(0,255),r.Next(0,255));
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("مع السلامه");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Form1_MouseHover(object sender, EventArgs e)
        {
           
        }
        private void btn_add_MouseHover(object sender, EventArgs e)
        {
       
            btn_add.BackColor = Color.Yellow;
            btn_add.ForeColor = Color.Red;
        }
        private void txt_enter_TextChanged(object sender, EventArgs e)
        {
            if (txt_enter.Text.Trim() != "")
                txt_enter.BackColor = Color.Yellow;
            else
                txt_enter.BackColor = Color.White;
        }
        private void btn_add_MouseLeave(object sender, EventArgs e)
        {
            btn_add.BackColor = Color.Gray;
            btn_add.ForeColor = Color.Black;
      
        }

        private void btn_add_MouseEnter(object sender, EventArgs e)
        {
            //btn_add.BackColor = Color.Red;
            //btn_add.ForeColor = Color.White;
        }
    }
}
