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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            
            if(textBox1.Text!=""&&textBox2.Text!="")
                textBox3.Text=Convert.ToString(int.Parse(textBox2.Text)+int.Parse(textBox1.Text));
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
            button1.Click += chak_visible;
            button2.Click += chak_visible;
            button3.Click += chak_visible;
            button4.Click += chak_visible;
            textBox1.KeyPress += keyprass;
            textBox2.KeyPress += keyprass;
            textBox5.KeyPress += keyprass;
            textBox6.KeyPress += keyprass;
            textBox8.KeyPress += keyprass;
            textBox9.KeyPress += keyprass;
            textBox11.KeyPress += keyprass;
            textBox12.KeyPress += keyprass;
            textBox10.Enabled =false;
            textBox3.Enabled = false;
            textBox4.Enabled = false;

        }
        private void keyprass(object sender,KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8)
                e.Handled = true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
        

        }
        
        private void chak_visible(object sender, EventArgs e)
        {
            if (sender == button1)
            {
                panel2.Visible = true;
                panel3.Visible = false;
                panel4.Visible = false;
                panel1.Visible = false;
            }
            else if (sender == button2)
            {
                panel1.Visible = true;
                panel2.Visible = false;
                panel3.Visible = false;
                panel4.Visible = false;
            }
            else if (sender == button3)
            {
                panel3.Visible = true;
                panel1.Visible = false;
                panel2.Visible = false;
                panel4.Visible = false;
            }
            else if (sender == button4)
            {
                panel4.Visible = true;
                panel1.Visible = false;
                panel2.Visible = false;
                panel3.Visible = false;

            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox8.Text != "" && textBox9.Text != "")
                textBox7.Text = Convert.ToString(int.Parse(textBox8.Text) - int.Parse(textBox9.Text));
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox5.Text != "" && textBox6.Text != "")
                textBox4.Text = Convert.ToString(int.Parse(textBox5.Text) / int.Parse(textBox6.Text));
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (textBox11.Text != "" && textBox12.Text != "")
                textBox10.Text = Convert.ToString(int.Parse(textBox11.Text) * int.Parse(textBox12.Text));
        }
    }
}
