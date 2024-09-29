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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Houme(0,listBox1.Items.Count);
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            this.Text = "المشروع من نماذج الدكتور فهد";

        }
        private bool set(ListBox list,string n)
        { 
            int size=list.Items.Count;
        for (int i = 0; i < size; i++)
        {
            if (list.Items[i].ToString() == n)
                return false;
        }
        return true;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() != "")
            {
                if (set(listBox1, textBox1.Text))
                {
                    listBox1.Items.Add(textBox1.Text);
                    textBox1.Clear();
                    textBox1.Focus();
                }
                else
                {
                    MessageBox.Show("العدد موجود سابقا.");
                }
            }
            else
                MessageBox.Show("ادخل العدد");
        }
        private void Houme(int start,int end)
        {
            if (radioEven.Checked)
            {
                for (int i = start; i < end; i++)
                {
                    if (Convert.ToInt32(listBox1.Items[i]) % 2 == 0)
                    {
                        if (set(listBox2, listBox1.Items[i].ToString()))
                        {
                            listBox2.Items.Add(listBox1.Items[i]);
                        }
                    }
                }
            }
            if (radiodd.Checked)
            {
                for (int i = start; i < end; i++)
                {
                    if (Convert.ToInt32(listBox1.Items[i]) % 2 != 0)
                    {
                        if (set(listBox2, listBox1.Items[i].ToString()))
                        {
                            listBox2.Items.Add(listBox1.Items[i]);
                        }
                    }
                }
            }
            if (radioprimary.Checked)
            {
                for (int i = start; i < end; i++)
                {
                    bool f = true;
                    for (int j = 2; j < Convert.ToInt32(listBox1.Items[i]) / 2+1; j++)
                    {
                      
                        if (Convert.ToInt32(listBox1.Items[i]) % j == 0)
                        {
                            f = false;
                            break;
                        }
                    }
                    if (f)
                    {
                        if (set(listBox2, listBox1.Items[i].ToString()))
                        {
                            listBox2.Items.Add(listBox1.Items[i]);
                        }
                    }
                }
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                Houme(listBox1.SelectedIndex, listBox1.SelectedIndex + 1);
            }
            else
                MessageBox.Show("ححد العنصر المراد نقلة");
        }
    }
}
