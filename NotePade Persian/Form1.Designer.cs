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
            بازکردنپنجرهجدیدToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            ذخیرهToolStripMenuItem = new ToolStripMenuItem();
            ذخیرهدرToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            چاپToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator3 = new ToolStripSeparator();
            خروجازبرنامهToolStripMenuItem = new ToolStripMenuItem();
            ویرایToolStripMenuItem = new ToolStripMenuItem();
            واگردToolStripMenuItem = new ToolStripMenuItem();
            چسباندنToolStripMenuItem = new ToolStripMenuItem();
            رونوشتToolStripMenuItem = new ToolStripMenuItem();
            برشToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator4 = new ToolStripSeparator();
            جستوجوToolStripMenuItem = new ToolStripMenuItem();
            چایگزینیToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator5 = new ToolStripSeparator();
            انتخابهمهمتنToolStripMenuItem = new ToolStripMenuItem();
            درجتاریخToolStripMenuItem = new ToolStripMenuItem();
            قالببندیToolStripMenuItem = new ToolStripMenuItem();
            فونتToolStripMenuItem = new ToolStripMenuItem();
            نماToolStripMenuItem = new ToolStripMenuItem();
            نواروضعیتToolStripMenuItem = new ToolStripMenuItem();
            جعبهابزارToolStripMenuItem = new ToolStripMenuItem();
            راهنماToolStripMenuItem = new ToolStripMenuItem();
            راهنمایاستفادهازبرنامهToolStripMenuItem = new ToolStripMenuItem();
            دربارهماToolStripMenuItem = new ToolStripMenuItem();
            saveFileDialog1 = new SaveFileDialog();
            openFileDialog1 = new OpenFileDialog();
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
            pall.Margin = new Padding(5, 4, 5, 4);
            pall.Name = "pall";
            pall.Size = new Size(697, 595);
            pall.TabIndex = 0;
            // 
            // pfil
            // 
            pfil.Controls.Add(richText);
            pfil.Dock = DockStyle.Fill;
            pfil.Location = new Point(0, 58);
            pfil.Margin = new Padding(5, 4, 5, 4);
            pfil.Name = "pfil";
            pfil.Size = new Size(697, 512);
            pfil.TabIndex = 2;
            // 
            // richText
            // 
            richText.Dock = DockStyle.Fill;
            richText.Location = new Point(0, 0);
            richText.Margin = new Padding(5, 4, 5, 4);
            richText.Name = "richText";
            richText.Size = new Size(697, 512);
            richText.TabIndex = 0;
            richText.Text = "";
            richText.TextChanged += richText_TextChanged;
            // 
            // pbut
            // 
            pbut.Controls.Add(statusStrip1);
            pbut.Dock = DockStyle.Bottom;
            pbut.Location = new Point(0, 570);
            pbut.Margin = new Padding(5, 4, 5, 4);
            pbut.Name = "pbut";
            pbut.Size = new Size(697, 25);
            pbut.TabIndex = 1;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1, lblchar, toolStripStatusLabel2, lblword });
            statusStrip1.Location = new Point(0, -1);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Padding = new Padding(24, 0, 1, 0);
            statusStrip1.Size = new Size(697, 26);
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
            ptop.Margin = new Padding(5, 4, 5, 4);
            ptop.Name = "ptop";
            ptop.Size = new Size(697, 58);
            ptop.TabIndex = 0;
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { tlsCopy, tlsPaste, tlsCut, toolStripSeparator6, tlsUndo, toolStripSeparator7, tlsSub, tlsSearch, toolStripComboBox1, toolStripSeparator8, tlsPrint });
            toolStrip1.Location = new Point(0, 28);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(697, 28);
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
            toolStripComboBox1.Size = new Size(194, 28);
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
            menuStrip1.Padding = new Padding(11, 2, 0, 2);
            menuStrip1.Size = new Size(697, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // فایلToolStripMenuItem
            // 
            فایلToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { tsmNewNote, tlmOpen, بازکردنپنجرهجدیدToolStripMenuItem, toolStripSeparator1, ذخیرهToolStripMenuItem, ذخیرهدرToolStripMenuItem, toolStripSeparator2, چاپToolStripMenuItem, toolStripSeparator3, خروجازبرنامهToolStripMenuItem });
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
            // بازکردنپنجرهجدیدToolStripMenuItem
            // 
            بازکردنپنجرهجدیدToolStripMenuItem.Image = Properties.Resources.icons8_new_window_64;
            بازکردنپنجرهجدیدToolStripMenuItem.Name = "بازکردنپنجرهجدیدToolStripMenuItem";
            بازکردنپنجرهجدیدToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Shift | Keys.N;
            بازکردنپنجرهجدیدToolStripMenuItem.Size = new Size(305, 26);
            بازکردنپنجرهجدیدToolStripMenuItem.Text = "باز کردن پنجره جدید";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(302, 6);
            // 
            // ذخیرهToolStripMenuItem
            // 
            ذخیرهToolStripMenuItem.Image = Properties.Resources.icons8_save_48;
            ذخیرهToolStripMenuItem.Name = "ذخیرهToolStripMenuItem";
            ذخیرهToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.S;
            ذخیرهToolStripMenuItem.Size = new Size(305, 26);
            ذخیرهToolStripMenuItem.Text = "ذخیره";
            // 
            // ذخیرهدرToolStripMenuItem
            // 
            ذخیرهدرToolStripMenuItem.Image = Properties.Resources.icons8_save_as_64;
            ذخیرهدرToolStripMenuItem.Name = "ذخیرهدرToolStripMenuItem";
            ذخیرهدرToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Shift | Keys.S;
            ذخیرهدرToolStripMenuItem.Size = new Size(305, 26);
            ذخیرهدرToolStripMenuItem.Text = "ذخیره در";
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(302, 6);
            // 
            // چاپToolStripMenuItem
            // 
            چاپToolStripMenuItem.Image = Properties.Resources.icons8_print_48;
            چاپToolStripMenuItem.Name = "چاپToolStripMenuItem";
            چاپToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.P;
            چاپToolStripMenuItem.Size = new Size(305, 26);
            چاپToolStripMenuItem.Text = "چاپ";
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(302, 6);
            // 
            // خروجازبرنامهToolStripMenuItem
            // 
            خروجازبرنامهToolStripMenuItem.Image = Properties.Resources.icons8_exit_48;
            خروجازبرنامهToolStripMenuItem.Name = "خروجازبرنامهToolStripMenuItem";
            خروجازبرنامهToolStripMenuItem.ShortcutKeys = Keys.F4;
            خروجازبرنامهToolStripMenuItem.Size = new Size(305, 26);
            خروجازبرنامهToolStripMenuItem.Text = "خروج از برنامه";
            // 
            // ویرایToolStripMenuItem
            // 
            ویرایToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { واگردToolStripMenuItem, چسباندنToolStripMenuItem, رونوشتToolStripMenuItem, برشToolStripMenuItem, toolStripSeparator4, جستوجوToolStripMenuItem, چایگزینیToolStripMenuItem, toolStripSeparator5, انتخابهمهمتنToolStripMenuItem, درجتاریخToolStripMenuItem });
            ویرایToolStripMenuItem.Name = "ویرایToolStripMenuItem";
            ویرایToolStripMenuItem.Size = new Size(69, 24);
            ویرایToolStripMenuItem.Text = "ویرایش";
            // 
            // واگردToolStripMenuItem
            // 
            واگردToolStripMenuItem.Image = Properties.Resources.icons8_undo_48;
            واگردToolStripMenuItem.Name = "واگردToolStripMenuItem";
            واگردToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Z;
            واگردToolStripMenuItem.Size = new Size(244, 26);
            واگردToolStripMenuItem.Text = "واگرد";
            // 
            // چسباندنToolStripMenuItem
            // 
            چسباندنToolStripMenuItem.Image = Properties.Resources.icons8_paste_48;
            چسباندنToolStripMenuItem.Name = "چسباندنToolStripMenuItem";
            چسباندنToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.V;
            چسباندنToolStripMenuItem.Size = new Size(244, 26);
            چسباندنToolStripMenuItem.Text = "چسباندن";
            // 
            // رونوشتToolStripMenuItem
            // 
            رونوشتToolStripMenuItem.Image = Properties.Resources.icons8_copy_48;
            رونوشتToolStripMenuItem.Name = "رونوشتToolStripMenuItem";
            رونوشتToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.C;
            رونوشتToolStripMenuItem.Size = new Size(244, 26);
            رونوشتToolStripMenuItem.Text = "رونوشت";
            // 
            // برشToolStripMenuItem
            // 
            برشToolStripMenuItem.Image = Properties.Resources.icons8_cut_64;
            برشToolStripMenuItem.Name = "برشToolStripMenuItem";
            برشToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.X;
            برشToolStripMenuItem.Size = new Size(244, 26);
            برشToolStripMenuItem.Text = "برش";
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(241, 6);
            // 
            // جستوجوToolStripMenuItem
            // 
            جستوجوToolStripMenuItem.Image = Properties.Resources.icons8_search_48;
            جستوجوToolStripMenuItem.Name = "جستوجوToolStripMenuItem";
            جستوجوToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.F;
            جستوجوToolStripMenuItem.Size = new Size(244, 26);
            جستوجوToolStripMenuItem.Text = "جستوجو";
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
            // 
            // درجتاریخToolStripMenuItem
            // 
            درجتاریخToolStripMenuItem.Image = Properties.Resources.icons8_date_94;
            درجتاریخToolStripMenuItem.Name = "درجتاریخToolStripMenuItem";
            درجتاریخToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Shift | Keys.T;
            درجتاریخToolStripMenuItem.Size = new Size(244, 26);
            درجتاریخToolStripMenuItem.Text = "درج تاریخ";
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
            // 
            // نماToolStripMenuItem
            // 
            نماToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { نواروضعیتToolStripMenuItem, جعبهابزارToolStripMenuItem });
            نماToolStripMenuItem.Name = "نماToolStripMenuItem";
            نماToolStripMenuItem.Size = new Size(41, 24);
            نماToolStripMenuItem.Text = "نما";
            // 
            // نواروضعیتToolStripMenuItem
            // 
            نواروضعیتToolStripMenuItem.Checked = true;
            نواروضعیتToolStripMenuItem.CheckState = CheckState.Checked;
            نواروضعیتToolStripMenuItem.Name = "نواروضعیتToolStripMenuItem";
            نواروضعیتToolStripMenuItem.Size = new Size(170, 26);
            نواروضعیتToolStripMenuItem.Text = "نوار وضعیت";
            // 
            // جعبهابزارToolStripMenuItem
            // 
            جعبهابزارToolStripMenuItem.Checked = true;
            جعبهابزارToolStripMenuItem.CheckState = CheckState.Checked;
            جعبهابزارToolStripMenuItem.Name = "جعبهابزارToolStripMenuItem";
            جعبهابزارToolStripMenuItem.Size = new Size(170, 26);
            جعبهابزارToolStripMenuItem.Text = "جعبه ابزار";
            // 
            // راهنماToolStripMenuItem
            // 
            راهنماToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { راهنمایاستفادهازبرنامهToolStripMenuItem, دربارهماToolStripMenuItem });
            راهنماToolStripMenuItem.Name = "راهنماToolStripMenuItem";
            راهنماToolStripMenuItem.Size = new Size(60, 24);
            راهنماToolStripMenuItem.Text = "راهنما";
            // 
            // راهنمایاستفادهازبرنامهToolStripMenuItem
            // 
            راهنمایاستفادهازبرنامهToolStripMenuItem.Image = Properties.Resources.icons8_guide_64;
            راهنمایاستفادهازبرنامهToolStripMenuItem.Name = "راهنمایاستفادهازبرنامهToolStripMenuItem";
            راهنمایاستفادهازبرنامهToolStripMenuItem.Size = new Size(248, 26);
            راهنمایاستفادهازبرنامهToolStripMenuItem.Text = "راهنمای استفاده از برنامه";
            // 
            // دربارهماToolStripMenuItem
            // 
            دربارهماToolStripMenuItem.Image = Properties.Resources.icons8_call_me_skin_type_1_100;
            دربارهماToolStripMenuItem.Name = "دربارهماToolStripMenuItem";
            دربارهماToolStripMenuItem.Size = new Size(248, 26);
            دربارهماToolStripMenuItem.Text = "درباره ما";
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(697, 595);
            Controls.Add(pall);
            Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Margin = new Padding(5, 4, 5, 4);
            Name = "Form1";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "نوت پد فارسی";
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
        private ToolStripMenuItem بازکردنپنجرهجدیدToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem ذخیرهToolStripMenuItem;
        private ToolStripMenuItem ذخیرهدرToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem چاپToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem خروجازبرنامهToolStripMenuItem;
        private ToolStripMenuItem ویرایToolStripMenuItem;
        private ToolStripMenuItem واگردToolStripMenuItem;
        private ToolStripMenuItem چسباندنToolStripMenuItem;
        private ToolStripMenuItem رونوشتToolStripMenuItem;
        private ToolStripMenuItem برشToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripMenuItem جستوجوToolStripMenuItem;
        private ToolStripMenuItem چایگزینیToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripMenuItem انتخابهمهمتنToolStripMenuItem;
        private ToolStripMenuItem درجتاریخToolStripMenuItem;
        private ToolStripMenuItem قالببندیToolStripMenuItem;
        private ToolStripMenuItem فونتToolStripMenuItem;
        private ToolStripMenuItem نماToolStripMenuItem;
        private ToolStripMenuItem نواروضعیتToolStripMenuItem;
        private ToolStripMenuItem جعبهابزارToolStripMenuItem;
        private ToolStripMenuItem راهنماToolStripMenuItem;
        private ToolStripMenuItem راهنمایاستفادهازبرنامهToolStripMenuItem;
        private ToolStripMenuItem دربارهماToolStripMenuItem;
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
        private RichTextBox richText;
        private SaveFileDialog saveFileDialog1;
        private OpenFileDialog openFileDialog1;
    }
}
