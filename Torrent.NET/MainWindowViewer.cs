using BencodeNET.Objects;
using BencodeNET.Parsing;
using BencodeNET.Torrents;
using System;
using System.IO;
using System.Windows.Forms;
using TorrentDotNet.HTTP;
using TorrentDotNet.Util;

// This is the code for your desktop app.
// Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.

namespace TorrentDotNet
{
    public partial class MainWindowViewer : Form
    {
        public MainWindowViewer()
        {
            InitializeComponent();
            treeView1.ExpandAll();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Click on the link below to continue learning how to build a desktop app using WinForms!
            System.Diagnostics.Process.Start("http://aka.ms/dotnet-get-started-desktop");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thanks!");
        }

        /*
        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Test");
        }
        */

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        // Menu Toolbar on Click Method
        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            //MessageBox.Show("Test2");
        }


        private void AddTorrentFileButton_Click(object sender, EventArgs e)
        {
            var openfile = new OpenFileDialog();
            openfile.Filter = "Torrent Files|*.torrent";
            openfile.Title = "Select Torrent File";
            openfile.ShowDialog();

            var parser = new BencodeParser();
            var torrent = parser.Parse<Torrent>(openfile.FileName);

            var addTorrent = new AddTorrentDialog();

            var drive = new DriveInfo("C");

            // Must Enter In the HTTP response into this field
            // this is my testing announce file created by manually conncting to the server via google chrome
            var test = parser.Parse<BDictionary>("C:\\Users\\jmaguy\\source\\repos\\Torrent.NET\\Torrent.NET\\bin\\Debug\\announce");

            
            
            // Formatting Labels
            ((Label)addTorrent.Controls["TorrentSizeLabel"]).Text = Formatter.BytesToEnglish(torrent.TotalSize) + " (Space Left on drive: " + Formatter.BytesToEnglish(drive.AvailableFreeSpace) + ")";
            ((Label)addTorrent.Controls["TorrentDateLabel"]).Text = torrent.CreationDate.ToString();
            ((Label)addTorrent.Controls["TorrentHashLabel"]).Text = Formatter.HashFormatter(torrent.GetInfoHash());
            ((Label)addTorrent.Controls["TorrentCommentLabel"]).Text = torrent.Comment;

            
            // Display Torrent Files in the AddTorrentMenu Window
            var listview = ((ListView)addTorrent.Controls["FilesList"]);
            var T = torrent.File;
            // Only One File Exists
            if (torrent.Files == null)
            {
                //var DataGrid = addTorrent.TorrentFilesView;

                //Insertion.InsertInDataGrid(addTorrent.TorrentFilesView, torrent.File);
                var item = new ListViewItem(new string[] { T.FileName, Formatter.BytesToEnglish(T.FileSize), "Normal" });
                //var test = item.SubItems;
                listview.Items.Add(item);
                item.Checked = true;
            }

            // Multiple Files in the torrent
            else
            {
                MultiFileInfoList files = torrent.Files;

                foreach (MultiFileInfo f in files)
                {
                    listview.Items.Add(new ListViewItem(new string[] { f.FileName, Formatter.BytesToEnglish(f.FileSize), "Normal" }));
                }
            }

            ((ComboBox)addTorrent.Controls["TorrentDirectory"]).Text = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);

            DialogResult result = addTorrent.ShowDialog();

            if (result == DialogResult.OK)
            {
                var row = new ListViewItem(new string[] { (MainWindowListView.Items.Count + 1).ToString(), T.FileName, Formatter.BytesToEnglish(T.FileSize) });
                MainWindowListView.Items.Add(row);
                row.Selected = true;
                var test2 = new Connection(torrent);
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void helloWorldLabel_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void toolStripContainer1_TopToolStripPanel_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void toolStripDropDownButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
