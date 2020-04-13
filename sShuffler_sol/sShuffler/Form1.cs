using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
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
            InitButtons();
            InitHovers();
            SetDefaultValues();

            // Create structures
            filesNames = new List<string>();
            filesPaths = new List<string>();
            
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            pictureBox1.DragEnter += new DragEventHandler(Form1_DragEnter);
            pictureBox1.DragDrop += new DragEventHandler(Form1_DragDrop);
        }

        private void InitButtons()
        {
            clearBtn.Click += clearBtn_Click;
            helpBtn.Click += helpBtn_Click;
            shuffleBtn.Click += shuffleBtn_Click;
            listView_files.KeyDown += listView_files_KeyDown;
        }

        private void InitHovers()
        {
            manStartingPointHelpLabel.MouseHover += manStartingPointHelpLabel_MouseHover;
            manStartingPointHelpLabel.MouseLeave += manStartingPointHelpLabel_MouseLeave;
            infoBtn.MouseHover += infoBtn_MouseHover;
            infoBtn.MouseLeave += infoBtn_MouseLeave;
        }

        private void SetDefaultValues()
        {
            pictureBox1.AllowDrop = true;
            pictureBox2.Image.RotateFlip(RotateFlipType.RotateNoneFlipX);
            listView_files.Width = 435;
            infoBtn.FlatAppearance.MouseOverBackColor = infoBtn.BackColor;
            infoBtn.BackColorChanged += (s, e) => {
                infoBtn.FlatAppearance.MouseOverBackColor = infoBtn.BackColor;
            };
            startingPointNum.Maximum = 99999;
            clearBtn.Enabled = false;
            shuffleBtn.Enabled = false;
            startingPointNum.Enabled = false;
        }

        private void Form1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy;
        }

        private void listView_files_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if(listView_files.SelectedItems.Count > 0)
                {
                    foreach (ListViewItem eachItem in listView_files.SelectedItems)
                    {
                        listView_files.Items.Remove(eachItem);
                        filesNames.Remove(eachItem.Text);
                        consoleLog.AppendText(eachItem.Text + " removed from the list\n\n", Color.BlueViolet);
                    }
                    UpdateSchuffleTools();
                }
            }
        }

        private void Form1_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            foreach (string file in files)
            {
                FileInfo fi = new FileInfo(file);
                var fileName = GetFileNameWithoutExtension(file);
                var extension = Path.GetExtension(file);
                if (extension == ".mp3" || extension == ".wav")
                {
                    if (filesNames.Contains(fileName) == false)
                    {               
                        filesNames.Add(fileName);
                        var row = new string[] { fileName, BytesToString(fi.Length), fi.Extension };
                        var lvi = new ListViewItem(row);
                        listView_files.Items.Add(lvi);
                        consoleLog.AppendText(fileName + " added to the list\n\n", Color.Black);
                        filesPaths.Add(file);
                    } else if (filesNames.Contains(fileName) == true)
                    {
                        consoleLog.AppendText(fileName + " not added: song already on the list\n\n", Color.Red);
                    }
                } else
                {
                    consoleLog.AppendText(fileName + " not added: incorrect extension\n\n", Color.Red);
                }
            }
            UpdateSchuffleTools();
        }

        private void UpdateSchuffleTools()
        {
            totalShuffle.Text = "Total songs to sShuffle: " + listView_files.Items.Count;
            ToggleButtons();
        }

        private string GetFileNameWithoutExtension(string file)
        {
            return Path.GetFileNameWithoutExtension(file);
        }

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

        private void clearBtn_Click(object sender, EventArgs e)
        {
            listView_files.Items.Clear();
            filesNames.Clear();
            filesPaths.Clear();
            consoleLog.Clear();
            UpdateSchuffleTools();
        }

        private void helpBtn_Click(object sender, EventArgs e)
        {
            helpPanel.Visible = !helpPanel.Visible;
        }

        async private void shuffleBtn_Click(object sender, EventArgs e)
        {
            progressPanel.Visible = true;

            progressBar1.Minimum = 1;
            progressBar1.Value = 1;
            progressBar1.Step = 1;

            var dir = "result_" + DateTime.Now.ToString("HH_mm_ss");
            Directory.CreateDirectory(dir);

            Progress<int> progress = new Progress<int>
                (percentage => progressBar1.Value = percentage == 0 ? 1 : percentage);
            await Task.Run(() => PerformShuffle(progress, dir));
           
            progressPanel.Visible = false;

            Process.Start(dir);
        }

        private void PerformShuffle(IProgress<int> progress, string dir)
        {
            int poolStartingNum = 1;
            if (checkBox1.Checked == true)
            {
                poolStartingNum = Convert.ToInt32(startingPointNum.Value);
            }

            List<int> numPool = Enumerable.Range(poolStartingNum, filesPaths.Count).ToList();

            int zerosAmount;
            if (poolStartingNum != 1)
            {
                zerosAmount = ReturnZerosAmount(0);
            }
            else
            {
                zerosAmount = ReturnZerosAmount(numPool.Count);
            }

            Random rand = new Random();

            int iteration = 1;

            foreach (var filePath in filesPaths)
            {
                int randomIndex = rand.Next(0, numPool.Count);
                int songId = numPool[randomIndex];

                FileInfo fi = new FileInfo(filePath);
                var rawFileName = GetFileNameWithoutExtension(filePath);

                string newPath;
                if (rawFileName.Count(c => c == '.') > 0 && rawFileName.Substring(0, rawFileName.IndexOf(".")).Length < 5)
                {
                    string stringAfterDot = rawFileName.Substring(rawFileName.IndexOf(".") + 2);
                    newPath = dir + "/" + WriteZeros(zerosAmount, songId) + songId + ". " + stringAfterDot + fi.Extension;

                }
                else
                {
                    newPath = dir + "/" + WriteZeros(zerosAmount, songId) + songId + ". " + rawFileName + fi.Extension;
                }

                File.Copy(filePath, newPath);

                using (TagLib.File tlFile = TagLib.File.Create(newPath))
                {
                    tlFile.Tag.Track = (uint)numPool[randomIndex];
                    tlFile.Save();
                }

                numPool.Remove(songId);

                progress.Report((int)((double)iteration / filesPaths.Count * 100));

                iteration++;
            }
        }

        private int ReturnZerosAmount(int size)
        {
            // Case when startingPointNum was set
            if(size == 0)
            {
                var length = startingPointNum.Value.ToString().Length;
                if(length <= 3)
                {
                    length = 3;
                }
                return length;
            }

            // max 999 => 0001, 0002
            // max 9999 => 00001, 00002
            // max 99999 => 000001, 00002
            if (size <= 999)
            {
                return 3;
            } else
            {
                var length = size.ToString().Length;
                return length;
            }
        }

        private string WriteZeros(int amount, int number)
        {
            int numberLength = number.ToString().Length;
            return new string('0', amount - numberLength + 1);
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

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

        private void checkBox1_CheckedChanged(Object sender, EventArgs e)
        {
            if(checkBox1.Checked == true)
            {
                startingPointNum.Enabled = true;
            } else
            {
                startingPointNum.Enabled = false;
            }
        }

        private void manStartingPointHelpLabel_MouseHover(Object sender, EventArgs e)
        {
            manualStartingPointPanel.Visible = true;
        }

        private void manStartingPointHelpLabel_MouseLeave(Object sender, EventArgs e)
        {
            manualStartingPointPanel.Visible = false;
        }

        private void infoBtn_MouseHover(Object sender, EventArgs e)
        {
            infoPanel.Visible = true;
        }

        private void infoBtn_MouseLeave(Object sender, EventArgs e)
        {
            infoPanel.Visible = false;
        }
    }
}
