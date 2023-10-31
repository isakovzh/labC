namespace labSixTy
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
            listBox1 = new ListBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            button11 = new Button();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Items.AddRange(new object[] { "dsa" });
            listBox1.Location = new Point(26, 21);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(232, 384);
            listBox1.TabIndex = 0;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.Location = new Point(361, 21);
            button1.Name = "button1";
            button1.Size = new Size(353, 29);
            button1.TabIndex = 1;
            button1.Text = "Button programmatically adding lines";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(361, 56);
            button2.Name = "button2";
            button2.Size = new Size(353, 29);
            button2.TabIndex = 2;
            button2.Text = "Add from the string array";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(361, 91);
            button3.Name = "button3";
            button3.Size = new Size(353, 29);
            button3.TabIndex = 3;
            button3.Text = "\tAdd a string";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(361, 126);
            button4.Name = "button4";
            button4.Size = new Size(353, 29);
            button4.TabIndex = 4;
            button4.Text = "AddRange function";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(361, 161);
            button5.Name = "button5";
            button5.Size = new Size(353, 29);
            button5.TabIndex = 5;
            button5.Text = "Selecting lines programmatically";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(361, 196);
            button6.Name = "button6";
            button6.Size = new Size(353, 29);
            button6.TabIndex = 6;
            button6.Text = "Sorting";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Location = new Point(361, 231);
            button7.Name = "button7";
            button7.Size = new Size(353, 29);
            button7.TabIndex = 7;
            button7.Text = "ordering. Property UseTabStop";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Location = new Point(361, 266);
            button8.Name = "button8";
            button8.Size = new Size(353, 29);
            button8.TabIndex = 8;
            button8.Text = "Accessing the line";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.Location = new Point(361, 301);
            button9.Name = "button9";
            button9.Size = new Size(353, 29);
            button9.TabIndex = 9;
            button9.Text = "Iterate through all lines";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // button10
            // 
            button10.Location = new Point(361, 341);
            button10.Name = "button10";
            button10.Size = new Size(353, 29);
            button10.TabIndex = 10;
            button10.Text = "Removing 1";
            button10.UseVisualStyleBackColor = true;
            button10.Click += button10_Click;
            // 
            // button11
            // 
            button11.Location = new Point(361, 376);
            button11.Name = "button11";
            button11.Size = new Size(353, 29);
            button11.TabIndex = 11;
            button11.Text = "Deleting 2";
            button11.UseVisualStyleBackColor = true;
            button11.Click += button11_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 647);
            Controls.Add(button11);
            Controls.Add(button10);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(listBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBox1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private Button button11;
    }
}