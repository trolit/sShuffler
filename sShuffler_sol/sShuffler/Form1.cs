using System.Windows.Forms;

namespace sShuffler
{
    public partial class Form1 : Form
    {
        List<string> filesNames;
        List<string> filesPaths;

        public Form1()
        {
            InitializeComponent();
        private void ToggleButtons()
        {
            if(listView_files.Items.Count > 0)
            {
                clearBtn.Enabled = true;
                shuffleBtn.Enabled = true;
            } else
            {
                clearBtn.Enabled = false;
                shuffleBtn.Enabled = false;
            }
        }
        private String BytesToString(long byteCount)
        {
            string[] suf = { "B", "KB", "MB", "GB", "TB", "PB", "EB" }; //Longs run out around EB
            if (byteCount == 0)
                return "0" + suf[0];
            long bytes = Math.Abs(byteCount);
            int place = Convert.ToInt32(Math.Floor(Math.Log(bytes, 1024)));
            double num = Math.Round(bytes / Math.Pow(1024, place), 1);
            return (Math.Sign(byteCount) * num).ToString() + suf[place];
        }
    }
}
