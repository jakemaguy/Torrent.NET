using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TorrentDotNet
{
    public partial class AddTorrentDialog : Form
    {
        public AddTorrentDialog()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var folder = new FolderBrowserDialog();
            folder.Description = "Select Where To Save Torrent Files";
            DialogResult result = folder.ShowDialog();
            if (folder.SelectedPath != null && result == DialogResult.OK)
                TorrentDirectory.Text = folder.SelectedPath;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void AddTorrentCancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TorrentFilesView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2)
                MessageBox.Show("Test");

        }

        /*
        private void TorrentFilesView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            if (e.Exception.Message.Equals("DataGridViewComboBoxCell value is not valid."))
            {
                object value = TorrentFilesView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                if(!((DataGridViewComboBoxColumn)TorrentFilesView.Columns[e.ColumnIndex]).Items.Contains(value))
                {
                    ((DataGridViewComboBoxColumn)TorrentFilesView.Columns[e.ColumnIndex]).Items.Add(value);
                    e.ThrowException = false;
                }
            }
        }
        */
    }
}
