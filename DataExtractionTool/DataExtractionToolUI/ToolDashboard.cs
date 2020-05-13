using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataExtractionToolUI
{
    public partial class ToolDashboard : Form
    {
        public ToolDashboard()
        {
            InitializeComponent();
        }

        private void WireUpLists()
        {

        }

        private void FilePathTextBox_TextChanged(object sender, EventArgs e)
        {
            if (FilePathTextBox.Text != "" && (FilePathTextBox.Text.IndexOfAny(Path.GetInvalidPathChars()) == -1))
            {
                PopulateFilesSelectedListBox(FilesSelectedListBox, FilePathTextBox.Text, "*.xls"); 
            }
        }

        private void PopulateFilesSelectedListBox(ListBox filesSelectedListBox, string Folder, string FileType)
        {
            try
            {
                DirectoryInfo dInfo = new DirectoryInfo(Folder);
                FileInfo[] Files = dInfo.GetFiles(FileType);
                foreach (FileInfo file in Files)
                {
                    filesSelectedListBox.Items.Add(file);

                }

                filesSelectedListBox.DisplayMember = "Name";
            }
            catch (Exception ex)
            {

                MessageBox.Show("Invalid File Path Entered. Try again.");
            }
        }

        private void RemoveSelectedFilesButton_Click(object sender, EventArgs e)
        {
            FilesSelectedListBox.Items.Remove(FilesSelectedListBox.SelectedItem);
        }
    }
}
