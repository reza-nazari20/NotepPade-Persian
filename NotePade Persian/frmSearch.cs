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

        List<Searchresult> searchresults = new List<Searchresult>();

        int indexSelectedSearchResult = -1;

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string SearchKey = txtSearch.Text;

            nform.richText.SelectionBackColor = nform.richText.BackColor;

            if (searchresults.Count() > 0)
            {
                ShowResultWithSelected(rdbDown.Checked);
                return;
            }
            else
            {
                searchresults = new List<Searchresult>();
            }

            var SearchOption = RichTextBoxFinds.None;
            if (rdbJust.Checked)
            {
                SearchOption = RichTextBoxFinds.WholeWord;
            }

            int startindex = 0;
            while (startindex < nform.richText.TextLength)
            {
                int wordstartindex = nform.richText.Find(SearchKey, startindex, SearchOption);

                if (wordstartindex != -1)
                {


                    searchresults.Add(new Searchresult
                    {
                        SelectionStart = wordstartindex,
                        SelectionLength = SearchKey.Length,
                        SearchKey = SearchKey
                    }); ;
                }
                else
                    break;

                startindex = wordstartindex + SearchKey.Length;
            }
            ShowResultWithSelected(rdbDown.Checked);
        }
        private void ShowResultWithSelected(bool IsDown)
        {
            try
            {
                if (IsDown == true)
                {
                    indexSelectedSearchResult++;
                }
                else
                {
                    indexSelectedSearchResult--;
                }

                var selected = searchresults[indexSelectedSearchResult];

                nform.richText.SelectionStart = selected.SelectionStart;
                nform.richText.SelectionLength = selected.SelectionLength;
                nform.richText.SelectionBackColor = Color.SkyBlue;

                if (searchresults.Count() <= indexSelectedSearchResult)
                {
                    indexSelectedSearchResult = 0;
                    searchresults = new List<Searchresult>();
                }
            }
            catch (Exception )
            {
                if (IsDown == true)
                {
                    indexSelectedSearchResult--;
                }
                else
                {
                    indexSelectedSearchResult++;
                }

                var selected = searchresults[indexSelectedSearchResult];

                nform.richText.SelectionStart = selected.SelectionStart;
                nform.richText.SelectionLength = selected.SelectionLength;
                nform.richText.SelectionBackColor = Color.SkyBlue;
            }  
        }

        private void frmSearch_FormClosing(object sender, FormClosingEventArgs e)
        {
            nform.richText.SelectionBackColor = nform.richText.BackColor;
        }
    }
    public class Searchresult
    {
        public int SelectionStart { get; set; }

        public int SelectionLength { get; set; }

        public required string SearchKey { get; set; }
    }
}
