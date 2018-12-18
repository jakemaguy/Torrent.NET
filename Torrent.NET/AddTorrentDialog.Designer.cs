namespace TorrentDotNet
{
    partial class AddTorrentDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.TorrentDirectory = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.TorrentSizeLabel = new System.Windows.Forms.Label();
            this.TorrentDateLabel = new System.Windows.Forms.Label();
            this.TorrentHashLabel = new System.Windows.Forms.Label();
            this.TorrentCommentLabel = new System.Windows.Forms.Label();
            this.StartTorrentCheckBox = new System.Windows.Forms.CheckBox();
            this.SkipHashCheckBox = new System.Windows.Forms.CheckBox();
            this.CreateSubfolderCheckBox = new System.Windows.Forms.CheckBox();
            this.SeqDownloadCheckBox = new System.Windows.Forms.CheckBox();
            this.FirstLastCheckBox = new System.Windows.Forms.CheckBox();
            this.AddTorrentOKButton = new System.Windows.Forms.Button();
            this.AddTorrentCancelButton = new System.Windows.Forms.Button();
            this.FileName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FileSize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DownloadPriority = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FilesList = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Save Torrent At:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // TorrentDirectory
            // 
            this.TorrentDirectory.FormattingEnabled = true;
            this.TorrentDirectory.Location = new System.Drawing.Point(34, 44);
            this.TorrentDirectory.Name = "TorrentDirectory";
            this.TorrentDirectory.Size = new System.Drawing.Size(772, 27);
            this.TorrentDirectory.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(812, 44);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(62, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Browse";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Torrent Settings";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(391, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Category:";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(453, 118);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(421, 27);
            this.comboBox2.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 255);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "Torrent Information";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 268);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.label5.Size = new System.Drawing.Size(35, 29);
            this.label5.TabIndex = 8;
            this.label5.Text = "Size:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 291);
            this.label6.Name = "label6";
            this.label6.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.label6.Size = new System.Drawing.Size(41, 24);
            this.label6.TabIndex = 9;
            this.label6.Text = "Date:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(31, 309);
            this.label7.Name = "label7";
            this.label7.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.label7.Size = new System.Drawing.Size(43, 24);
            this.label7.TabIndex = 10;
            this.label7.Text = "Hash:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(31, 327);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 19);
            this.label8.TabIndex = 11;
            this.label8.Text = "Comment:";
            // 
            // TorrentSizeLabel
            // 
            this.TorrentSizeLabel.AutoSize = true;
            this.TorrentSizeLabel.Location = new System.Drawing.Point(110, 273);
            this.TorrentSizeLabel.Name = "TorrentSizeLabel";
            this.TorrentSizeLabel.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.TorrentSizeLabel.Size = new System.Drawing.Size(0, 24);
            this.TorrentSizeLabel.TabIndex = 12;
            // 
            // TorrentDateLabel
            // 
            this.TorrentDateLabel.AutoSize = true;
            this.TorrentDateLabel.Location = new System.Drawing.Point(110, 291);
            this.TorrentDateLabel.Name = "TorrentDateLabel";
            this.TorrentDateLabel.Size = new System.Drawing.Size(0, 19);
            this.TorrentDateLabel.TabIndex = 13;
            // 
            // TorrentHashLabel
            // 
            this.TorrentHashLabel.AutoSize = true;
            this.TorrentHashLabel.Location = new System.Drawing.Point(110, 309);
            this.TorrentHashLabel.Name = "TorrentHashLabel";
            this.TorrentHashLabel.Size = new System.Drawing.Size(0, 19);
            this.TorrentHashLabel.TabIndex = 14;
            // 
            // TorrentCommentLabel
            // 
            this.TorrentCommentLabel.AutoSize = true;
            this.TorrentCommentLabel.Location = new System.Drawing.Point(110, 327);
            this.TorrentCommentLabel.Name = "TorrentCommentLabel";
            this.TorrentCommentLabel.Size = new System.Drawing.Size(0, 19);
            this.TorrentCommentLabel.TabIndex = 15;
            // 
            // StartTorrentCheckBox
            // 
            this.StartTorrentCheckBox.AutoSize = true;
            this.StartTorrentCheckBox.Checked = true;
            this.StartTorrentCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.StartTorrentCheckBox.Location = new System.Drawing.Point(34, 117);
            this.StartTorrentCheckBox.Name = "StartTorrentCheckBox";
            this.StartTorrentCheckBox.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.StartTorrentCheckBox.Size = new System.Drawing.Size(108, 28);
            this.StartTorrentCheckBox.TabIndex = 17;
            this.StartTorrentCheckBox.Text = "Start Torrent";
            this.StartTorrentCheckBox.UseVisualStyleBackColor = true;
            // 
            // SkipHashCheckBox
            // 
            this.SkipHashCheckBox.AutoSize = true;
            this.SkipHashCheckBox.Location = new System.Drawing.Point(34, 145);
            this.SkipHashCheckBox.Name = "SkipHashCheckBox";
            this.SkipHashCheckBox.Size = new System.Drawing.Size(132, 23);
            this.SkipHashCheckBox.TabIndex = 18;
            this.SkipHashCheckBox.Text = "Skip Hash Check";
            this.SkipHashCheckBox.UseVisualStyleBackColor = true;
            // 
            // CreateSubfolderCheckBox
            // 
            this.CreateSubfolderCheckBox.AutoSize = true;
            this.CreateSubfolderCheckBox.Checked = true;
            this.CreateSubfolderCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CreateSubfolderCheckBox.Location = new System.Drawing.Point(34, 168);
            this.CreateSubfolderCheckBox.Name = "CreateSubfolderCheckBox";
            this.CreateSubfolderCheckBox.Size = new System.Drawing.Size(133, 23);
            this.CreateSubfolderCheckBox.TabIndex = 19;
            this.CreateSubfolderCheckBox.Text = "Create Subfolder";
            this.CreateSubfolderCheckBox.UseVisualStyleBackColor = true;
            // 
            // SeqDownloadCheckBox
            // 
            this.SeqDownloadCheckBox.AutoSize = true;
            this.SeqDownloadCheckBox.Location = new System.Drawing.Point(34, 191);
            this.SeqDownloadCheckBox.Name = "SeqDownloadCheckBox";
            this.SeqDownloadCheckBox.Size = new System.Drawing.Size(160, 23);
            this.SeqDownloadCheckBox.TabIndex = 20;
            this.SeqDownloadCheckBox.Text = "Sequential Download";
            this.SeqDownloadCheckBox.UseVisualStyleBackColor = true;
            // 
            // FirstLastCheckBox
            // 
            this.FirstLastCheckBox.AutoSize = true;
            this.FirstLastCheckBox.Location = new System.Drawing.Point(34, 214);
            this.FirstLastCheckBox.Name = "FirstLastCheckBox";
            this.FirstLastCheckBox.Size = new System.Drawing.Size(250, 23);
            this.FirstLastCheckBox.TabIndex = 21;
            this.FirstLastCheckBox.Text = "Download First and Last Pieces First";
            this.FirstLastCheckBox.UseVisualStyleBackColor = true;
            // 
            // AddTorrentOKButton
            // 
            this.AddTorrentOKButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.AddTorrentOKButton.Location = new System.Drawing.Point(718, 795);
            this.AddTorrentOKButton.Name = "AddTorrentOKButton";
            this.AddTorrentOKButton.Size = new System.Drawing.Size(75, 37);
            this.AddTorrentOKButton.TabIndex = 22;
            this.AddTorrentOKButton.Text = "OK";
            this.AddTorrentOKButton.UseVisualStyleBackColor = true;
            // 
            // AddTorrentCancelButton
            // 
            this.AddTorrentCancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.AddTorrentCancelButton.Location = new System.Drawing.Point(799, 795);
            this.AddTorrentCancelButton.Name = "AddTorrentCancelButton";
            this.AddTorrentCancelButton.Size = new System.Drawing.Size(75, 37);
            this.AddTorrentCancelButton.TabIndex = 23;
            this.AddTorrentCancelButton.Text = "Cancel";
            this.AddTorrentCancelButton.UseVisualStyleBackColor = true;
            this.AddTorrentCancelButton.Click += new System.EventHandler(this.AddTorrentCancelButton_Click);
            // 
            // FileName
            // 
            this.FileName.Text = "Name";
            this.FileName.Width = 240;
            // 
            // FileSize
            // 
            this.FileSize.Text = "Size";
            this.FileSize.Width = 94;
            // 
            // DownloadPriority
            // 
            this.DownloadPriority.Text = "Download Priority";
            this.DownloadPriority.Width = 143;
            // 
            // FilesList
            // 
            this.FilesList.CheckBoxes = true;
            this.FilesList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.FileName,
            this.FileSize,
            this.DownloadPriority});
            this.FilesList.Location = new System.Drawing.Point(34, 364);
            this.FilesList.Name = "FilesList";
            this.FilesList.Size = new System.Drawing.Size(840, 425);
            this.FilesList.TabIndex = 16;
            this.FilesList.UseCompatibleStateImageBehavior = false;
            this.FilesList.View = System.Windows.Forms.View.Details;
            // 
            // AddTorrentDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 844);
            this.Controls.Add(this.AddTorrentCancelButton);
            this.Controls.Add(this.AddTorrentOKButton);
            this.Controls.Add(this.FirstLastCheckBox);
            this.Controls.Add(this.SeqDownloadCheckBox);
            this.Controls.Add(this.CreateSubfolderCheckBox);
            this.Controls.Add(this.SkipHashCheckBox);
            this.Controls.Add(this.StartTorrentCheckBox);
            this.Controls.Add(this.FilesList);
            this.Controls.Add(this.TorrentCommentLabel);
            this.Controls.Add(this.TorrentHashLabel);
            this.Controls.Add(this.TorrentDateLabel);
            this.Controls.Add(this.TorrentSizeLabel);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TorrentDirectory);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "AddTorrentDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox TorrentDirectory;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label TorrentSizeLabel;
        private System.Windows.Forms.Label TorrentDateLabel;
        private System.Windows.Forms.Label TorrentHashLabel;
        private System.Windows.Forms.Label TorrentCommentLabel;
        private System.Windows.Forms.CheckBox StartTorrentCheckBox;
        private System.Windows.Forms.CheckBox SkipHashCheckBox;
        private System.Windows.Forms.CheckBox CreateSubfolderCheckBox;
        private System.Windows.Forms.CheckBox SeqDownloadCheckBox;
        private System.Windows.Forms.CheckBox FirstLastCheckBox;
        private System.Windows.Forms.Button AddTorrentOKButton;
        private System.Windows.Forms.Button AddTorrentCancelButton;
        private System.Windows.Forms.ColumnHeader FileName;
        private System.Windows.Forms.ColumnHeader FileSize;
        private System.Windows.Forms.ColumnHeader DownloadPriority;
        private System.Windows.Forms.ListView FilesList;
    }
}