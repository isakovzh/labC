namespace labForuTy
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
            menuStrip1 = new MenuStrip();
            failToolStripMenuItem = new ToolStripMenuItem();
            vyhodToolStripMenuItem = new ToolStripMenuItem();
            rabotaSKartinkamiToolStripMenuItem = new ToolStripMenuItem();
            raToolStripMenuItem = new ToolStripMenuItem();
            razreshenineKartinkiToolStripMenuItem = new ToolStripMenuItem();
            normalToolStripMenuItem = new ToolStripMenuItem();
            strechImageToolStripMenuItem = new ToolStripMenuItem();
            autosizeToolStripMenuItem = new ToolStripMenuItem();
            centerImageToolStripMenuItem = new ToolStripMenuItem();
            zoomToolStripMenuItem = new ToolStripMenuItem();
            pictureBox1 = new PictureBox();
            openFileDialog1 = new OpenFileDialog();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { failToolStripMenuItem, rabotaSKartinkamiToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(907, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // failToolStripMenuItem
            // 
            failToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { vyhodToolStripMenuItem });
            failToolStripMenuItem.Name = "failToolStripMenuItem";
            failToolStripMenuItem.Size = new Size(48, 24);
            failToolStripMenuItem.Text = "fail ";
            failToolStripMenuItem.Click += failToolStripMenuItem_Click;
            // 
            // vyhodToolStripMenuItem
            // 
            vyhodToolStripMenuItem.Name = "vyhodToolStripMenuItem";
            vyhodToolStripMenuItem.Size = new Size(224, 26);
            vyhodToolStripMenuItem.Text = "vyhod";
            vyhodToolStripMenuItem.Click += vyhodToolStripMenuItem_Click;
            // 
            // rabotaSKartinkamiToolStripMenuItem
            // 
            rabotaSKartinkamiToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { raToolStripMenuItem, razreshenineKartinkiToolStripMenuItem });
            rabotaSKartinkamiToolStripMenuItem.Name = "rabotaSKartinkamiToolStripMenuItem";
            rabotaSKartinkamiToolStripMenuItem.Size = new Size(142, 24);
            rabotaSKartinkamiToolStripMenuItem.Text = "rabota s kartinkoi ";
            // 
            // raToolStripMenuItem
            // 
            raToolStripMenuItem.Name = "raToolStripMenuItem";
            raToolStripMenuItem.Size = new Size(227, 26);
            raToolStripMenuItem.Text = "zagruzit kartinku";
            // 
            // razreshenineKartinkiToolStripMenuItem
            // 
            razreshenineKartinkiToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { normalToolStripMenuItem, strechImageToolStripMenuItem, autosizeToolStripMenuItem, centerImageToolStripMenuItem, zoomToolStripMenuItem });
            razreshenineKartinkiToolStripMenuItem.Name = "razreshenineKartinkiToolStripMenuItem";
            razreshenineKartinkiToolStripMenuItem.Size = new Size(227, 26);
            razreshenineKartinkiToolStripMenuItem.Text = "razreshenine kartinki";
            // 
            // normalToolStripMenuItem
            // 
            normalToolStripMenuItem.Name = "normalToolStripMenuItem";
            normalToolStripMenuItem.Size = new Size(224, 26);
            normalToolStripMenuItem.Text = "normal";
            // 
            // strechImageToolStripMenuItem
            // 
            strechImageToolStripMenuItem.Name = "strechImageToolStripMenuItem";
            strechImageToolStripMenuItem.Size = new Size(224, 26);
            strechImageToolStripMenuItem.Text = "StrechImage";
            // 
            // autosizeToolStripMenuItem
            // 
            autosizeToolStripMenuItem.Name = "autosizeToolStripMenuItem";
            autosizeToolStripMenuItem.Size = new Size(224, 26);
            autosizeToolStripMenuItem.Text = "Autosize";
            // 
            // centerImageToolStripMenuItem
            // 
            centerImageToolStripMenuItem.Name = "centerImageToolStripMenuItem";
            centerImageToolStripMenuItem.Size = new Size(224, 26);
            centerImageToolStripMenuItem.Text = "CenterImage";
            // 
            // zoomToolStripMenuItem
            // 
            zoomToolStripMenuItem.Name = "zoomToolStripMenuItem";
            zoomToolStripMenuItem.Size = new Size(224, 26);
            zoomToolStripMenuItem.Text = "zoom";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._3__Леопард;
            pictureBox1.InitialImage = Properties.Resources.jk23__1_;
            pictureBox1.Location = new Point(23, 31);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(302, 314);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.FileOk += openFileDialog1_FileOk;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(907, 530);
            Controls.Add(pictureBox1);
            Controls.Add(menuStrip1);
            Name = "Form1";
            Text = "raboto s menu";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private PictureBox pictureBox1;
        private ToolStripMenuItem failToolStripMenuItem;
        private ToolStripMenuItem rabotaSKartinkamiToolStripMenuItem;
        private ToolStripMenuItem vyhodToolStripMenuItem;
        private ToolStripMenuItem raToolStripMenuItem;
        private ToolStripMenuItem razreshenineKartinkiToolStripMenuItem;
        private ToolStripMenuItem normalToolStripMenuItem;
        private ToolStripMenuItem strechImageToolStripMenuItem;
        private ToolStripMenuItem autosizeToolStripMenuItem;
        private ToolStripMenuItem centerImageToolStripMenuItem;
        private ToolStripMenuItem zoomToolStripMenuItem;
        private OpenFileDialog openFileDialog1;
    }
}