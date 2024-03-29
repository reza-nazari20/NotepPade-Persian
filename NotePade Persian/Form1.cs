﻿using System.Diagnostics;

namespace NotePade_Persian
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //برای اینکه بفهمیم که آیا متن تغییر داشته یا نه
        bool RichTextChange = false;

        //برای ذخیره کردن  متن 
        string pathsave = "";

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

        private void tlmOpen_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = openFileDialog1.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                string textOP;
                using (StreamReader sr = new StreamReader(openFileDialog1.FileName))
                {
                    textOP = sr.ReadToEnd();
                }
                richText.Text = textOP;
            }
        }

        private void tlsOpenNew_Click(object sender, EventArgs e)
        {
            string StartNew = Process.GetCurrentProcess().ProcessName;
            Process.Start(StartNew);
        }

        private void tlsSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(pathsave) == false)
            {
                using (StreamWriter sw = new StreamWriter(pathsave))
                {
                    sw.Write(richText.Text);
                }
            }
            else
            {
                var ResultSave = saveFileDialog1.ShowDialog();
                if (ResultSave == DialogResult.OK)
                {
                    using (StreamWriter sw = new StreamWriter(saveFileDialog1.FileName))
                    {
                        sw.Write(richText.Text);
                    }
                    pathsave = saveFileDialog1.FileName;
                }
            }
        }

        private void tlsSaveas_Click(object sender, EventArgs e)
        {
            var ResultSave = saveFileDialog1.ShowDialog();
            if (ResultSave == DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(saveFileDialog1.FileName))
                {
                    sw.Write(richText.Text);
                }
                pathsave = saveFileDialog1.FileName;
            }
        }

        private void فونتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            richText.Font = fontDialog1.Font;
        }

        private void tlsExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (RichTextChange == true)
            {
                DialogResult dialogResult = MessageBox.Show("تغییرات اعمال شده را میخواهید ذخیره کنید؟", "ذخیره تغییرات", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);

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
                        }
                        break;
                }
            }
        }

        private void tlsStatusBar_Click(object sender, EventArgs e)
        {
            tlsStatusBar.Checked = !tlsStatusBar.Checked;
            statusStrip1.Visible = !statusStrip1.Visible;
        }

        private void tlsToolBox_Click(object sender, EventArgs e)
        {
            tlsToolBox.Checked = !tlsToolBox.Checked;
            toolStrip1.Visible = !toolStrip1.Visible;
        }

        private void mnuCopy_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(richText.SelectedText))
            {
                Clipboard.SetText(richText.SelectedText);
            }
            else
            {
                Clipboard.SetText(richText.Text);
            }
        }

        private void mnuPaste_Click(object sender, EventArgs e)
        {
            if (Clipboard.ContainsText())
            {
                richText.Text += Clipboard.GetText(TextDataFormat.UnicodeText).ToString();
            }
        }

        private void mnuCut_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(richText.SelectedText))
            {
                Clipboard.SetText(richText.SelectedText);
                richText.Text = richText.Text.Replace(richText.SelectedText, "");
            }
            else
            {
                Clipboard.SetText(richText.Text);
                richText.Text = richText.Text.Replace(richText.Text, "");
            }
        }

        private void mnuDelete_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(richText.SelectedText))
            {
                richText.Text = richText.Text.Replace(richText.SelectedText, "");
            }
            else
            {
                richText.Text = richText.Text.Replace(richText.Text, "");
            }
        }

        private void انتخابهمهمتنToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richText.SelectAll();
        }

        private void درجتاریخToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richText.Text += $"{DateTime.Now.ToShortDateString()}   {DateTime.Now.ToShortTimeString()}";
        }

        private void tlsP_Click(object sender, EventArgs e)
        {
            printDialog1.Document = printDocument1;

            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

        }

        private void mnuSearch_Click(object sender, EventArgs e)
        {
            frmSearch search = new frmSearch(this);
            search.ShowDialog();
        }

        private void چایگزینیToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSearch search = new frmSearch(this);
            search.ShowDialog();
        }

        private void mnuhelp_Click(object sender, EventArgs e)
        {
            frmHelp nfrmHelp = new frmHelp();
            nfrmHelp.ShowDialog();
        }

        private void mnuMe_Click(object sender, EventArgs e)
        {
            frmMe nfrmMe = new frmMe();
            nfrmMe.ShowDialog();
        }
    }
}
