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
    public partial class Form2 : Form
    {
        
        string[] array ;
        int counter = 0;
        int size = 0;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            butAdd.Text = "اضافة";
            butshow.Text = "عرض العنصر";
            butremove.Text = "حذف العنصر";
            busumation.Text = "المجموع";
            label1.Text = "ادخل عدد العناصر";
            label2.Text = "ادخل الرقم";
            butAdd.Enabled = butshow.Enabled = butremove.Enabled = busumation.Enabled =listBox1.Enabled =textBox2.Enabled=false;
            textBox4.Enabled = false;
            Random r = new Random();
            this.BackColor = Color.FromArgb(r.Next(0, 255), r.Next(0, 255), r.Next(0, 255));
            this.CenterToParent();
            this.Text = "المشروع الثاني المحاظره الرابعة";
            textBox1.TextChanged += textBox1_MouseLeave;
        }
        static void key_press(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < 48 || e.KeyChar > 57)
                e.Handled = true;
            if (e.KeyChar == 8)
                e.Handled = false;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            bool f = (textBox1.Text.Trim() != "");
                butAdd.Enabled = butshow.Enabled = butremove.Enabled = busumation.Enabled = listBox1.Enabled = textBox2.Enabled = f;
           
        }

        private void textBox1_MouseLeave(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() != "")
            {
                size = int.Parse(textBox1.Text);
                array = new string[size+5];
                counter = 0;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Trim() != "")
                if (counter < size)
                {
                    array[counter++] = textBox2.Text.Trim();
                    textBox2.Clear();
                    textBox2.Focus();
                }
                else
                {
                    MessageBox.Show("تجاوزت حجم المصفوفه");
                    textBox2.Clear();
                }
            else
            {
                MessageBox.Show("ادخل العدد");
                textBox2.Focus();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            if (counter > 0)
            {
                listBox1.Items.Clear();
                for (int i = 0; i < counter; i++)
                    listBox1.Items.Add(array[i]);
                //counter = 0;
                //size = 0;
                //array=new string[size];
            }
            else
                MessageBox.Show("لا يوجد عناصر");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int b = listBox1.Items.Count;
            if (b > 0 && listBox1.SelectedIndex!=-1)
            {
               // for (int h = 1; h <= b; h++)
                    listBox1.Items.RemoveAt(listBox1.SelectedIndex);
                 //   array[listBox1.SelectedIndex]= null;
               // counter = size = 0;
              
                    textBox1.Text = (Convert.ToInt32(textBox1.Text) - 1).ToString();
                    //size += 1;
                    counter -= 1;
                   // array = new string[size];
               // textBox4.Text = textBox2.Text = textBox1.Text = "";
               // Form2_Load(null, null);
            }
            else
                MessageBox.Show(" لا يوجد عناصر");
 
        }

        private void busumation_Click(object sender, EventArgs e)
        {
            int s = 0;
         if (listBox1.Items.Count > 0)
       {
          for (int h = 0; h < counter; h++)
             {
             s += int.Parse(array[h]);
             }
          textBox4.Text = s.ToString();   
         }
         else
            MessageBox.Show("  لا يوجد عناصر");
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
