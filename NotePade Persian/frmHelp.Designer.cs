namespace NotePade_Persian
{
    partial class frmHelp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHelp));
            label1 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("B Zar", 18F, FontStyle.Regular, GraphicsUnit.Point, 178);
            label1.Location = new Point(12, 24);
            label1.Name = "label1";
            label1.Size = new Size(388, 50);
            label1.TabIndex = 0;
            label1.Text = "جهت راهنمایی با شماره زیر تماس بگیرد :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("B Zar", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 178);
            label2.Location = new Point(145, 146);
            label2.Name = "label2";
            label2.Size = new Size(143, 47);
            label2.TabIndex = 1;
            label2.Text = "مهندس نظری :";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.icons8_call_96;
            pictureBox1.Location = new Point(439, 119);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(99, 105);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(112, 280);
            label3.Name = "label3";
            label3.Size = new Size(288, 34);
            label3.TabIndex = 4;
            label3.Text = "24 ساعت شبانه روز پاسخگوی شما هستیم\U0001fae1";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("B Zar", 13.2000008F, FontStyle.Underline, GraphicsUnit.Point, 178);
            label8.Location = new Point(294, 151);
            label8.Name = "label8";
            label8.Size = new Size(116, 39);
            label8.TabIndex = 11;
            label8.Text = "09186318879";
            // 
            // frmHelp
            // 
            AutoScaleDimensions = new SizeF(12F, 34F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(550, 363);
            Controls.Add(label8);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("B Zar", 12F, FontStyle.Regular, GraphicsUnit.Point, 178);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 5, 4, 5);
            Name = "frmHelp";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            Text = "راهنما";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
        private Label label3;
        private Label label8;
    }
}