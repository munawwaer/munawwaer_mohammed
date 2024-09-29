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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            this.Text = "المشروع الرابع المحاظره الرابعه";

        }
        int formwidth = 0;
        int formheith = 0;
        private void button10_Click(object sender, EventArgs e)
        {
            button10.TextAlign=ContentAlignment.MiddleCenter;
            button10.Dock = DockStyle.Top;
         }

        private void weekEvents(object sender, EventArgs e)
        { 
        if(sender==button1)
            button10.Size = new Size(button10.Width, button10.Height + 5);
        else if(sender==button2) 
             button10.Size = new Size(button10.Width ,button10.Height -5);
        else if(sender==button3)
             button10.Size = new Size( button10.Width-5,button10.Height );
        else if(sender==button4)
             button10.Size = new Size(button10.Width+5,button10.Height  );
        else if(sender==button5)
             button10.Location = new Point(button10.Left, button10.Top - 5);
        else if(sender==button6)
            button10.Location = new Point(button10.Left, button10.Top + 5);
        else if(sender==button7)
            button10.Location = new Point(button10.Left - 5, button10.Top);
        else if(sender==button8)
            button10.Location = new Point(button10.Left + 5, button10.Top);

        }
        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
        }

        private void button5_Click(object sender, EventArgs e)
        {
           
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
           
        }

        private void button8_Click(object sender, EventArgs e)
        {
            
        }

        private void button9_Click(object sender, EventArgs e)
        {

          

            if (radioButtonup.Checked)
            {
                while(true)
                {
                    
                    if (button10.Top <=5 )
                        break;
                    if (checkBox1.Checked)
                    {
                        button10.Top -= 5;
                      
                    }
                    else if (checkBox2.Checked)
                    {
                        button10.Top -= 10;
                     
                    }
                    else if (checkBox4.Checked)
                    {
                        button10.Top -= 15;
                       
                    }
                    else if (checkBox5.Checked)
                    {
                        button10.Top -= 20;
                      
                    }
                    for (int j = 0; j < 100000000; j++) ;
                }
            }
            else if (radioButtondown.Checked)
            {
               while(true)
                {
                    
                   // MessageBox.Show(button10.Top.ToString());
                    if (checkBox1.Checked)
                    {
                        button10.Top += Convert.ToInt32(checkBox1.Text);
                      
                    }
                    else if (checkBox2.Checked)
                    {
                        button10.Top += Convert.ToInt32(checkBox2.Text);
                       
                    }
                    else if (checkBox4.Checked)
                    {
                        button10.Top += Convert.ToInt32(checkBox4.Text);
                      
                    }
                    else if (checkBox5.Checked)
                    {
                        button10.Top += Convert.ToInt32(checkBox5.Text);
                     
                    }
                    for (int j = 0; j < 100000000; j++) ;
                    if (button10.Top >= formheith-100)
                        break;
                }
            }

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            //ناخذ الطول والعرض للفورم لكي نتحكم فيه عند تحريك الادوات
            formheith = this.Height;
            formwidth = this.Width;
            //تضعيف الاحداث لكي تتم عليهم استدعاء الداله واحده
            button1.Click += weekEvents;
            button2.Click += weekEvents; 
            button3.Click += weekEvents;
            button4.Click += weekEvents; 
            button5.Click += weekEvents;
            button6.Click += weekEvents;
            button7.Click += weekEvents;
            button8.Click += weekEvents;
           

        }

       
    }
}
