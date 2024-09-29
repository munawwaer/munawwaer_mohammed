namespace WindowsFormsApplication16
{
    partial class Form8
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.radioEven = new System.Windows.Forms.RadioButton();
            this.radiodd = new System.Windows.Forms.RadioButton();
            this.radioprimary = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(138, 57);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "<";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(138, 207);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "<<";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(224, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(120, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "اضافة";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 57);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 173);
            this.listBox1.TabIndex = 3;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(224, 57);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(120, 173);
            this.listBox2.TabIndex = 4;
            // 
            // radioEven
            // 
            this.radioEven.AutoSize = true;
            this.radioEven.Location = new System.Drawing.Point(160, 98);
            this.radioEven.Name = "radioEven";
            this.radioEven.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radioEven.Size = new System.Drawing.Size(53, 17);
            this.radioEven.TabIndex = 5;
            this.radioEven.TabStop = true;
            this.radioEven.Text = "زوجي";
            this.radioEven.UseVisualStyleBackColor = true;
            // 
            // radiodd
            // 
            this.radiodd.AutoSize = true;
            this.radiodd.Location = new System.Drawing.Point(162, 135);
            this.radiodd.Name = "radiodd";
            this.radiodd.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radiodd.Size = new System.Drawing.Size(51, 17);
            this.radiodd.TabIndex = 6;
            this.radiodd.TabStop = true;
            this.radiodd.Text = "فردي";
            this.radiodd.UseVisualStyleBackColor = true;
            // 
            // radioprimary
            // 
            this.radioprimary.AutoSize = true;
            this.radioprimary.Location = new System.Drawing.Point(166, 174);
            this.radioprimary.Name = "radioprimary";
            this.radioprimary.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radioprimary.Size = new System.Drawing.Size(47, 17);
            this.radioprimary.TabIndex = 7;
            this.radioprimary.TabStop = true;
            this.radioprimary.Text = "اولي";
            this.radioprimary.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 14);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(119, 20);
            this.textBox1.TabIndex = 8;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 236);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(120, 23);
            this.button4.TabIndex = 9;
            this.button4.Text = "أغـــلا قـــــــــ";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 265);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.radioprimary);
            this.Controls.Add(this.radiodd);
            this.Controls.Add(this.radioEven);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form8";
            this.Text = "projec t";
            this.Load += new System.EventHandler(this.Form8_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.RadioButton radioEven;
        private System.Windows.Forms.RadioButton radiodd;
        private System.Windows.Forms.RadioButton radioprimary;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button4;
    }
}