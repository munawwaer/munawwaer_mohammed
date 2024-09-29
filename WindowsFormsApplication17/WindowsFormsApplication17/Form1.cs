using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication17
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
                label3.BackColor = Color.Red;
            else if(radioButton2.Checked)
                label3.BackColor = Color.Green;
            else if (radioButton3.Checked)
                label3.BackColor = Color.Blue;
            else if (radioButton4.Checked)
                label3.BackColor = Color.Beige;

            if (radioButton5.Checked)
                label3.ForeColor = Color.Green;
            else if (radioButton6.Checked)
                label3.ForeColor = Color.Red;
            else if (radioButton7.Checked)
                label3.ForeColor = Color.Beige;
            else if (radioButton8.Checked)
                label3.ForeColor = Color.Blue;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int s=0;
            bool f=false;
            if (checkBox1.Checked)
            {
                s += Convert.ToInt32(checkBox1.Text);
                f = true;
            }
                if (checkBox2.Checked)
            {
                s += Convert.ToInt32(checkBox2.Text);
                f = true;
            } 
            if (checkBox3.Checked)
            {
                s += Convert.ToInt32(checkBox3.Text);
                f = true;
            } 
            if (checkBox4.Checked)
            {
                s += Convert.ToInt32(checkBox4.Text);
                f = true;
            }
            if (f)
                textBox1.Text = s.ToString();


 
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            radioButton1.Text = "Red";
            radioButton2.Text = "Green";
            radioButton3.Text = "Blue";
            radioButton4.Text = "Beige";
            radioButton5.Text = "Green";
            radioButton6.Text = "Red";
            radioButton7.Text = "Beige";
            radioButton8.Text = "Blue";
            button3.Click += EnabelAndvisible;
            button4.Click += EnabelAndvisible;
            button5.Click += EnabelAndvisible;
            button6.Click += EnabelAndvisible;
            this.Text = "المشروع الاول المحاظره الخامسة";

                AutoScroll=true;
        }
        private void EnabelAndvisible(object sender, EventArgs e)
        { 
            if(sender==button3)
                 panel1.Enabled = true;
            else  if(sender==button4) 
                 panel1.Visible = true;
            else  if(sender==button5)
                 panel1.Enabled = false;
            else  if(sender==button6)
                panel1.Visible = false;
        }
        private void button3_Click(object sender, EventArgs e)
        {
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
           
        }

        private void button6_Click(object sender, EventArgs e)
        {
           
        }
    }
}
