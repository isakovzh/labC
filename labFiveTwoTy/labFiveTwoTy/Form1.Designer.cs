namespace labFiveTwoTy
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
            richTextBox1 = new RichTextBox();
            richTextBox2 = new RichTextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(57, 36);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(331, 120);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // richTextBox2
            // 
            richTextBox2.Location = new Point(446, 36);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(125, 120);
            richTextBox2.TabIndex = 1;
            richTextBox2.Text = "";
            richTextBox2.LinkClicked += richTextBox2_LinkClicked;
            // 
            // button1
            // 
            button1.Location = new Point(57, 175);
            button1.Name = "button1";
            button1.Size = new Size(331, 29);
            button1.TabIndex = 2;
            button1.Text = "Add value";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(57, 226);
            button2.Name = "button2";
            button2.Size = new Size(331, 29);
            button2.TabIndex = 3;
            button2.Text = "Text output";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(394, 175);
            button3.Name = "button3";
            button3.Size = new Size(177, 29);
            button3.TabIndex = 4;
            button3.Text = "Text outputAdd text with link";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(richTextBox2);
            Controls.Add(richTextBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox richTextBox1;
        private RichTextBox richTextBox2;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}