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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }
        string op;
        private void Form7_Load(object sender, EventArgs e)
        {
            panel2.Visible = false;
            button1.Click += opration;
            button2.Click += opration;
            button3.Click += opration;
            button4.Click += opration;
            this.Size = new Size(265, 272);
            label5.Text = "=";
            this.Text = "عمليات حسابية";
            panel1.BackColor = Color.Red;
            panel2.BackColor = Color.Aqua;
        }
        private void opration(object sender, EventArgs e)
        {
            textBox1.Text = textBox2.Text = textBox3.Text = "";
            label4.Text = "";
            this.Size = new Size(686, 272);
            panel2.Visible = true;
            if (sender == button1)
            {
                op = "+";
                button6.Text = "جـمـع";
            }
            else if (sender == button2)
            {
                op = "-";
                button6.Text = "طـرحـ";
            }
            else if (sender == button3)
            {
                op = "*";
                button6.Text = "ضـربـ";
            }
            else if (sender == button4)
            {
                op = "/";
                button6.Text = "قـسمـة";
            }
            label4.Text = op;
          
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Size = new Size(265, 272);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() != "" && textBox2.Text.Trim() != "")
            {
                switch (op)
                {
                    case "+":
                        textBox3.Text = Convert.ToString(int.Parse(textBox1.Text) + int.Parse(textBox2.Text));
                        break;
                    case "-":
                        textBox3.Text = Convert.ToString(int.Parse(textBox1.Text) - int.Parse(textBox2.Text));
                        break;
                    case "*":
                        textBox3.Text = Convert.ToString(int.Parse(textBox1.Text) * int.Parse(textBox2.Text));
                        break;
                    case "/":
                        if (textBox2.Text != "0")
                            textBox3.Text = Convert.ToString(int.Parse(textBox1.Text) + int.Parse(textBox2.Text));
                        else
                        {
                            MessageBox.Show("Error");
                            textBox2.Clear();
                            textBox2.Focus();
                        }
                        break;
                }

            }
            else
                MessageBox.Show("Error:");
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            
        }
    }
}
