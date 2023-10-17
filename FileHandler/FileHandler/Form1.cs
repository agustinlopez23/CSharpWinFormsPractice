using System.CodeDom;
using System.Linq.Expressions;

namespace FileHandler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            PopulateSystemDrives();
        }
        private void PopulateSystemDrives()
        {
            try
            {
                var drives = Directory.GetLogicalDrives();
                foreach (var drive in drives)
                {
                    cboSystemDrives.Items.Add(drive);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void cboSystemDrives_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var disk = cboSystemDrives.SelectedItem.ToString();
                DriveInfo diskInfo = new DriveInfo(disk);
                var driveDetails = $@"Drive: {disk} drive 
                                Total size {diskInfo.TotalSize} 
                                Free avalaible space:{diskInfo.AvailableFreeSpace}
                                Format:{diskInfo.DriveFormat}
                                Type:{diskInfo.DriveType}";
                txtSystemDetail.Text = driveDetails;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtNewDirectory.Text))
                    throw new Exception("Please insert a path for a directory");
                if (!Directory.Exists(txtNewDirectory.Text))
                {
                    Directory.CreateDirectory(txtNewDirectory.Text);
                    MessageBox.Show("Directory Created");
                }
                else
                {
                    MessageBox.Show("Please, enter the full path pf the new directory");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSubDirectory_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtNewDirectory.Text))
                    throw new Exception("Make shure you have included a directory path on New Directory");
                if (string.IsNullOrEmpty(txtNewSubDirectory.Text))
                    throw new Exception("Make shure you have included a directory path on New SubDirectory");
                var directoryPath = txtNewDirectory.Text;
                var subDirInfo = new DirectoryInfo(directoryPath);
                subDirInfo.CreateSubdirectory(txtNewSubDirectory.Text);
                MessageBox.Show("Subdirectory has been created.");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnShowDirectoryFiles_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtNewDirectory.Text))
                    throw new Exception("Make shure you have included a directory path on New Directory");

                var directory = txtNewDirectory.Text;
                var directoryInfo = new DirectoryInfo(directory);
                if (!directoryInfo.Exists)
                {
                    throw new Exception("Directory doesnt exists!");
                }
                var subDirectories = directoryInfo.GetDirectories();
                foreach (var subDirectory in subDirectories)
                {
                    if (!cboDirectoryFiles.Items
                        .Contains(subDirectory.Name))
                        cboDirectoryFiles.Items.Add(subDirectory.Name);
                }
                var files = directoryInfo.GetFiles("*");
                foreach (var file in files)
                {
                    if (!cboDirectoryFiles.Items.Contains(file.Name))
                        cboDirectoryFiles.Items.Add(file.Name);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }




        private void btnCopyDirectory_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCopyDirectorySource.Text) || string.IsNullOrEmpty(txtCopyDirectoryDestination.Text)) throw new Exception("Source and destination fields should have values");

            var source = new DirectoryInfo(txtCopyDirectorySource.Text);
            var destination = new DirectoryInfo(txtCopyDirectoryDestination.Text);
            CopyDirectory(source, destination);
            try
            {

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        private void CopyDirectory(DirectoryInfo source, DirectoryInfo destination)
        {
            try
            {
                if (!source.Exists)
                    throw new Exception("Source directory doenst exits!");

                if (!destination.Exists)
                    destination.Create();

                var files = source.GetFiles();
                foreach (var item in files)
                {
                    item.CopyTo(Path.Combine(destination.FullName, item.Name));
                }
                var directories = source.GetDirectories();
                foreach (var directory in directories)
                {
                    string dest = Path.Combine(destination.FullName, directory.Name);
                    CopyDirectory(directory, new DirectoryInfo(dest));
                }
                MessageBox.Show("Directory Copy Successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }

        private void btnNewFile_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtNewFile.Text))
                    throw new Exception("Make sure you have included a path for the new file");

                if (!File.Exists(txtNewFile.Text))
                {
                    File.Create(txtNewFile.Text);
                    MessageBox.Show("File created");
                }
                else if (File.Exists(txtNewFile.Text))
                {
                    MessageBox.Show("The File already exists. Change the name for the new file");
                }
                else
                {
                    MessageBox.Show("Include the full path of the file");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    txtSelectFile.Text = openFileDialog1.FileName;
                    txtRenameFile.Text = openFileDialog1.FileName;
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnRenameFile_Click(object sender, EventArgs e)
        {
            try
            {
                var source = txtSelectFile.Text;
                var destination = txtRenameFile.Text;
                var sourceFileInfo = new FileInfo(source);
                if (sourceFileInfo.Exists)
                {
                    sourceFileInfo.MoveTo(destination);
                    MessageBox.Show("The file has been renamed");
                }
                else
                {
                    MessageBox.Show("Error when trying to rename the file. Is path Correct?");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtSelectFile.Text))
                    throw new Exception("Make shure you selected a file..");
                if (!File.Exists(txtSelectFile.Text))
                    throw new Exception("Selected File doesnt exits...");

                FileStream fs = new FileStream(txtSelectFile.Text, FileMode.Create, FileAccess.Write);
                StreamWriter sw = new StreamWriter(fs);

                sw.WriteLine(txtWrite.Text);
                sw.Flush();
                fs.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtSelectFile.Text))
                    throw new Exception("Make shure you selected a file..");
                if (!File.Exists(txtSelectFile.Text))
                    throw new Exception("Selected File doesnt exits...");

                FileStream fs = new FileStream(txtSelectFile.Text, FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs);

                txtRead.Text = sr.ReadToEnd();
                fs.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtSelectFile.Text))
                    throw new Exception("Make shure you selected a file..");
                if (!File.Exists(txtSelectFile.Text))
                    throw new Exception("Selected File doesnt exits...");

                FileStream fs = new FileStream(txtSelectFile.Text, FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs);

                var content = sr.ReadToEnd();
                int i = content.IndexOf(txtFind.Text.Trim(), 0);
                if (i > -1)
                    MessageBox.Show("The string is present in the file.");
                else
                    MessageBox.Show("The string wasnt found in the file.");
                fs.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtSelectFile.Text))
                    throw new Exception("Make shure you selected a file..");
                if (!File.Exists(txtSelectFile.Text))
                    throw new Exception("Selected File doesnt exits...");

                FileStream fs = new FileStream(txtSelectFile.Text, FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs);

                var path = txtSelectFile.Text;
                var sw = File.AppendText(path);
                sw.WriteLine(txtSelectFile.Text);
                fs.Close();
                MessageBox.Show("File contents appended successfully");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }

}