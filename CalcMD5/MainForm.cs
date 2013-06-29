using System;
using System.Windows.Forms;
using System.IO;

namespace CalcMD5
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.DragEnter += onDragEnter;
            this.DragDrop += onDragDrop;
            FileNameTextBox.DragEnter += onDragEnter;
            FileNameTextBox.DragDrop += onDragDrop;
        }

        private void setFileNameText(String filename)
        {
            FileNameTextBox.Text = filename;
            MD5HashTextBox.Clear();
        }

        private void onDragDrop(object sender, DragEventArgs e)
        {
            string[] filenames = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            if (filenames.Length > 0)
            {
                setFileNameText(filenames[0]);
            }
        }

        private void onDragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void FileSelectButton_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                setFileNameText(openFileDialog.FileName);
            }
        }

        private void ComputeMD5Button_Click(object sender, EventArgs e)
        {
            var filename = FileNameTextBox.Text;
            if (filename.Length == 0)
            {
                MessageBox.Show("Select a file to compute MD5.", "Error");
                return;
            }
            if (!File.Exists(filename))
            {
                MessageBox.Show(String.Format("File \"{0}\" does not exist.", filename), "Error");
                return;
            }

            MD5HashTextBox.Text = CalcMD5Service.GetMD5Hash(filename);
        }
    }
}
