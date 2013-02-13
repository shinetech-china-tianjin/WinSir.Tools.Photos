using System;
using System.IO;
using System.Windows.Forms;
using WinSir.Tools.Photos.Shell.Properties;

namespace WinSir.Tools.Photos.Shell
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            InitialFolder(txtSourceFolder);
            InitialFolder(txtDestinationFolder);
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            var button = sender as Button;
            if (button == null) return;

            if (button.Name == btnBrowseSource.Name)
            {
                BrowseFolder(txtSourceFolder);
            }
            else if(button.Name == btnBrowseDestination.Name)
            {
                BrowseFolder(txtDestinationFolder);
            }
        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            if (!InitialFolder(txtSourceFolder, true) || !InitialFolder(txtDestinationFolder, true))
                return;

            btnExecute.Enabled = false;

            var renamer = new RenamedByExif
                {
                    SourceFolder = txtSourceFolder.Text,
                    DestinantionFolder = txtDestinationFolder.Text
                };
            renamer.Execute();

            var classifier = new ClassifiedByDate { Folder = txtDestinationFolder.Text };
            classifier.Execute();

            MessageBox.Show("Done!");

            btnExecute.Enabled = true;
        }

        private bool InitialFolder(Control textBox, bool showDialog = false)
        {
            var folder = textBox.Text;
            if (!string.IsNullOrEmpty(folder) && Directory.Exists(folder))
            {
                if (textBox.Name == txtSourceFolder.Name)
                {
                    Settings.Default.SourceFolder = folder;
                }
                else if (textBox.Name == txtDestinationFolder.Name)
                {
                    Settings.Default.DestinationFolder = folder;
                }
                Settings.Default.Save();
                return true;
            }

            if (textBox.Name == txtSourceFolder.Name)
            {
                folder = Settings.Default.SourceFolder;
            }
            else if (textBox.Name == txtDestinationFolder.Name)
            {
                folder = Settings.Default.DestinationFolder;
            }
            if (!string.IsNullOrEmpty(folder) && Directory.Exists(folder))
            {
                textBox.Text = folder;
                return true;
            }

            return !showDialog || BrowseFolder(textBox);
        }

        private bool BrowseFolder(Control textBox)
        {
            string description = null;
            if (textBox.Name == txtSourceFolder.Name)
            {
                description = @"Select the source folder";
            }
            else if (textBox.Name == txtDestinationFolder.Name)
            {
                description = @"Select the destination folder";
            }
            var dlg = new FolderBrowserDialog
            {
                ShowNewFolderButton = true,
                Description = description,
            };
            if (dlg.ShowDialog() != DialogResult.OK) return false;
            var folder = dlg.SelectedPath;
            textBox.Text = folder;
            if (textBox.Name == txtSourceFolder.Name)
            {
                Settings.Default.SourceFolder = folder;
            }
            else if (textBox.Name == txtDestinationFolder.Name)
            {
                Settings.Default.DestinationFolder = folder;
            }
            Settings.Default.Save();
            return true;
        }
    }
}
