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
         foreach (var button in new[] { button1, button2, button3, button4, button5, button6, button7, button8 })
            {
                if (sender == button1)
                    button.Size = new Size(button.Width, button.Height + 5);
                else if (sender == button2)
                    button.Size = new Size(button.Width, button.Height - 5);
                else if (sender == button3)
                    button.Size = new Size(button.Width - 5, button.Height);
                else if (sender == button4)
                    button.Size = new Size(button.Width + 5, button.Height);
                else if (sender == button5)
                    button.Location = new Point(button.Left, button.Top - 5);
                 else if (sender == button6)
                        button.Location = new Point(button.Left, button.Top + 5);
                  else if (sender == button7)
                        button.Location = new Point(button.Left - 5, button.Top);
                 else if (sender == button8)
                        button.Location = new Point(button.Left + 5, button.Top);
                        }
//طريفه اخري معقده شويه 
                    //if (sender == button1)
                    //{
                    //    // button10.Size = new Size(button10.Width, button10.Height + 5);
                    //    button1.Size = new Size(button1.Width, button1.Height + 5);
                    //    button2.Size = new Size(button2.Width, button2.Height + 5);
                    //    button3.Size = new Size(button3.Width, button3.Height + 5);
                    //    button4.Size = new Size(button4.Width, button4.Height + 5);
                    //    button5.Size = new Size(button5.Width, button5.Height + 5);
                    //    button6.Size = new Size(button6.Width, button6.Height + 5);
                    //    button7.Size = new Size(button7.Width, button7.Height + 5);
                    //    button8.Size = new Size(button8.Width, button8.Height + 5);

                    //}
                    //else if (sender == button2)
                    //{
                    //    //button10.Size = new Size(button10.Width, button10.Height - 5);
                    //    button1.Size = new Size(button1.Width, button1.Height - 5);
                    //    button2.Size = new Size(button2.Width, button2.Height - 5);
                    //    button3.Size = new Size(button3.Width, button3.Height - 5);
                    //    button4.Size = new Size(button4.Width, button4.Height - 5);
                    //    button5.Size = new Size(button5.Width, button5.Height - 5);
                    //    button6.Size = new Size(button6.Width, button6.Height - 5);
                    //    button7.Size = new Size(button7.Width, button7.Height - 5);
                    //    button8.Size = new Size(button8.Width, button8.Height - 5);
                    //}
                    //else if (sender == button3)
                    //{
                    //   // button10.Size = new Size(button10.Width - 5, button10.Height);
                    //    button1.Size = new Size(button1.Width-5, button1.Height );
                    //    button2.Size = new Size(button2.Width-5, button2.Height );
                    //    button3.Size = new Size(button3.Width-5, button3.Height );
                    //    button4.Size = new Size(button4.Width-5, button4.Height );
                    //    button5.Size = new Size(button5.Width-5, button5.Height );
                    //    button6.Size = new Size(button6.Width-5, button6.Height );
                    //    button7.Size = new Size(button7.Width-5, button7.Height );
                    //    button8.Size = new Size(button8.Width-5, button8.Height );
                    //}
                    //else if (sender == button4)
                    //{
                    //  //  button10.Size = new Size(button10.Width + 5, button10.Height);
                    //    button1.Size = new Size(button1.Width + 5, button1.Height);
                    //    button2.Size = new Size(button2.Width + 5, button2.Height );
                    //    button3.Size = new Size(button3.Width + 5, button3.Height );
                    //    button4.Size = new Size(button4.Width + 5, button4.Height );
                    //    button5.Size = new Size(button5.Width + 5, button5.Height );
                    //    button6.Size = new Size(button6.Width + 5, button6.Height );
                    //    button7.Size = new Size(button7.Width + 5, button7.Height );
                    //    button8.Size = new Size(button8.Width + 5, button8.Height );
                    //}
                    //else if (sender == button5)
                    //{
                    //   // button10.Location = new Point(button10.Left, button10.Top - 5);
                    //    button1.Location = new Point(button1.Left, button1.Top - 5);
                    //    button2.Location = new Point(button2.Left, button2.Top - 5);
                    //    button3.Location = new Point(button3.Left, button3.Top - 5);
                    //    button4.Location = new Point(button4.Left, button4.Top - 5);
                    //    button5.Location = new Point(button5.Left, button5.Top - 5);
                    //    button6.Location = new Point(button6.Left, button6.Top - 5);
                    //    button7.Location = new Point(button7.Left, button7.Top - 5);
                    //    button8.Location = new Point(button8.Left, button8.Top - 5);
                    //}
                    //else if (sender == button6)
                    //{
                    //   // button10.Location = new Point(button10.Left, button10.Top + 5);
                    //    button1.Location = new Point(button1.Left, button1.Top + 5);
                    //    button2.Location = new Point(button2.Left, button2.Top + 5);
                    //    button3.Location = new Point(button3.Left, button3.Top + 5);
                    //    button4.Location = new Point(button4.Left, button4.Top + 5);
                    //    button5.Location = new Point(button5.Left, button5.Top + 5);
                    //    button6.Location = new Point(button6.Left, button6.Top + 5);
                    //    button7.Location = new Point(button7.Left, button7.Top + 5);
                    //    button8.Location = new Point(button8.Left, button8.Top + 5);
                    //}
                    //else if (sender == button7)
                    //{
                    //   // button10.Location = new Point(button10.Left - 5, button10.Top);
                    //    button1.Location = new Point(button1.Left - 5, button1.Top);
                    //    button2.Location = new Point(button2.Left - 5, button2.Top);
                    //    button3.Location = new Point(button3.Left - 5, button3.Top);
                    //    button4.Location = new Point(button4.Left - 5, button4.Top);
                    //    button5.Location = new Point(button5.Left - 5, button5.Top);
                    //    button6.Location = new Point(button6.Left - 5, button6.Top);
                    //    button7.Location = new Point(button7.Left - 5, button7.Top);
                    //    button8.Location = new Point(button8.Left - 5, button8.Top);
                    //}
                    //else if (sender == button8)
                    //{
                    //   // button10.Location = new Point(button10.Left + 5, button10.Top);
                    //    button1.Location = new Point(button1.Left + 1, button1.Top);
                    //    button2.Location = new Point(button2.Left + 5, button2.Top);
                    //    button3.Location = new Point(button3.Left + 5, button3.Top);
                    //    button4.Location = new Point(button4.Left + 5, button4.Top);
                    //    button5.Location = new Point(button5.Left + 5, button5.Top);
                    //    button6.Location = new Point(button6.Left + 5, button6.Top);
                    //    button7.Location = new Point(button7.Left + 5, button7.Top);
                    //    button8.Location = new Point(button8.Left + 5, button8.Top);
                    //}
                    //التنفيذ الاول تم الغائه من قبل الاستاذ
       // if(sender==button1)
       //      button10.Size = new Size(button10.Width, button10.Height + 5);
       //  else if(sender==button2) 
       //       button10.Size = new Size(button10.Width ,button10.Height -5);
       //  else if(sender==button3)
       //       button10.Size = new Size( button10.Width-5,button10.Height );
       //  else if(sender==button4)
       //       button10.Size = new Size(button10.Width+5,button10.Height  );
       //  else if (sender==button5)
       //       button10.Location = new Point(button10.Left, button10.Top - 5);
       //  else if(sender==button6)
       //      button10.Location = new Point(button10.Left, button10.Top + 5);
       //  else if(sender==button7)
       //      button10.Location = new Point(button10.Left - 5, button10.Top);
       //  else if(sender==button8)
       //      button10.Location = new Point(button10.Left + 5, button10.Top);

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
