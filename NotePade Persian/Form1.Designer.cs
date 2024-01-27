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
            richText = new RichTextBox();
            pbut = new Panel();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            lblchar = new ToolStripStatusLabel();
            toolStripStatusLabel2 = new ToolStripStatusLabel();
            lblword = new ToolStripStatusLabel();
            ptop = new Panel();
            toolStrip1 = new ToolStrip();
            tlsCopy = new ToolStripButton();
            tlsPaste = new ToolStripButton();
            tlsCut = new ToolStripButton();
            toolStripSeparator6 = new ToolStripSeparator();
            tlsUndo = new ToolStripButton();
            toolStripSeparator7 = new ToolStripSeparator();
            tlsSub = new ToolStripButton();
            tlsSearch = new ToolStripButton();
            toolStripComboBox1 = new ToolStripComboBox();
            toolStripSeparator8 = new ToolStripSeparator();
            tlsPrint = new ToolStripButton();
            menuStrip1 = new MenuStrip();
            فایلToolStripMenuItem = new ToolStripMenuItem();
            tsmNewNote = new ToolStripMenuItem();
            tlmOpen = new ToolStripMenuItem();
            tlsOpenNew = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            tlsSave = new ToolStripMenuItem();
            tlsSaveas = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            tlsP = new ToolStripMenuItem();
            toolStripSeparator3 = new ToolStripSeparator();
            tlsExit = new ToolStripMenuItem();
            ویرایToolStripMenuItem = new ToolStripMenuItem();
            tlsU = new ToolStripMenuItem();
            mnuPaste = new ToolStripMenuItem();
            mnuCopy = new ToolStripMenuItem();
            mnuCut = new ToolStripMenuItem();
            mnuDelete = new ToolStripMenuItem();
            toolStripSeparator4 = new ToolStripSeparator();
            mnuSearch = new ToolStripMenuItem();
            چایگزینیToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator5 = new ToolStripSeparator();
            انتخابهمهمتنToolStripMenuItem = new ToolStripMenuItem();
            درجتاریخToolStripMenuItem = new ToolStripMenuItem();
            قالببندیToolStripMenuItem = new ToolStripMenuItem();
            فونتToolStripMenuItem = new ToolStripMenuItem();
            نماToolStripMenuItem = new ToolStripMenuItem();
            tlsStatusBar = new ToolStripMenuItem();
            tlsToolBox = new ToolStripMenuItem();
            راهنماToolStripMenuItem = new ToolStripMenuItem();
            mnuhelp = new ToolStripMenuItem();
            mnuMe = new ToolStripMenuItem();
            saveFileDialog1 = new SaveFileDialog();
            openFileDialog1 = new OpenFileDialog();
            fontDialog1 = new FontDialog();
            printDialog1 = new PrintDialog();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            pall.SuspendLayout();
            pfil.SuspendLayout();
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
            pall.Margin = new Padding(5);
            pall.Name = "pall";
            pall.Size = new Size(751, 579);
            pall.TabIndex = 0;
            // 
            // pfil
            // 
            pfil.Controls.Add(richText);
            pfil.Dock = DockStyle.Fill;
            pfil.Location = new Point(0, 63);
            pfil.Margin = new Padding(5);
            pfil.Name = "pfil";
            pfil.Size = new Size(751, 485);
            pfil.TabIndex = 2;
            // 
            // richText
            // 
            richText.Dock = DockStyle.Fill;
            richText.Font = new Font("B Zar", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 178);
            richText.Location = new Point(0, 0);
            richText.Margin = new Padding(5);
            richText.Name = "richText";
            richText.Size = new Size(751, 485);
            richText.TabIndex = 0;
            richText.Text = "";
            richText.TextChanged += richText_TextChanged;
            // 
            // pbut
            // 
            pbut.Controls.Add(statusStrip1);
            pbut.Dock = DockStyle.Bottom;
            pbut.Location = new Point(0, 548);
            pbut.Margin = new Padding(5);
            pbut.Name = "pbut";
            pbut.Size = new Size(751, 31);
            pbut.TabIndex = 1;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1, lblchar, toolStripStatusLabel2, lblword });
            statusStrip1.Location = new Point(0, 5);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Padding = new Padding(26, 0, 1, 0);
            statusStrip1.Size = new Size(751, 26);
            statusStrip1.TabIndex = 0;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(94, 20);
            toolStripStatusLabel1.Text = "تعداد کاراکتر :";
            toolStripStatusLabel1.Click += toolStripStatusLabel1_Click;
            // 
            // lblchar
            // 
            lblchar.Name = "lblchar";
            lblchar.Size = new Size(17, 20);
            lblchar.Text = "0";
            // 
            // toolStripStatusLabel2
            // 
            toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            toolStripStatusLabel2.Size = new Size(94, 20);
            toolStripStatusLabel2.Text = "تعداد کلمات :";
            // 
            // lblword
            // 
            lblword.Name = "lblword";
            lblword.Size = new Size(17, 20);
            lblword.Text = "0";
            // 
            // ptop
            // 
            ptop.Controls.Add(toolStrip1);
            ptop.Controls.Add(menuStrip1);
            ptop.Dock = DockStyle.Top;
            ptop.Location = new Point(0, 0);
            ptop.Margin = new Padding(5);
            ptop.Name = "ptop";
            ptop.Size = new Size(751, 63);
            ptop.TabIndex = 0;
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { tlsCopy, tlsPaste, tlsCut, toolStripSeparator6, tlsUndo, toolStripSeparator7, tlsSub, tlsSearch, toolStripComboBox1, toolStripSeparator8, tlsPrint });
            toolStrip1.Location = new Point(0, 30);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(751, 28);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // tlsCopy
            // 
            tlsCopy.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tlsCopy.Image = Properties.Resources.icons8_copy_48;
            tlsCopy.ImageTransparentColor = Color.Magenta;
            tlsCopy.Name = "tlsCopy";
            tlsCopy.Size = new Size(29, 25);
            tlsCopy.Text = "رونوشت";
            // 
            // tlsPaste
            // 
            tlsPaste.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tlsPaste.Image = Properties.Resources.icons8_paste_48;
            tlsPaste.ImageTransparentColor = Color.Magenta;
            tlsPaste.Name = "tlsPaste";
            tlsPaste.Size = new Size(29, 25);
            tlsPaste.Text = "چسباندن";
            // 
            // tlsCut
            // 
            tlsCut.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tlsCut.Image = Properties.Resources.icons8_cut_64;
            tlsCut.ImageTransparentColor = Color.Magenta;
            tlsCut.Name = "tlsCut";
            tlsCut.Size = new Size(29, 25);
            tlsCut.Text = "بریدن";
            // 
            // toolStripSeparator6
            // 
            toolStripSeparator6.Name = "toolStripSeparator6";
            toolStripSeparator6.Size = new Size(6, 28);
            // 
            // tlsUndo
            // 
            tlsUndo.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tlsUndo.Image = Properties.Resources.icons8_undo_48;
            tlsUndo.ImageTransparentColor = Color.Magenta;
            tlsUndo.Name = "tlsUndo";
            tlsUndo.Size = new Size(29, 25);
            tlsUndo.Text = "واگرد";
            // 
            // toolStripSeparator7
            // 
            toolStripSeparator7.Name = "toolStripSeparator7";
            toolStripSeparator7.Size = new Size(6, 28);
            // 
            // tlsSub
            // 
            tlsSub.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tlsSub.Image = Properties.Resources.icons8_replacement_48;
            tlsSub.ImageTransparentColor = Color.Magenta;
            tlsSub.Name = "tlsSub";
            tlsSub.Size = new Size(29, 25);
            tlsSub.Text = "جایگزینی";
            // 
            // tlsSearch
            // 
            tlsSearch.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tlsSearch.Image = Properties.Resources.icons8_search_48;
            tlsSearch.ImageTransparentColor = Color.Magenta;
            tlsSearch.Name = "tlsSearch";
            tlsSearch.Size = new Size(29, 25);
            tlsSearch.Text = "جستوجو";
            // 
            // toolStripComboBox1
            // 
            toolStripComboBox1.Name = "toolStripComboBox1";
            toolStripComboBox1.Size = new Size(209, 28);
            // 
            // toolStripSeparator8
            // 
            toolStripSeparator8.Name = "toolStripSeparator8";
            toolStripSeparator8.Size = new Size(6, 28);
            // 
            // tlsPrint
            // 
            tlsPrint.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tlsPrint.Image = Properties.Resources.icons8_print_48;
            tlsPrint.ImageTransparentColor = Color.Magenta;
            tlsPrint.Name = "tlsPrint";
            tlsPrint.Size = new Size(29, 25);
            tlsPrint.Text = "چاپ";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { فایلToolStripMenuItem, ویرایToolStripMenuItem, قالببندیToolStripMenuItem, نماToolStripMenuItem, راهنماToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(12, 3, 0, 3);
            menuStrip1.Size = new Size(751, 30);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // فایلToolStripMenuItem
            // 
            فایلToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { tsmNewNote, tlmOpen, tlsOpenNew, toolStripSeparator1, tlsSave, tlsSaveas, toolStripSeparator2, tlsP, toolStripSeparator3, tlsExit });
            فایلToolStripMenuItem.Name = "فایلToolStripMenuItem";
            فایلToolStripMenuItem.Size = new Size(50, 24);
            فایلToolStripMenuItem.Text = "فایل";
            // 
            // tsmNewNote
            // 
            tsmNewNote.Image = Properties.Resources.icons8_page_orientation_48;
            tsmNewNote.Name = "tsmNewNote";
            tsmNewNote.ShortcutKeys = Keys.Control | Keys.N;
            tsmNewNote.Size = new Size(305, 26);
            tsmNewNote.Text = "سند جدید";
            tsmNewNote.Click += tsmNewNote_Click;
            // 
            // tlmOpen
            // 
            tlmOpen.Image = Properties.Resources.icons8_opened_folder_40;
            tlmOpen.Name = "tlmOpen";
            tlmOpen.ShortcutKeys = Keys.Control | Keys.O;
            tlmOpen.Size = new Size(305, 26);
            tlmOpen.Text = "باز کردن سند";
            tlmOpen.Click += tlmOpen_Click;
            // 
            // tlsOpenNew
            // 
            tlsOpenNew.Image = Properties.Resources.icons8_new_window_64;
            tlsOpenNew.Name = "tlsOpenNew";
            tlsOpenNew.ShortcutKeys = Keys.Control | Keys.Shift | Keys.N;
            tlsOpenNew.Size = new Size(305, 26);
            tlsOpenNew.Text = "باز کردن پنجره جدید";
            tlsOpenNew.Click += tlsOpenNew_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(302, 6);
            // 
            // tlsSave
            // 
            tlsSave.Image = Properties.Resources.icons8_save_48;
            tlsSave.Name = "tlsSave";
            tlsSave.ShortcutKeys = Keys.Control | Keys.S;
            tlsSave.Size = new Size(305, 26);
            tlsSave.Text = "ذخیره";
            tlsSave.Click += tlsSave_Click;
            // 
            // tlsSaveas
            // 
            tlsSaveas.Image = Properties.Resources.icons8_save_as_64;
            tlsSaveas.Name = "tlsSaveas";
            tlsSaveas.ShortcutKeys = Keys.Control | Keys.Shift | Keys.S;
            tlsSaveas.Size = new Size(305, 26);
            tlsSaveas.Text = "ذخیره در";
            tlsSaveas.Click += tlsSaveas_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(302, 6);
            // 
            // tlsP
            // 
            tlsP.Image = Properties.Resources.icons8_print_48;
            tlsP.Name = "tlsP";
            tlsP.ShortcutKeys = Keys.Control | Keys.P;
            tlsP.Size = new Size(305, 26);
            tlsP.Text = "چاپ";
            tlsP.Click += tlsP_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(302, 6);
            // 
            // tlsExit
            // 
            tlsExit.Image = Properties.Resources.icons8_exit_48;
            tlsExit.Name = "tlsExit";
            tlsExit.ShortcutKeys = Keys.F4;
            tlsExit.Size = new Size(305, 26);
            tlsExit.Text = "خروج از برنامه";
            tlsExit.Click += tlsExit_Click;
            // 
            // ویرایToolStripMenuItem
            // 
            ویرایToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { tlsU, mnuPaste, mnuCopy, mnuCut, mnuDelete, toolStripSeparator4, mnuSearch, چایگزینیToolStripMenuItem, toolStripSeparator5, انتخابهمهمتنToolStripMenuItem, درجتاریخToolStripMenuItem });
            ویرایToolStripMenuItem.Name = "ویرایToolStripMenuItem";
            ویرایToolStripMenuItem.Size = new Size(69, 24);
            ویرایToolStripMenuItem.Text = "ویرایش";
            // 
            // tlsU
            // 
            tlsU.Image = Properties.Resources.icons8_undo_48;
            tlsU.Name = "tlsU";
            tlsU.ShortcutKeys = Keys.Control | Keys.Z;
            tlsU.Size = new Size(244, 26);
            tlsU.Text = "واگرد";
            // 
            // mnuPaste
            // 
            mnuPaste.Image = Properties.Resources.icons8_paste_48;
            mnuPaste.Name = "mnuPaste";
            mnuPaste.ShortcutKeys = Keys.Control | Keys.V;
            mnuPaste.Size = new Size(244, 26);
            mnuPaste.Text = "چسباندن";
            mnuPaste.Click += mnuPaste_Click;
            // 
            // mnuCopy
            // 
            mnuCopy.Image = Properties.Resources.icons8_copy_48;
            mnuCopy.Name = "mnuCopy";
            mnuCopy.ShortcutKeys = Keys.Control | Keys.C;
            mnuCopy.Size = new Size(244, 26);
            mnuCopy.Text = "رونوشت";
            mnuCopy.Click += mnuCopy_Click;
            // 
            // mnuCut
            // 
            mnuCut.Image = Properties.Resources.icons8_cut_64;
            mnuCut.Name = "mnuCut";
            mnuCut.ShortcutKeys = Keys.Control | Keys.X;
            mnuCut.Size = new Size(244, 26);
            mnuCut.Text = "برش";
            mnuCut.Click += mnuCut_Click;
            // 
            // mnuDelete
            // 
            mnuDelete.Image = Properties.Resources.icons8_delete_48;
            mnuDelete.Name = "mnuDelete";
            mnuDelete.ShortcutKeys = Keys.Delete;
            mnuDelete.Size = new Size(244, 26);
            mnuDelete.Text = "حذف";
            mnuDelete.Click += mnuDelete_Click;
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(241, 6);
            // 
            // mnuSearch
            // 
            mnuSearch.Image = Properties.Resources.icons8_search_48;
            mnuSearch.Name = "mnuSearch";
            mnuSearch.ShortcutKeys = Keys.Control | Keys.F;
            mnuSearch.Size = new Size(244, 26);
            mnuSearch.Text = "جستوجو";
            mnuSearch.Click += mnuSearch_Click;
            // 
            // چایگزینیToolStripMenuItem
            // 
            چایگزینیToolStripMenuItem.Image = Properties.Resources.icons8_replacement_48;
            چایگزینیToolStripMenuItem.Name = "چایگزینیToolStripMenuItem";
            چایگزینیToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.H;
            چایگزینیToolStripMenuItem.Size = new Size(244, 26);
            چایگزینیToolStripMenuItem.Text = "جایگزینی";
            // 
            // toolStripSeparator5
            // 
            toolStripSeparator5.Name = "toolStripSeparator5";
            toolStripSeparator5.Size = new Size(241, 6);
            // 
            // انتخابهمهمتنToolStripMenuItem
            // 
            انتخابهمهمتنToolStripMenuItem.Image = Properties.Resources.icons8_select_all_48;
            انتخابهمهمتنToolStripMenuItem.Name = "انتخابهمهمتنToolStripMenuItem";
            انتخابهمهمتنToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.A;
            انتخابهمهمتنToolStripMenuItem.Size = new Size(244, 26);
            انتخابهمهمتنToolStripMenuItem.Text = "انتخاب همه متن";
            انتخابهمهمتنToolStripMenuItem.Click += انتخابهمهمتنToolStripMenuItem_Click;
            // 
            // درجتاریخToolStripMenuItem
            // 
            درجتاریخToolStripMenuItem.Image = Properties.Resources.icons8_date_94;
            درجتاریخToolStripMenuItem.Name = "درجتاریخToolStripMenuItem";
            درجتاریخToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Shift | Keys.T;
            درجتاریخToolStripMenuItem.Size = new Size(244, 26);
            درجتاریخToolStripMenuItem.Text = "درج تاریخ";
            درجتاریخToolStripMenuItem.Click += درجتاریخToolStripMenuItem_Click;
            // 
            // قالببندیToolStripMenuItem
            // 
            قالببندیToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { فونتToolStripMenuItem });
            قالببندیToolStripMenuItem.Name = "قالببندیToolStripMenuItem";
            قالببندیToolStripMenuItem.Size = new Size(87, 24);
            قالببندیToolStripMenuItem.Text = "قالب بندی";
            // 
            // فونتToolStripMenuItem
            // 
            فونتToolStripMenuItem.Image = Properties.Resources.icons8_font_48;
            فونتToolStripMenuItem.Name = "فونتToolStripMenuItem";
            فونتToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Shift | Keys.F;
            فونتToolStripMenuItem.Size = new Size(216, 26);
            فونتToolStripMenuItem.Text = "فونت";
            فونتToolStripMenuItem.Click += فونتToolStripMenuItem_Click;
            // 
            // نماToolStripMenuItem
            // 
            نماToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { tlsStatusBar, tlsToolBox });
            نماToolStripMenuItem.Name = "نماToolStripMenuItem";
            نماToolStripMenuItem.Size = new Size(41, 24);
            نماToolStripMenuItem.Text = "نما";
            // 
            // tlsStatusBar
            // 
            tlsStatusBar.Checked = true;
            tlsStatusBar.CheckState = CheckState.Checked;
            tlsStatusBar.Name = "tlsStatusBar";
            tlsStatusBar.Size = new Size(170, 26);
            tlsStatusBar.Text = "نوار وضعیت";
            tlsStatusBar.Click += tlsStatusBar_Click;
            // 
            // tlsToolBox
            // 
            tlsToolBox.Checked = true;
            tlsToolBox.CheckState = CheckState.Checked;
            tlsToolBox.Name = "tlsToolBox";
            tlsToolBox.Size = new Size(170, 26);
            tlsToolBox.Text = "جعبه ابزار";
            tlsToolBox.Click += tlsToolBox_Click;
            // 
            // راهنماToolStripMenuItem
            // 
            راهنماToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { mnuhelp, mnuMe });
            راهنماToolStripMenuItem.Name = "راهنماToolStripMenuItem";
            راهنماToolStripMenuItem.Size = new Size(60, 24);
            راهنماToolStripMenuItem.Text = "راهنما";
            // 
            // mnuhelp
            // 
            mnuhelp.Image = Properties.Resources.icons8_guide_64;
            mnuhelp.Name = "mnuhelp";
            mnuhelp.Size = new Size(248, 26);
            mnuhelp.Text = "راهنمای استفاده از برنامه";
            // 
            // mnuMe
            // 
            mnuMe.Image = Properties.Resources.icons8_call_me_skin_type_1_100;
            mnuMe.Name = "mnuMe";
            mnuMe.Size = new Size(248, 26);
            mnuMe.Text = "درباره ما";
            // 
            // saveFileDialog1
            // 
            saveFileDialog1.DefaultExt = "*.txt";
            saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog1.Title = "ذخیره متن";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.Title = "باز کردن متن";
            // 
            // printDialog1
            // 
            printDialog1.UseEXDialog = true;
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += printDocument1_PrintPage;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(14F, 39F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(751, 579);
            Controls.Add(pall);
            Font = new Font("B Zar", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 178);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Margin = new Padding(5);
            Name = "Form1";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "نوت پد فارسی";
            FormClosing += Form1_FormClosing;
            pall.ResumeLayout(false);
            pfil.ResumeLayout(false);
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
        private ToolStripButton tlsCopy;
        private ToolStripButton tlsPaste;
        private ToolStripMenuItem فایلToolStripMenuItem;
        private ToolStripMenuItem tsmNewNote;
        private ToolStripMenuItem tlmOpen;
        private ToolStripMenuItem tlsOpenNew;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem tlsSave;
        private ToolStripMenuItem tlsSaveas;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem tlsP;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem tlsExit;
        private ToolStripMenuItem ویرایToolStripMenuItem;
        private ToolStripMenuItem tlsU;
        private ToolStripMenuItem mnuPaste;
        private ToolStripMenuItem mnuCopy;
        private ToolStripMenuItem mnuCut;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripMenuItem mnuSearch;
        private ToolStripMenuItem چایگزینیToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripMenuItem انتخابهمهمتنToolStripMenuItem;
        private ToolStripMenuItem درجتاریخToolStripMenuItem;
        private ToolStripMenuItem قالببندیToolStripMenuItem;
        private ToolStripMenuItem فونتToolStripMenuItem;
        private ToolStripMenuItem نماToolStripMenuItem;
        private ToolStripMenuItem tlsStatusBar;
        private ToolStripMenuItem tlsToolBox;
        private ToolStripMenuItem راهنماToolStripMenuItem;
        private ToolStripMenuItem mnuhelp;
        private ToolStripMenuItem mnuMe;
        private ToolStripStatusLabel lblchar;
        private ToolStripStatusLabel toolStripStatusLabel2;
        private ToolStripStatusLabel lblword;
        private ToolStripButton tlsCut;
        private ToolStripSeparator toolStripSeparator6;
        private ToolStripButton tlsUndo;
        private ToolStripSeparator toolStripSeparator7;
        private ToolStripButton tlsSub;
        private ToolStripButton tlsSearch;
        private ToolStripComboBox toolStripComboBox1;
        private ToolStripSeparator toolStripSeparator8;
        private ToolStripButton tlsPrint;
        private SaveFileDialog saveFileDialog1;
        private OpenFileDialog openFileDialog1;
        private FontDialog fontDialog1;
        private ToolStripMenuItem mnuDelete;
        private PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        public RichTextBox richText;
    }
}
