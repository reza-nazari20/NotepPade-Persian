﻿namespace NotePade_Persian
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //برای اینکه بفهمیم که آیا متن تغییر داشته یا نه
        bool RichTextChange = false;

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void tsmNewNote_Click(object sender, EventArgs e)
        {
            if (RichTextChange == true)
            {
                DialogResult dialogResult = MessageBox.Show("آیا میخواهید تغییرات را اعمال کنید؟", "ذخیره تغییرات", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

                switch (dialogResult)
                {
                    case DialogResult.Yes:
                        var ResultSave = saveFileDialog1.ShowDialog();
                        if (ResultSave == DialogResult.OK)
                        {
                            using (StreamWriter sw = new StreamWriter(saveFileDialog1.FileName))
                            {
                                sw.Write(richText.Text);
                            }
                            richText.Text = "";
                        }
                        break;

                    case DialogResult.No:
                        richText.Text = "";
                        break;
                }
            }
            else
            {
                richText.Text = "";
            }
            RichTextChange = false;

        }

        private void richText_TextChanged(object sender, EventArgs e)
        {
            RichTextChange = true;
        }
    }
}
