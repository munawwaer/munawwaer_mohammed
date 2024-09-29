namespace WindowsFormsApplication16
{
    partial class Form3
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
            this.numstudent = new System.Windows.Forms.TextBox();
            this.namestudent = new System.Windows.Forms.TextBox();
            this.dragstudent = new System.Windows.Forms.TextBox();
            this.addstudent = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // numstudent
            // 
            this.numstudent.Location = new System.Drawing.Point(278, 41);
            this.numstudent.Name = "numstudent";
            this.numstudent.Size = new System.Drawing.Size(100, 20);
            this.numstudent.TabIndex = 0;
            this.numstudent.TextChanged += new System.EventHandler(this.numstudent_TextChanged);
            this.numstudent.KeyUp += new System.Windows.Forms.KeyEventHandler(this.numstudent_KeyUp);
            this.numstudent.MouseLeave += new System.EventHandler(this.textBox1_MouseLeave);
            // 
            // namestudent
            // 
            this.namestudent.Location = new System.Drawing.Point(99, 41);
            this.namestudent.Name = "namestudent";
            this.namestudent.Size = new System.Drawing.Size(173, 20);
            this.namestudent.TabIndex = 1;
            // 
            // dragstudent
            // 
            this.dragstudent.Location = new System.Drawing.Point(2, 41);
            this.dragstudent.Name = "dragstudent";
            this.dragstudent.Size = new System.Drawing.Size(91, 20);
            this.dragstudent.TabIndex = 2;
            // 
            // addstudent
            // 
            this.addstudent.Location = new System.Drawing.Point(90, 67);
            this.addstudent.Name = "addstudent";
            this.addstudent.Size = new System.Drawing.Size(192, 23);
            this.addstudent.TabIndex = 3;
            this.addstudent.Text = "button1";
            this.addstudent.UseVisualStyleBackColor = true;
            this.addstudent.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(90, 102);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(192, 147);
            this.listBox1.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(90, 264);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(192, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(311, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(166, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "label3";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 338);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.addstudent);
            this.Controls.Add(this.dragstudent);
            this.Controls.Add(this.namestudent);
            this.Controls.Add(this.numstudent);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox numstudent;
        private System.Windows.Forms.TextBox namestudent;
        private System.Windows.Forms.TextBox dragstudent;
        private System.Windows.Forms.Button addstudent;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}