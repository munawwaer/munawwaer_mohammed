namespace WindowsFormsApplication16
{
    partial class Form2
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.butAdd = new System.Windows.Forms.Button();
            this.butshow = new System.Windows.Forms.Button();
            this.butremove = new System.Windows.Forms.Button();
            this.busumation = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(184, 36);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.MouseLeave += new System.EventHandler(this.textBox1_MouseLeave);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(53, 36);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 1;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(53, 335);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(117, 20);
            this.textBox4.TabIndex = 3;
            // 
            // butAdd
            // 
            this.butAdd.Location = new System.Drawing.Point(53, 62);
            this.butAdd.Name = "butAdd";
            this.butAdd.Size = new System.Drawing.Size(231, 23);
            this.butAdd.TabIndex = 4;
            this.butAdd.Text = "button1";
            this.butAdd.UseVisualStyleBackColor = true;
            this.butAdd.Click += new System.EventHandler(this.button1_Click);
            // 
            // butshow
            // 
            this.butshow.Location = new System.Drawing.Point(203, 96);
            this.butshow.Name = "butshow";
            this.butshow.Size = new System.Drawing.Size(81, 23);
            this.butshow.TabIndex = 5;
            this.butshow.Text = "button2";
            this.butshow.UseVisualStyleBackColor = true;
            this.butshow.Click += new System.EventHandler(this.button2_Click);
            // 
            // butremove
            // 
            this.butremove.Location = new System.Drawing.Point(53, 96);
            this.butremove.Name = "butremove";
            this.butremove.Size = new System.Drawing.Size(88, 23);
            this.butremove.TabIndex = 6;
            this.butremove.Text = "button3";
            this.butremove.UseVisualStyleBackColor = true;
            this.butremove.Click += new System.EventHandler(this.button3_Click);
            // 
            // busumation
            // 
            this.busumation.Location = new System.Drawing.Point(205, 335);
            this.busumation.Name = "busumation";
            this.busumation.Size = new System.Drawing.Size(79, 23);
            this.busumation.TabIndex = 7;
            this.busumation.Text = "button4";
            this.busumation.UseVisualStyleBackColor = true;
            this.busumation.Click += new System.EventHandler(this.busumation_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(227, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "label2";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(53, 139);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(231, 173);
            this.listBox1.TabIndex = 10;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 391);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.busumation);
            this.Controls.Add(this.butremove);
            this.Controls.Add(this.butshow);
            this.Controls.Add(this.butAdd);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button butAdd;
        private System.Windows.Forms.Button butshow;
        private System.Windows.Forms.Button butremove;
        private System.Windows.Forms.Button busumation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBox1;
    }
}