namespace labThreeTy
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            fontDialog1 = new FontDialog();
            button1 = new Button();
            label5 = new Label();
            textBox4 = new TextBox();
            groupBox1 = new GroupBox();
            radioButton3 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            button2 = new Button();
            textBox5 = new TextBox();
            label6 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(77, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(258, 12);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(459, 12);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(220, 15);
            label1.Name = "label1";
            label1.Size = new Size(19, 20);
            label1.TabIndex = 3;
            label1.Text = "+";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(429, 15);
            label2.Name = "label2";
            label2.Size = new Size(15, 20);
            label2.TabIndex = 4;
            label2.Text = "/";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(57, 15);
            label3.Name = "label3";
            label3.Size = new Size(14, 20);
            label3.TabIndex = 20;
            label3.Text = "(";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(398, 15);
            label4.Name = "label4";
            label4.Size = new Size(14, 20);
            label4.TabIndex = 6;
            label4.Text = ")";
            // 
            // button1
            // 
            button1.Location = new Point(211, 74);
            button1.Name = "button1";
            button1.Size = new Size(259, 29);
            button1.TabIndex = 21;
            button1.Text = "poluchit rezultat";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(220, 130);
            label5.Name = "label5";
            label5.Size = new Size(36, 20);
            label5.TabIndex = 22;
            label5.Text = "itog";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(287, 127);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(125, 27);
            textBox4.TabIndex = 23;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton3);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.ForeColor = SystemColors.ActiveCaption;
            groupBox1.Location = new Point(102, 171);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(482, 141);
            groupBox1.TabIndex = 28;
            groupBox1.TabStop = false;
            groupBox1.Text = "poluchenie procenta";
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.ForeColor = SystemColors.ActiveCaptionText;
            radioButton3.Location = new Point(185, 98);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(46, 24);
            radioButton3.TabIndex = 3;
            radioButton3.TabStop = true;
            radioButton3.Text = "50";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.ForeColor = SystemColors.ActiveCaptionText;
            radioButton2.Location = new Point(185, 68);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(46, 24);
            radioButton2.TabIndex = 2;
            radioButton2.TabStop = true;
            radioButton2.Text = "20";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.ForeColor = SystemColors.ActiveCaptionText;
            radioButton1.Location = new Point(185, 38);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(46, 24);
            radioButton1.TabIndex = 1;
            radioButton1.TabStop = true;
            radioButton1.Text = "10";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // button2
            // 
            button2.Location = new Point(220, 348);
            button2.Name = "button2";
            button2.Size = new Size(259, 29);
            button2.TabIndex = 29;
            button2.Text = "poluchit rezultat";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(287, 411);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(125, 27);
            textBox5.TabIndex = 30;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(220, 414);
            label6.Name = "label6";
            label6.Size = new Size(36, 20);
            label6.TabIndex = 31;
            label6.Text = "itog";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label6);
            Controls.Add(textBox5);
            Controls.Add(button2);
            Controls.Add(groupBox1);
            Controls.Add(textBox4);
            Controls.Add(label5);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private FontDialog fontDialog1;
        private Button button1;
        private Label label5;
        private TextBox textBox4;
        private GroupBox groupBox1;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Button button2;
        private TextBox textBox5;
        private Label label6;
    }
}