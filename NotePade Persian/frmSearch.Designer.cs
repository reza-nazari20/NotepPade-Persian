namespace NotePade_Persian
{
    partial class frmSearch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSearch));
            label1 = new Label();
            txtSearch = new TextBox();
            btnSearch = new Button();
            btnCancel = new Button();
            groupBox1 = new GroupBox();
            rdbCom = new RadioButton();
            rdbJust = new RadioButton();
            groupBox2 = new GroupBox();
            rdbDown = new RadioButton();
            rdbTop = new RadioButton();
            btnReplace = new Button();
            btnReplaceAll = new Button();
            label2 = new Label();
            txtReplace = new TextBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 25);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(75, 34);
            label1.TabIndex = 0;
            label1.Text = "جستوجو :";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(89, 22);
            txtSearch.Margin = new Padding(2);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(328, 41);
            txtSearch.TabIndex = 1;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.SkyBlue;
            btnSearch.Location = new Point(483, 11);
            btnSearch.Margin = new Padding(2);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(108, 48);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "جستوجو";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Red;
            btnCancel.Location = new Point(483, 184);
            btnCancel.Margin = new Padding(2);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(108, 48);
            btnCancel.TabIndex = 3;
            btnCancel.Text = "لغو";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rdbCom);
            groupBox1.Controls.Add(rdbJust);
            groupBox1.Location = new Point(28, 284);
            groupBox1.Margin = new Padding(2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2);
            groupBox1.Size = new Size(245, 128);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "نحوه جستوجو";
            // 
            // rdbCom
            // 
            rdbCom.AutoSize = true;
            rdbCom.Location = new Point(15, 83);
            rdbCom.Name = "rdbCom";
            rdbCom.Size = new Size(154, 38);
            rdbCom.TabIndex = 1;
            rdbCom.Text = "شامل این کلمه باشد";
            rdbCom.UseVisualStyleBackColor = true;
            // 
            // rdbJust
            // 
            rdbJust.AutoSize = true;
            rdbJust.Checked = true;
            rdbJust.Location = new Point(40, 39);
            rdbJust.Name = "rdbJust";
            rdbJust.Size = new Size(129, 38);
            rdbJust.TabIndex = 0;
            rdbJust.TabStop = true;
            rdbJust.Text = "دقیقا همین کلمه";
            rdbJust.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(rdbDown);
            groupBox2.Controls.Add(rdbTop);
            groupBox2.Location = new Point(353, 284);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(250, 128);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "جهت جستوجو";
            // 
            // rdbDown
            // 
            rdbDown.AutoSize = true;
            rdbDown.Checked = true;
            rdbDown.Location = new Point(59, 83);
            rdbDown.Name = "rdbDown";
            rdbDown.Size = new Size(79, 38);
            rdbDown.TabIndex = 1;
            rdbDown.TabStop = true;
            rdbDown.Text = "به پایین";
            rdbDown.UseVisualStyleBackColor = true;
            // 
            // rdbTop
            // 
            rdbTop.AutoSize = true;
            rdbTop.Location = new Point(70, 39);
            rdbTop.Name = "rdbTop";
            rdbTop.Size = new Size(68, 38);
            rdbTop.TabIndex = 0;
            rdbTop.Text = "به بالا";
            rdbTop.UseVisualStyleBackColor = true;
            // 
            // btnReplace
            // 
            btnReplace.BackColor = Color.SkyBlue;
            btnReplace.Location = new Point(483, 74);
            btnReplace.Margin = new Padding(2);
            btnReplace.Name = "btnReplace";
            btnReplace.Size = new Size(108, 48);
            btnReplace.TabIndex = 6;
            btnReplace.Text = "جایگزینی";
            btnReplace.UseVisualStyleBackColor = false;
            btnReplace.Click += btnReplace_Click;
            // 
            // btnReplaceAll
            // 
            btnReplaceAll.BackColor = Color.SkyBlue;
            btnReplaceAll.Location = new Point(483, 132);
            btnReplaceAll.Margin = new Padding(2);
            btnReplaceAll.Name = "btnReplaceAll";
            btnReplaceAll.Size = new Size(108, 48);
            btnReplaceAll.TabIndex = 7;
            btnReplaceAll.Text = "جایگزینی همه";
            btnReplaceAll.UseVisualStyleBackColor = false;
            btnReplaceAll.Click += btnReplaceAll_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 103);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(77, 34);
            label2.TabIndex = 8;
            label2.Text = "جایگزین :";
            // 
            // txtReplace
            // 
            txtReplace.Location = new Point(89, 100);
            txtReplace.Margin = new Padding(2);
            txtReplace.Name = "txtReplace";
            txtReplace.Size = new Size(328, 41);
            txtReplace.TabIndex = 9;
            // 
            // frmSearch
            // 
            AutoScaleDimensions = new SizeF(12F, 34F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(630, 423);
            Controls.Add(txtReplace);
            Controls.Add(label2);
            Controls.Add(btnReplaceAll);
            Controls.Add(btnReplace);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(btnCancel);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(label1);
            Font = new Font("B Zar", 12F, FontStyle.Regular, GraphicsUnit.Point, 178);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5, 6, 5, 6);
            Name = "frmSearch";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = " جستوجو";
            FormClosing += frmSearch_FormClosing;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtSearch;
        private Button btnSearch;
        private Button btnCancel;
        private GroupBox groupBox1;
        private RadioButton rdbCom;
        private RadioButton rdbJust;
        private GroupBox groupBox2;
        private RadioButton rdbDown;
        private RadioButton rdbTop;
        private Button btnReplace;
        private Button btnReplaceAll;
        private Label label2;
        private TextBox txtReplace;
    }
}