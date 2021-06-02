namespace skolniProjektPVA
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
            this.textBox112 = new System.Windows.Forms.TextBox();
            this.textBox212 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox112
            // 
            this.textBox112.Location = new System.Drawing.Point(719, 48);
            this.textBox112.Name = "textBox112";
            this.textBox112.ReadOnly = true;
            this.textBox112.Size = new System.Drawing.Size(69, 20);
            this.textBox112.TabIndex = 0;
            // 
            // textBox212
            // 
            this.textBox212.Location = new System.Drawing.Point(719, 12);
            this.textBox212.Name = "textBox212";
            this.textBox212.ReadOnly = true;
            this.textBox212.Size = new System.Drawing.Size(69, 20);
            this.textBox212.TabIndex = 1;
            this.textBox212.TextChanged += new System.EventHandler(this.TextBox212_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(294, 414);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 47);
            this.button1.TabIndex = 2;
            this.button1.Text = "Základní";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(410, 414);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 47);
            this.button2.TabIndex = 3;
            this.button2.Text = "Pokročilejší";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(668, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "správně";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(674, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "špatně";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(294, 478);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(212, 47);
            this.button3.TabIndex = 6;
            this.button3.Text = "statistiky";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(293, 537);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(212, 20);
            this.textBox1.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::skolniProjektPVA.Properties.Resources.hiraKatanaLogo;
            this.pictureBox1.Location = new System.Drawing.Point(152, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(496, 396);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 570);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox212);
            this.Controls.Add(this.textBox112);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox112;
        private System.Windows.Forms.TextBox textBox212;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}