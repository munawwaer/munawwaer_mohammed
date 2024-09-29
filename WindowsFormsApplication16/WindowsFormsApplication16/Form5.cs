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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        int index = 0;
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (name_stud.Text != "" && code_stud.Text != "" && adress_stud.Text != "" && phone_stud.Text != "")
            {
                if (!(list_code.Items.Contains(code_stud.Text)))
                {
                    list_name.Items.Add(name_stud.Text);
                    list_code.Items.Add(code_stud.Text);
                    list_Adress.Items.Add(adress_stud.Text);
                    list_phone.Items.Add(phone_stud.Text);
                    name_stud.Text = code_stud.Text = adress_stud.Text = phone_stud.Text = null;
                    name_stud.Focus();
                }
                else
                {
                    MessageBox.Show("لا يمكن تكرار كود الطالب");
                }
            }
                else
                MessageBox.Show("ادخل البيانات بالشكل الصحيح");

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
          
                if (list_code.SelectedIndex != -1)
                {
                    index = list_code.SelectedIndex;
                   
                    name_stud.Text = list_name.Items[index].ToString();
                    code_stud.Text = list_code.Items[index].ToString();
                    adress_stud.Text = list_Adress.Items[index].ToString();
                    phone_stud.Text = list_phone.Items[index].ToString();

                }
                else
                    MessageBox.Show("حدد رقم الطالب المراد التعديل عليه");
         

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (list_code.SelectedIndex != -1)
            {
                list_name.Items.RemoveAt(list_name.SelectedIndex);
                list_code.Items.RemoveAt(list_code.SelectedIndex);
                list_Adress.Items.RemoveAt(list_Adress.SelectedIndex);
                list_phone.Items.RemoveAt(list_phone.SelectedIndex);
            }
            else
                MessageBox.Show("حدد الطالب المراد حذفه من القائمه");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            list_name.Items.Clear(); 
            list_code.Items.Clear(); 
            list_Adress.Items.Clear(); 
            list_phone.Items.Clear(); 
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (name_stud.Text != null && code_stud.Text != null && adress_stud.Text != null && phone_stud.Text != null)
            {
                list_code.Items[index] = 09;
                if (!(list_code.Items.Contains(code_stud.Text)))
                {
                    list_name.Items[index] = name_stud.Text;
                    list_code.Items[index] = code_stud.Text;
                    list_Adress.Items[index] = adress_stud.Text;
                    list_phone.Items[index] = phone_stud.Text;
                    name_stud.Text = code_stud.Text = adress_stud.Text = phone_stud.Text = null;
                    name_stud.Focus();
                }
                else
                {
                    MessageBox.Show("لا يمكن تكرار كود الطالب");
                }
            }
            else
            {
                MessageBox.Show("البيانات غير صحيحه");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            number_stud.Text = list_code.Items.Count.ToString();
        }
        private void keyprass(object sender,KeyPressEventArgs e)
        {
            if (sender == code_stud || sender == phone_stud)
            {
                if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8)
                    e.Handled = true;
            }
            if (sender == name_stud || sender == adress_stud)
            {
                if ((e.KeyChar < 65 || e.KeyChar > 122) && e.KeyChar != 8)
                    e.Handled = true;
            }
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            name_stud.KeyPress += keyprass;
            adress_stud.KeyPress += keyprass;
            code_stud.KeyPress += keyprass;
            phone_stud.KeyPress += keyprass;
            this.Text = "Database_students";
            this.CenterToParent();
            MessageBox.Show("عندما تريد حذف طالب حدد على كود الطالب من القائمه \t\nللتعديل عل بيانات طالب موجود سابقا اولا حدد على كود الطالب ثم اضغط علا زر تعديل بعد الانتهاء من التعديل اضغط علا زر حفظ التعديل   ","ملاحظات",MessageBoxButtons.OKCancel);

            list_name.SelectedIndexChanged += listBox_selectedindexchaned;
            list_phone.SelectedIndexChanged += listBox_selectedindexchaned;
            list_code.SelectedIndexChanged += listBox_selectedindexchaned;
            list_Adress.SelectedIndexChanged += listBox_selectedindexchaned;
            
            }
        private void button7_Click(object sender, EventArgs e)
        {
            name_stud.Text = code_stud.Text = adress_stud.Text = phone_stud.Text = null;
        }

        private void list_name_SelectedIndexChanged(object sender, EventArgs e)
        {
         
        }
        //تضعيف الاحداث عند التشير على قائمه يتم اتاشير على القوائم الموازيه له بالمثل
        private void listBox_selectedindexchaned(object sender, EventArgs e)
        {
            ListBox selectedlistbox = ((ListBox)sender) ;//sender as listBox
            int selectedindex = selectedlistbox.SelectedIndex;
            if (selectedindex != -1)
            {
                if (selectedlistbox == list_name)
                {
                    list_code.SelectedIndex = selectedindex;
                    list_Adress.SelectedIndex = selectedindex;
                    list_phone.SelectedIndex = selectedindex;
                }
                else if (selectedlistbox == list_code)
                {
                    list_Adress.SelectedIndex = selectedindex;
                    list_phone.SelectedIndex = selectedindex;
                    list_name.SelectedIndex = selectedindex;
                }
                else if (selectedlistbox == list_phone)
                {

                    list_code.SelectedIndex = selectedindex;
                    list_Adress.SelectedIndex = selectedindex;
                    list_name.SelectedIndex = selectedindex;
                }
                else if (selectedlistbox == list_Adress)
                {
                    list_phone.SelectedIndex = selectedindex;
                    list_name.SelectedIndex = selectedindex;
                    list_code.SelectedIndex = selectedindex;
                }
            }
        }
        private void list_code_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
