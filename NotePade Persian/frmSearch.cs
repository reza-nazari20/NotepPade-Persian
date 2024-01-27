namespace NotePade_Persian
{
    public partial class frmSearch : Form
    {
        Form1 nform;
        public frmSearch(Form1 frm)
        {
            nform = frm;
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string SearchKey = txtSearch.Text;

            int startindex = 0;
            while (startindex < nform.richText.TextLength)
            {
                int wordstartindex = nform.richText.Find(SearchKey, startindex, RichTextBoxFinds.None);

                if (wordstartindex != -1)
                {
                    nform.richText.SelectionStart = wordstartindex;
                    nform.richText.SelectionLength = SearchKey.Length;
                    nform.richText.SelectionBackColor = Color.SkyBlue;
                }
                else
                    break;

                startindex = wordstartindex + SearchKey.Length;
            }
        }
    }
}
