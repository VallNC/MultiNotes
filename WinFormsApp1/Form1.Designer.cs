namespace WinFormsApp1
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            menuStrip1 = new MenuStrip();
            openNewToolStripMenuItem = new ToolStripMenuItem();
            newToolStripMenuItem = new ToolStripMenuItem();
            openFileToolStripMenuItem = new ToolStripMenuItem();
            saveFileToolStripMenuItem = new ToolStripMenuItem();
            chooseSavePathToolStripMenuItem = new ToolStripMenuItem();
            richTextBox1 = new RichTextBox();
            label1 = new Label();
            label2 = new Label();
            imageList1 = new ImageList(components);
            pictureBox1 = new PictureBox();
            label3 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            textBox1 = new TextBox();
            pictureBox6 = new PictureBox();
            folderPathToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { openNewToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(677, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // openNewToolStripMenuItem
            // 
            openNewToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newToolStripMenuItem, openFileToolStripMenuItem, saveFileToolStripMenuItem, chooseSavePathToolStripMenuItem });
            openNewToolStripMenuItem.Name = "openNewToolStripMenuItem";
            openNewToolStripMenuItem.Size = new Size(61, 20);
            openNewToolStripMenuItem.Text = "Options";
            openNewToolStripMenuItem.Click += openNewToolStripMenuItem_Click;
            // 
            // newToolStripMenuItem
            // 
            newToolStripMenuItem.Name = "newToolStripMenuItem";
            newToolStripMenuItem.Size = new Size(180, 22);
            newToolStripMenuItem.Text = "New File";
            newToolStripMenuItem.Click += newToolStripMenuItem_Click;
            // 
            // openFileToolStripMenuItem
            // 
            openFileToolStripMenuItem.Name = "openFileToolStripMenuItem";
            openFileToolStripMenuItem.Size = new Size(180, 22);
            openFileToolStripMenuItem.Text = "Open File";
            openFileToolStripMenuItem.Click += openFileToolStripMenuItem_Click;
            // 
            // saveFileToolStripMenuItem
            // 
            saveFileToolStripMenuItem.Name = "saveFileToolStripMenuItem";
            saveFileToolStripMenuItem.Size = new Size(180, 22);
            saveFileToolStripMenuItem.Text = "Save File";
            saveFileToolStripMenuItem.Click += saveFileToolStripMenuItem_Click;
            // 
            // chooseSavePathToolStripMenuItem
            // 
            chooseSavePathToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { folderPathToolStripMenuItem });
            chooseSavePathToolStripMenuItem.Name = "chooseSavePathToolStripMenuItem";
            chooseSavePathToolStripMenuItem.Size = new Size(180, 22);
            chooseSavePathToolStripMenuItem.Text = "Choose Save Path";
            chooseSavePathToolStripMenuItem.Click += chooseSavePathToolStripMenuItem_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(19, 65);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(543, 179);
            richTextBox1.TabIndex = 1;
            richTextBox1.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 47);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 2;
            label1.Text = "Text Notes";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 259);
            label2.Name = "label2";
            label2.Size = new Size(94, 15);
            label2.TabIndex = 3;
            label2.Text = "Images(Up to 5):";
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Location = new Point(19, 277);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 96);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(153, 19);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 6;
            label3.Text = "File Name";
            label3.Click += label3_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Enabled = false;
            pictureBox2.Location = new Point(125, 277);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(100, 96);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Enabled = false;
            pictureBox3.Location = new Point(231, 277);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(100, 96);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 8;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Enabled = false;
            pictureBox4.Location = new Point(337, 277);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(100, 96);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 9;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.Enabled = false;
            pictureBox5.Location = new Point(443, 277);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(100, 96);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 10;
            pictureBox5.TabStop = false;
            pictureBox5.Click += pictureBox5_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(219, 16);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 11;
            // 
            // pictureBox6
            // 
            pictureBox6.Enabled = false;
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(549, 277);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(100, 96);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 12;
            pictureBox6.TabStop = false;
            pictureBox6.Visible = false;
            // 
            // folderPathToolStripMenuItem
            // 
            folderPathToolStripMenuItem.Name = "folderPathToolStripMenuItem";
            folderPathToolStripMenuItem.Size = new Size(180, 22);
            folderPathToolStripMenuItem.Text = "Folder Path";
            folderPathToolStripMenuItem.Click += folderPathToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(677, 450);
            Controls.Add(pictureBox6);
            Controls.Add(textBox1);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(richTextBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Compact Notes";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem openNewToolStripMenuItem;
        private ToolStripMenuItem newToolStripMenuItem;
        private ToolStripMenuItem openFileToolStripMenuItem;
        private ToolStripMenuItem saveFileToolStripMenuItem;
        private RichTextBox richTextBox1;
        private Label label1;
        private Label label2;
        private ImageList imageList1;
        private PictureBox pictureBox1;
        private Label label3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private TextBox textBox1;
        private PictureBox pictureBox6;
        private ToolStripMenuItem chooseSavePathToolStripMenuItem;
        private ToolStripMenuItem folderPathToolStripMenuItem;
    }
}
