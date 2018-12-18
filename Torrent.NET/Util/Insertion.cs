using BencodeNET.Torrents;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TorrentDotNet.Util
{
    public static class Insertion
    {
        public static void InsertInDataGrid(DataGridView grid, SingleFileInfo torrent, MultiFileInfoList torrents = null)
        {
            var column = ((DataGridViewComboBoxColumn)grid.Columns[2]);
            grid.Rows.Add(new object[] { torrent.FileName, Formatter.BytesToEnglish(torrent.FileSize), "Normal"});

            var cell = (DataGridViewComboBoxCell)grid.Rows[0].Cells[2];
            // var test = grid;
           
            //column.DisplayStyle = DataGridViewComboBoxDisplayStyle.ComboBox;
            //column.Items.AddRange(new string[] { "Normal", "High", "Maximum" });
            //column.MaxDropDownItems = 3;
            /*
            grid.DefaultCellStyle.SelectionBackColor = Color.White;
            grid.DefaultCellStyle.SelectionForeColor = Color.Black;
            */
        }
    }
}
