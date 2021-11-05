using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
Substring Search Program | Assignment 4

This program allows the user to select a textfile to search and a substring to search for. 
Once the user has selected these, they can then press the "search" button.
Upon pressing, the program uses a BackgroundWorker thread to seach the text file.
Any line that contains the substring is displayed in a viewlist.
The user may cancel the program at any time by pressing the "cancel" button

Written by Parker Whitehead for CS6326.001, assignment 4, starting 10/20/2021.
NetID: pmw180000
*/
namespace Asg4_pmw180000
{
    public partial class Form1 : Form
    {
        //DataHandler object that contains file path and queue.
        DataHandler dataHandler;
        //Error Flags for textboxes.
        bool[] flags; 
        //Flag for thread to end process.
        bool threadFlag;
        public Form1()
        {
            InitializeComponent();
            dataHandler = new DataHandler();
            flags = new bool[2]{true,true};
            threadFlag = false;
        }

        private void Form1_Load(object sender, EventArgs e){}
        //Allows funcitonality for both running and canceling search.
        private void RunButton_Click(object sender, EventArgs e)
        {
            //if text worker isn't busy, that means that the button should be for "search"
            if(!textreadWorker.IsBusy)
            {
                string FULLPATH = dataHandler.FileDir + dataHandler.FileName;
                if(!File.Exists(FULLPATH)) //If the file doesn't exist, the button doesn't work and a sound is played
                {
                    FilenameTextbox.BackColor = Color.LightPink;
                    SystemSounds.Asterisk.Play();
                }
                else if (!flags.Contains<bool>(true)) //if all textboxes are valid, then search begins
                {
                    //grabs length of file for the progress bar.
                    int fileBitLength = (int)new System.IO.FileInfo(FULLPATH).Length; 
                    SearchProgressBar.Minimum = 0;
                    SearchProgressBar.Maximum = fileBitLength;
                    SearchProgressBar.Value = 0;
                    StringView.Items.Clear();
                    RunButton.Text = "Cancel";
                    //runs backgroundworker thread, which reads file.
                    textreadWorker.RunWorkerAsync(SubstringTextbox.Text);
                }
                else
                    SystemSounds.Asterisk.Play();
            }
            //if the backgroundworker is running, that means the button should be "cancel"
            else
            {
                threadFlag = true;
                StatusLabel.Text = "Search Canceled";
            }
        }
        //Opens browser window, allowing the user to select a file.
        private void BrowseButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //Stores path as dir and filename in datahandler
                string FullPath = openFileDialog1.FileName;
                dataHandler.FileDir = FullPath.Substring(0,FullPath.LastIndexOf("\\") + 1);
                dataHandler.FileName = FullPath.Substring(FullPath.LastIndexOf("\\") + 1);
                //displays only the file name, as this makes more sense to normal users.
                FilenameTextbox.Text = dataHandler.FileName;
            }

        }
        //doesn't allow substring textbox to be empty.
        //updates flag for substring textbox
        private void SubstringTextbox_TextChanged(object sender, EventArgs e)
        { 
            if(SubstringTextbox.Text=="")
            {
                SubstringTextbox.BackColor = Color.LightPink;
                flags[0] = true;
            }
            else
            {
                SubstringTextbox.BackColor = Color.White;
                flags[0] = false;
            }
        }
        //doesn't allow filename textbox to be anything but .txt
        private void FilenameTextbox_TextChanged(object sender, EventArgs e)
        {
            if (FilenameTextbox.Text == "" || FilenameTextbox.Text.IndexOf(".txt")==-1)
            {
                FilenameTextbox.BackColor = Color.LightPink;
                flags[1] = true;
            }
            else
            {
                FilenameTextbox.BackColor = Color.White;
                flags[1] = false;
            }
        }
        //reads text file line by line, storing only one line at a time.
        private void textreadWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            //grabs substring from arguments
            string substr = (string)e.Argument;
            string FULLPATH = dataHandler.FileDir + dataHandler.FileName;
            int index = 1;
            StatusLabel.Text = "Currently searching...";
            //reads file line by line
            using(StreamReader sw = new StreamReader(FULLPATH))
            {
                string line = "";
                while(!sw.EndOfStream)
                {
                    line = sw.ReadLine();
                    if (threadFlag)
                    {
                        threadFlag = false;
                        break;
                    }
                    if (line.IndexOf(substr, StringComparison.CurrentCultureIgnoreCase) >= 0)
                    {
                        //puts string into dataHandler queue for UI update.
                        dataHandler.queue.Enqueue(index.ToString() + "\t" + line);
                    }
                    //runs progress report to update UI
                    textreadWorker.ReportProgress(System.Text.ASCIIEncoding.ASCII.GetByteCount(line));
                    index++;
                    //simulates long textfile.
                    Thread.Sleep(1);
                }
            }
        }
        //empties the rest of the queue upon completing file search.
        private void textreadWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            string line = "";
            while(dataHandler.queue.TryDequeue(out line))
            {
                string index = line.Substring(0, line.IndexOf("\t") + 1);
                line = line.Substring(line.IndexOf("\t") + 1);
                ListViewItem listViewItem = new ListViewItem(index);
                listViewItem.SubItems.Add(line);
                StringView.Items.Add(listViewItem);
                StatusLabel.Text = "Match found at index " + index + ": " + line;
                SearchProgressBar.Value += System.Text.ASCIIEncoding.ASCII.GetByteCount(line);
            }
            RunButton.Text = "Start";
            StatusLabel.Text = "Search Complete. Found "+ StringView.Items.Count + " instances of the substring.";
            SearchProgressBar.Value = SearchProgressBar.Maximum;
        }
        //Checks Queue for contents. If can dequeue, past contents in listview.
        //Also update status label with found line & increase progress bar.
        private void textreadWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            string line = "";
            if(dataHandler.queue.TryDequeue(out line))
            {
                //adds item to listview
                string index = line.Substring(0, line.IndexOf("\t")+1);
                line = line.Substring(line.IndexOf("\t") + 1);
                ListViewItem listViewItem = new ListViewItem(index);
                listViewItem.SubItems.Add(line);
                StringView.Items.Add(listViewItem);
                //adds match to status label
                StatusLabel.Text = "Match found at index " + index + ": " + line;
            }
            //increments progress bar
            SearchProgressBar.Value += e.ProgressPercentage;
        }
    }
}
