﻿namespace WindowsFormsApplication16
{
    partial class Form5
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button7 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.phone_stud = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.adress_stud = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.code_stud = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.name_stud = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.number_stud = new System.Windows.Forms.TextBox();
            this.list_name = new System.Windows.Forms.ListBox();
            this.list_code = new System.Windows.Forms.ListBox();
            this.list_Adress = new System.Windows.Forms.ListBox();
            this.list_phone = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Controls.Add(this.button7);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.phone_stud);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.adress_stud);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.code_stud);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.name_stud);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBox1.Location = new System.Drawing.Point(448, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(260, 208);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "بيانات الطلاب";
            // 
            // button7
            // 
            this.button7.ForeColor = System.Drawing.Color.Red;
            this.button7.Location = new System.Drawing.Point(7, 174);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 8;
            this.button7.Text = "Reset it";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(209, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "التلفون";
            // 
            // phone_stud
            // 
            this.phone_stud.Location = new System.Drawing.Point(31, 146);
            this.phone_stud.Name = "phone_stud";
            this.phone_stud.Size = new System.Drawing.Size(158, 22);
            this.phone_stud.TabIndex = 6;
            this.phone_stud.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(209, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "العنوان";
            // 
            // adress_stud
            // 
            this.adress_stud.Location = new System.Drawing.Point(31, 110);
            this.adress_stud.Name = "adress_stud";
            this.adress_stud.Size = new System.Drawing.Size(158, 22);
            this.adress_stud.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(209, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "الرقم:";
            // 
            // code_stud
            // 
            this.code_stud.Location = new System.Drawing.Point(29, 70);
            this.code_stud.Name = "code_stud";
            this.code_stud.Size = new System.Drawing.Size(160, 22);
            this.code_stud.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(209, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "الاسم:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // name_stud
            // 
            this.name_stud.Location = new System.Drawing.Point(31, 34);
            this.name_stud.Name = "name_stud";
            this.name_stud.Size = new System.Drawing.Size(158, 22);
            this.name_stud.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(351, 61);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "اضافة";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(351, 90);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "تعديل";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(351, 121);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "حذف";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(351, 152);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 4;
            this.button4.Text = "مسح القوائم";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(119, 36);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 5;
            this.button5.Text = "استعلام";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.number_stud);
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.groupBox2.Location = new System.Drawing.Point(12, 51);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(229, 93);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "عدد الطلاب";
            // 
            // number_stud
            // 
            this.number_stud.Location = new System.Drawing.Point(6, 39);
            this.number_stud.Name = "number_stud";
            this.number_stud.Size = new System.Drawing.Size(97, 22);
            this.number_stud.TabIndex = 6;
            // 
            // list_name
            // 
            this.list_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.list_name.FormattingEnabled = true;
            this.list_name.ItemHeight = 16;
            this.list_name.Location = new System.Drawing.Point(550, 297);
            this.list_name.Name = "list_name";
            this.list_name.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.list_name.Size = new System.Drawing.Size(158, 164);
            this.list_name.TabIndex = 8;
            this.list_name.SelectedIndexChanged += new System.EventHandler(this.list_name_SelectedIndexChanged);
            // 
            // list_code
            // 
            this.list_code.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.list_code.FormattingEnabled = true;
            this.list_code.ItemHeight = 16;
            this.list_code.Location = new System.Drawing.Point(372, 297);
            this.list_code.Name = "list_code";
            this.list_code.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.list_code.Size = new System.Drawing.Size(158, 164);
            this.list_code.TabIndex = 9;
            this.list_code.SelectedIndexChanged += new System.EventHandler(this.list_code_SelectedIndexChanged);
            // 
            // list_Adress
            // 
            this.list_Adress.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.list_Adress.FormattingEnabled = true;
            this.list_Adress.Location = new System.Drawing.Point(189, 297);
            this.list_Adress.Name = "list_Adress";
            this.list_Adress.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.list_Adress.Size = new System.Drawing.Size(158, 173);
            this.list_Adress.TabIndex = 10;
            // 
            // list_phone
            // 
            this.list_phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.list_phone.FormattingEnabled = true;
            this.list_phone.ItemHeight = 16;
            this.list_phone.Location = new System.Drawing.Point(12, 297);
            this.list_phone.Name = "list_phone";
            this.list_phone.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.list_phone.Size = new System.Drawing.Size(158, 164);
            this.list_phone.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label5.Location = new System.Drawing.Point(575, 269);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "               الاسم       ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label6.Location = new System.Drawing.Point(408, 269);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "            الرقم";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label7.Location = new System.Drawing.Point(244, 269);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 16);
            this.label7.TabIndex = 14;
            this.label7.Text = "العنوان";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label8.Location = new System.Drawing.Point(62, 269);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 16);
            this.label8.TabIndex = 15;
            this.label8.Text = "التلفون";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(351, 184);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 16;
            this.button6.Text = "حفظ التعديل";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 495);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.list_phone);
            this.Controls.Add(this.list_Adress);
            this.Controls.Add(this.list_code);
            this.Controls.Add(this.list_name);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox phone_stud;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox adress_stud;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox code_stud;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox name_stud;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox number_stud;
        private System.Windows.Forms.ListBox list_name;
        private System.Windows.Forms.ListBox list_code;
        private System.Windows.Forms.ListBox list_Adress;
        private System.Windows.Forms.ListBox list_phone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
    }
}