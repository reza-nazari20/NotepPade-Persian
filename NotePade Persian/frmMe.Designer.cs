namespace NotePade_Persian
{
    partial class frmMe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMe));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            pictureBox1 = new PictureBox();
            label8 = new Label();
            label9 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("B Zar", 18F, FontStyle.Regular, GraphicsUnit.Point, 178);
            label1.Location = new Point(3, 9);
            label1.Name = "label1";
            label1.Size = new Size(118, 50);
            label1.TabIndex = 0;
            label1.Text = "درباره من :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("B Zar", 13F);
            label2.Location = new Point(99, 56);
            label2.Name = "label2";
            label2.Size = new Size(208, 37);
            label2.TabIndex = 1;
            label2.Text = "بنده مهندس رضا نظری هستم ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("B Zar", 13F);
            label3.Location = new Point(99, 95);
            label3.Name = "label3";
            label3.Size = new Size(324, 37);
            label3.TabIndex = 2;
            label3.Text = "که همواره در حال تلاش هستم تا بیشتر یادبگیرم";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("B Zar", 13F);
            label4.Location = new Point(99, 132);
            label4.Name = "label4";
            label4.Size = new Size(270, 37);
            label4.TabIndex = 3;
            label4.Text = "و به درجات والا و عالی برسم ✌️😉.";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("B Zar", 18F, FontStyle.Regular, GraphicsUnit.Point, 178);
            label5.Location = new Point(3, 221);
            label5.Name = "label5";
            label5.Size = new Size(203, 50);
            label5.TabIndex = 4;
            label5.Text = "پل های ارتباطی من :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("B Zar", 13F);
            label6.Location = new Point(98, 309);
            label6.Name = "label6";
            label6.Size = new Size(104, 37);
            label6.TabIndex = 5;
            label6.Text = "شماره تماس :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("B Zar", 13F);
            label7.Location = new Point(98, 364);
            label7.Name = "label7";
            label7.Size = new Size(61, 37);
            label7.TabIndex = 7;
            label7.Text = "ایمیل :";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.meEdit;
            pictureBox1.Location = new Point(444, 45);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(257, 297);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("B Zar", 13.2000008F, FontStyle.Underline, GraphicsUnit.Point, 178);
            label8.Location = new Point(221, 309);
            label8.Name = "label8";
            label8.Size = new Size(116, 39);
            label8.TabIndex = 10;
            label8.Text = "09186318879";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("B Zar", 13.2000008F, FontStyle.Underline, GraphicsUnit.Point, 178);
            label9.Location = new Point(221, 364);
            label9.Name = "label9";
            label9.Size = new Size(286, 39);
            label9.TabIndex = 11;
            label9.Text = "pr.rezanazari@gmail.com";
            // 
            // frmMe
            // 
            AutoScaleDimensions = new SizeF(9F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(713, 473);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(pictureBox1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("B Zar", 9F, FontStyle.Regular, GraphicsUnit.Point, 178);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmMe";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "درباره من";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private PictureBox pictureBox1;
        private Label label8;
        private Label label9;
    }
}