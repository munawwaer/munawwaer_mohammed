namespace WindowsFormsApplication16
{
    partial class Form1
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
            this.txt_enter = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_add = new System.Windows.Forms.Button();
            this.txt_show = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_enter
            // 
            this.txt_enter.Location = new System.Drawing.Point(120, 15);
            this.txt_enter.Name = "txt_enter";
            this.txt_enter.Size = new System.Drawing.Size(100, 20);
            this.txt_enter.TabIndex = 0;
            this.txt_enter.TextChanged += new System.EventHandler(this.txt_enter_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(264, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ادخل العدد";
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(134, 76);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 2;
            this.btn_add.Text = "اضافة";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            this.btn_add.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btn_add_MouseClick);
            this.btn_add.MouseEnter += new System.EventHandler(this.btn_add_MouseEnter);
            this.btn_add.MouseLeave += new System.EventHandler(this.btn_add_MouseLeave);
            this.btn_add.MouseHover += new System.EventHandler(this.btn_add_MouseHover);
            // 
            // txt_show
            // 
            this.txt_show.Location = new System.Drawing.Point(48, 128);
            this.txt_show.Multiline = true;
            this.txt_show.Name = "txt_show";
            this.txt_show.Size = new System.Drawing.Size(254, 131);
            this.txt_show.TabIndex = 3;
            this.txt_show.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1, 306);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 330);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txt_show);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_enter);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            this.MouseHover += new System.EventHandler(this.Form1_MouseHover);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_enter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.TextBox txt_show;
        private System.Windows.Forms.Button button2;
    }
}

