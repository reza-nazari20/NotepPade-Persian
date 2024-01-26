namespace NotePade_Persian
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pall = new Panel();
            pfil = new Panel();
            pbut = new Panel();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            ptop = new Panel();
            toolStrip1 = new ToolStrip();
            toolStripButton1 = new ToolStripButton();
            toolStripButton2 = new ToolStripButton();
            menuStrip1 = new MenuStrip();
            فایلToolStripMenuItem = new ToolStripMenuItem();
            pall.SuspendLayout();
            pbut.SuspendLayout();
            statusStrip1.SuspendLayout();
            ptop.SuspendLayout();
            toolStrip1.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // pall
            // 
            pall.Controls.Add(pfil);
            pall.Controls.Add(pbut);
            pall.Controls.Add(ptop);
            pall.Dock = DockStyle.Fill;
            pall.Location = new Point(0, 0);
            pall.Name = "pall";
            pall.Size = new Size(646, 548);
            pall.TabIndex = 0;
            // 
            // pfil
            // 
            pfil.Dock = DockStyle.Fill;
            pfil.Location = new Point(0, 52);
            pfil.Name = "pfil";
            pfil.Size = new Size(646, 468);
            pfil.TabIndex = 2;
            // 
            // pbut
            // 
            pbut.Controls.Add(statusStrip1);
            pbut.Dock = DockStyle.Bottom;
            pbut.Location = new Point(0, 520);
            pbut.Name = "pbut";
            pbut.Size = new Size(646, 28);
            pbut.TabIndex = 1;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1 });
            statusStrip1.Location = new Point(0, 2);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(646, 26);
            statusStrip1.TabIndex = 0;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(151, 20);
            toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // ptop
            // 
            ptop.Controls.Add(toolStrip1);
            ptop.Controls.Add(menuStrip1);
            ptop.Dock = DockStyle.Top;
            ptop.Location = new Point(0, 0);
            ptop.Name = "ptop";
            ptop.Size = new Size(646, 52);
            ptop.TabIndex = 0;
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButton1, toolStripButton2 });
            toolStrip1.Location = new Point(0, 28);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(646, 27);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton1.Image = (Image)resources.GetObject("toolStripButton1.Image");
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(29, 24);
            toolStripButton1.Text = "toolStripButton1";
            // 
            // toolStripButton2
            // 
            toolStripButton2.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton2.Image = (Image)resources.GetObject("toolStripButton2.Image");
            toolStripButton2.ImageTransparentColor = Color.Magenta;
            toolStripButton2.Name = "toolStripButton2";
            toolStripButton2.Size = new Size(29, 24);
            toolStripButton2.Text = "toolStripButton2";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { فایلToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(646, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // فایلToolStripMenuItem
            // 
            فایلToolStripMenuItem.Name = "فایلToolStripMenuItem";
            فایلToolStripMenuItem.Size = new Size(50, 24);
            فایلToolStripMenuItem.Text = "فایل";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(646, 548);
            Controls.Add(pall);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            Text = "نوت پد فارسی";
            pall.ResumeLayout(false);
            pbut.ResumeLayout(false);
            pbut.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ptop.ResumeLayout(false);
            ptop.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pall;
        private Panel pfil;
        private Panel pbut;
        private Panel ptop;
        private MenuStrip menuStrip1;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButton1;
        private ToolStripButton toolStripButton2;
        private ToolStripMenuItem فایلToolStripMenuItem;
    }
}
