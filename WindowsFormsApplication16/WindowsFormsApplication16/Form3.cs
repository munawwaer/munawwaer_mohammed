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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        int[] a;
        int size = 0;
        int counter = 0;
        private void Form3_Load(object sender, EventArgs e)
        {
            label1.Text = "عدد الطلاب";
            label2.Text = "اسم الطالب";
            label3.Text = "المعدل";
            addstudent.Text = "اضافة للقائمة";
            button2.Text = "ترتيب الاسماء";
            this.Text = "students";
            numstudent.KeyPress += keypress;
            namestudent.KeyPress += keypress;
            dragstudent.KeyPress += keypress;
            this.CenterToParent();
            //في كل مره يتم فيها تشغيل الفورم يكون هناك لون مختلف بالفورم
            Random r = new Random();
            this.BackColor = Color.FromArgb(r.Next(0, 255), r.Next(0, 255),
           r.Next(0, 255));

        }
        bool f = false;//متغير يستخدم في الحدث
        private void textBox1_MouseLeave(object sender, EventArgs e)
        {
           
        }
        private void keypress(object sender,KeyPressEventArgs e)
        {
            if(sender ==dragstudent||sender==numstudent)
            {
                if ((e.KeyChar < 48 || e.KeyChar > 57)&&(e.KeyChar != 8))
                e.Handled = true;
            }
            if (sender == namestudent)
            { //
                if (isArabic(e.KeyChar) || isEnglish(e.KeyChar)||e.KeyChar==8||e.KeyChar==32)
                {
                    if (f)//متغير من خلاله لا نسمح بان يدخل المسنخدم حروف مخلوطه من العربي والانجليزي
                    {//هذه اذا كان الحرف غير عربي او غسر فراغ او غير حذف يتم تفعيل عدم السماح
                        if ((!isArabic(e.KeyChar)) && e.KeyChar != 8 && e.KeyChar != 32)
                        {
                            e.Handled = true;
                        }
                    }
                    else//
                    {//هذه اذا كان الحرف غير انجليزي او غسر فراغ او غير حذف يتم تفعيل عدم السماح
                        if ((!isEnglish(e.KeyChar))&&e.KeyChar!=8&&e.KeyChar!=32)
                        {
                            e.Handled = true;
                        }
                    }
                    if (namestudent.Text.Length == 0)
                    {

                        if (isArabic(e.KeyChar))
                        {
                            f = true;
                            namestudent.RightToLeft = RightToLeft.Yes;
                        }

                        else if (isEnglish(e.KeyChar))
                        {
                            f = false;
                            namestudent.RightToLeft = RightToLeft.No;
                        }
                    }
                }
                else//يتم تفعيل الاداة اذا كان الحرف المدخل غير المطلوب
                e.Handled = true;
            }
        }
        private bool isArabic(char ch)//داله ترجع تروا اذا كان الحرف عربي
        {
            return ch >= '\u0600' && ch <= '\u06FF';
        }
        private bool isEnglish(char c)//داله ترجه تروا اذا كان الحرف انجليزي
        {
            return c >= 'a' && c <= 'z' || c >= 'A' && c <= 'Z';
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (namestudent.Text != "" && dragstudent.Text != "")
            {
                if (counter < size)
                {
                    listBox1.Items.Add(namestudent.Text + "\t" + dragstudent.Text);
                    a[counter++] = int.Parse(dragstudent.Text);
                    dragstudent.Clear();
                    namestudent.Clear();
                }
                else
                    MessageBox.Show("تجاوزت حجم المصفوفه");
            }
            else
                MessageBox.Show("ادخل البيانات بشكل صحيح");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (counter != 0)
            {
                for (int i = 0; i < counter; i++)
                    for (int j = 1 + i; j < counter; j++)
                    {
                        if (a[i] > a[j])
                        {
                            int t = a[i];
                            a[i] = a[j];
                            a[j] = t;
                            string s = listBox1.Items[i].ToString();
                            listBox1.Items[i] = listBox1.Items[j].ToString();
                            listBox1.Items[j] = s.ToString();
                        }
                    }
            }
            else
                MessageBox.Show("القائمه فارغه");
        }
        //حدث يتم فيه اخد القيم بعد الضغط علا رقم من الكيبورد
        private void numstudent_KeyUp(object sender, KeyEventArgs e)
        {
            if (numstudent.Text.Trim() != "")
            {
                size = Convert.ToInt32(numstudent.Text);
                a = new int[size];
                counter = 0;
            }
            else
                MessageBox.Show("ادخل العدد ");
            // listBox1.Items.Clear();
        }

        private void numstudent_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
