namespace FileHandler
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtSystemDetail = new TextBox();
            cboSystemDrives = new ComboBox();
            lblNewDirectory = new Label();
            txtNewDirectory = new TextBox();
            btnCreateDirectory = new Button();
            btnSubDirectory = new Button();
            txtNewSubDirectory = new TextBox();
            lblSubDirectory = new Label();
            lblShowDirectory = new Label();
            cboDirectoryFiles = new ComboBox();
            btnShowDirectoryFiles = new Button();
            panel1 = new Panel();
            btnCopyDirectory = new Button();
            txtCopyDirectoryDestination = new TextBox();
            txtCopyDirectorySource = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnNewFile = new Button();
            txtNewFile = new TextBox();
            label4 = new Label();
            btnOpenFile = new Button();
            txtSelectFile = new TextBox();
            label5 = new Label();
            openFileDialog1 = new OpenFileDialog();
            btnRenameFile = new Button();
            txtRenameFile = new TextBox();
            label6 = new Label();
            txtWrite = new TextBox();
            label7 = new Label();
            btnWrite = new Button();
            btnRead = new Button();
            label8 = new Label();
            txtRead = new TextBox();
            btnSearch = new Button();
            label9 = new Label();
            txtFind = new TextBox();
            btnUpdate = new Button();
            label10 = new Label();
            txtUpdate = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // txtSystemDetail
            // 
            txtSystemDetail.Location = new Point(74, 101);
            txtSystemDetail.Multiline = true;
            txtSystemDetail.Name = "txtSystemDetail";
            txtSystemDetail.Size = new Size(335, 386);
            txtSystemDetail.TabIndex = 0;
            // 
            // cboSystemDrives
            // 
            cboSystemDrives.FormattingEnabled = true;
            cboSystemDrives.Location = new Point(74, 42);
            cboSystemDrives.Name = "cboSystemDrives";
            cboSystemDrives.Size = new Size(332, 28);
            cboSystemDrives.TabIndex = 1;
            cboSystemDrives.SelectedIndexChanged += cboSystemDrives_SelectedIndexChanged;
            // 
            // lblNewDirectory
            // 
            lblNewDirectory.AutoSize = true;
            lblNewDirectory.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblNewDirectory.Location = new Point(534, 41);
            lblNewDirectory.Name = "lblNewDirectory";
            lblNewDirectory.Size = new Size(213, 20);
            lblNewDirectory.TabIndex = 2;
            lblNewDirectory.Text = "New Directory (include path)";
            lblNewDirectory.Click += label1_Click;
            // 
            // txtNewDirectory
            // 
            txtNewDirectory.Location = new Point(753, 38);
            txtNewDirectory.Name = "txtNewDirectory";
            txtNewDirectory.Size = new Size(200, 27);
            txtNewDirectory.TabIndex = 3;
            // 
            // btnCreateDirectory
            // 
            btnCreateDirectory.Location = new Point(970, 41);
            btnCreateDirectory.Name = "btnCreateDirectory";
            btnCreateDirectory.Size = new Size(176, 29);
            btnCreateDirectory.TabIndex = 4;
            btnCreateDirectory.Text = "Create Directory";
            btnCreateDirectory.UseVisualStyleBackColor = true;
            btnCreateDirectory.Click += button1_Click;
            // 
            // btnSubDirectory
            // 
            btnSubDirectory.Location = new Point(970, 97);
            btnSubDirectory.Name = "btnSubDirectory";
            btnSubDirectory.Size = new Size(176, 29);
            btnSubDirectory.TabIndex = 7;
            btnSubDirectory.Text = "Create SubDirectory";
            btnSubDirectory.UseVisualStyleBackColor = true;
            btnSubDirectory.Click += btnSubDirectory_Click;
            // 
            // txtNewSubDirectory
            // 
            txtNewSubDirectory.Location = new Point(753, 98);
            txtNewSubDirectory.Name = "txtNewSubDirectory";
            txtNewSubDirectory.Size = new Size(200, 27);
            txtNewSubDirectory.TabIndex = 6;
            // 
            // lblSubDirectory
            // 
            lblSubDirectory.AutoSize = true;
            lblSubDirectory.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblSubDirectory.Location = new Point(534, 101);
            lblSubDirectory.Name = "lblSubDirectory";
            lblSubDirectory.Size = new Size(137, 20);
            lblSubDirectory.TabIndex = 5;
            lblSubDirectory.Text = "New SubDirectory";
            // 
            // lblShowDirectory
            // 
            lblShowDirectory.AutoSize = true;
            lblShowDirectory.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblShowDirectory.Location = new Point(534, 158);
            lblShowDirectory.Name = "lblShowDirectory";
            lblShowDirectory.Size = new Size(169, 20);
            lblShowDirectory.TabIndex = 8;
            lblShowDirectory.Text = "Show Directory Details";
            // 
            // cboDirectoryFiles
            // 
            cboDirectoryFiles.FormattingEnabled = true;
            cboDirectoryFiles.Location = new Point(753, 150);
            cboDirectoryFiles.Name = "cboDirectoryFiles";
            cboDirectoryFiles.Size = new Size(200, 28);
            cboDirectoryFiles.TabIndex = 9;
            // 
            // btnShowDirectoryFiles
            // 
            btnShowDirectoryFiles.Location = new Point(970, 149);
            btnShowDirectoryFiles.Name = "btnShowDirectoryFiles";
            btnShowDirectoryFiles.Size = new Size(176, 29);
            btnShowDirectoryFiles.TabIndex = 10;
            btnShowDirectoryFiles.Text = "Show Directory Files";
            btnShowDirectoryFiles.UseVisualStyleBackColor = true;
            btnShowDirectoryFiles.Click += btnShowDirectoryFiles_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnCopyDirectory);
            panel1.Controls.Add(txtCopyDirectoryDestination);
            panel1.Controls.Add(txtCopyDirectorySource);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(534, 204);
            panel1.Name = "panel1";
            panel1.Size = new Size(610, 171);
            panel1.TabIndex = 11;
            // 
            // btnCopyDirectory
            // 
            btnCopyDirectory.Location = new Point(453, 18);
            btnCopyDirectory.Name = "btnCopyDirectory";
            btnCopyDirectory.Size = new Size(129, 41);
            btnCopyDirectory.TabIndex = 5;
            btnCopyDirectory.Text = "Copy";
            btnCopyDirectory.UseVisualStyleBackColor = true;
            btnCopyDirectory.Click += btnCopyDirectory_Click;
            // 
            // txtCopyDirectoryDestination
            // 
            txtCopyDirectoryDestination.Location = new Point(162, 111);
            txtCopyDirectoryDestination.Name = "txtCopyDirectoryDestination";
            txtCopyDirectoryDestination.Size = new Size(420, 27);
            txtCopyDirectoryDestination.TabIndex = 4;
            // 
            // txtCopyDirectorySource
            // 
            txtCopyDirectorySource.Location = new Point(162, 65);
            txtCopyDirectorySource.Name = "txtCopyDirectorySource";
            txtCopyDirectorySource.Size = new Size(420, 27);
            txtCopyDirectorySource.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 114);
            label3.Name = "label3";
            label3.Size = new Size(85, 20);
            label3.TabIndex = 2;
            label3.Text = "Destination";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 68);
            label2.Name = "label2";
            label2.Size = new Size(54, 20);
            label2.TabIndex = 1;
            label2.Text = "Source";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 18);
            label1.Name = "label1";
            label1.Size = new Size(106, 20);
            label1.TabIndex = 0;
            label1.Text = "Copy directory";
            // 
            // btnNewFile
            // 
            btnNewFile.Location = new Point(970, 399);
            btnNewFile.Name = "btnNewFile";
            btnNewFile.Size = new Size(176, 29);
            btnNewFile.TabIndex = 14;
            btnNewFile.Text = "Create File";
            btnNewFile.UseVisualStyleBackColor = true;
            btnNewFile.Click += btnNewFile_Click;
            // 
            // txtNewFile
            // 
            txtNewFile.Location = new Point(753, 396);
            txtNewFile.Name = "txtNewFile";
            txtNewFile.Size = new Size(200, 27);
            txtNewFile.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(534, 399);
            label4.Name = "label4";
            label4.Size = new Size(171, 20);
            label4.TabIndex = 12;
            label4.Text = "New File (include path)";
            // 
            // btnOpenFile
            // 
            btnOpenFile.Location = new Point(970, 432);
            btnOpenFile.Name = "btnOpenFile";
            btnOpenFile.Size = new Size(176, 29);
            btnOpenFile.TabIndex = 17;
            btnOpenFile.Text = "Open";
            btnOpenFile.UseVisualStyleBackColor = true;
            btnOpenFile.Click += btnOpenFile_Click;
            // 
            // txtSelectFile
            // 
            txtSelectFile.Location = new Point(753, 429);
            txtSelectFile.Name = "txtSelectFile";
            txtSelectFile.Size = new Size(200, 27);
            txtSelectFile.TabIndex = 16;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(534, 432);
            label5.Name = "label5";
            label5.Size = new Size(82, 20);
            label5.TabIndex = 15;
            label5.Text = "Select File ";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnRenameFile
            // 
            btnRenameFile.Location = new Point(970, 467);
            btnRenameFile.Name = "btnRenameFile";
            btnRenameFile.Size = new Size(176, 29);
            btnRenameFile.TabIndex = 20;
            btnRenameFile.Text = "Rename";
            btnRenameFile.UseVisualStyleBackColor = true;
            btnRenameFile.Click += btnRenameFile_Click;
            // 
            // txtRenameFile
            // 
            txtRenameFile.Location = new Point(753, 464);
            txtRenameFile.Name = "txtRenameFile";
            txtRenameFile.Size = new Size(200, 27);
            txtRenameFile.TabIndex = 19;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(534, 467);
            label6.Name = "label6";
            label6.Size = new Size(66, 20);
            label6.TabIndex = 18;
            label6.Text = "Rename";
            // 
            // txtWrite
            // 
            txtWrite.Location = new Point(17, 589);
            txtWrite.Multiline = true;
            txtWrite.Name = "txtWrite";
            txtWrite.Size = new Size(268, 264);
            txtWrite.TabIndex = 21;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(111, 566);
            label7.Name = "label7";
            label7.Size = new Size(48, 20);
            label7.TabIndex = 22;
            label7.Text = "Write";
            // 
            // btnWrite
            // 
            btnWrite.Location = new Point(58, 859);
            btnWrite.Name = "btnWrite";
            btnWrite.Size = new Size(176, 29);
            btnWrite.TabIndex = 23;
            btnWrite.Text = "Write";
            btnWrite.UseVisualStyleBackColor = true;
            btnWrite.Click += btnWrite_Click;
            // 
            // btnRead
            // 
            btnRead.Location = new Point(349, 859);
            btnRead.Name = "btnRead";
            btnRead.Size = new Size(176, 29);
            btnRead.TabIndex = 26;
            btnRead.Text = "Read";
            btnRead.UseVisualStyleBackColor = true;
            btnRead.Click += btnRead_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(402, 566);
            label8.Name = "label8";
            label8.Size = new Size(44, 20);
            label8.TabIndex = 25;
            label8.Text = "Read";
            // 
            // txtRead
            // 
            txtRead.Location = new Point(308, 589);
            txtRead.Multiline = true;
            txtRead.Name = "txtRead";
            txtRead.Size = new Size(268, 264);
            txtRead.TabIndex = 24;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(635, 859);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(176, 29);
            btnSearch.TabIndex = 29;
            btnSearch.Text = "Find";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(688, 566);
            label9.Name = "label9";
            label9.Size = new Size(39, 20);
            label9.TabIndex = 28;
            label9.Text = "Find";
            // 
            // txtFind
            // 
            txtFind.Location = new Point(594, 589);
            txtFind.Multiline = true;
            txtFind.Name = "txtFind";
            txtFind.Size = new Size(268, 264);
            txtFind.TabIndex = 27;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(919, 859);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(176, 29);
            btnUpdate.TabIndex = 32;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(972, 566);
            label10.Name = "label10";
            label10.Size = new Size(60, 20);
            label10.TabIndex = 31;
            label10.Text = "Update";
            // 
            // txtUpdate
            // 
            txtUpdate.Location = new Point(878, 589);
            txtUpdate.Multiline = true;
            txtUpdate.Name = "txtUpdate";
            txtUpdate.Size = new Size(268, 264);
            txtUpdate.TabIndex = 30;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1170, 934);
            Controls.Add(btnUpdate);
            Controls.Add(label10);
            Controls.Add(txtUpdate);
            Controls.Add(btnSearch);
            Controls.Add(label9);
            Controls.Add(txtFind);
            Controls.Add(btnRead);
            Controls.Add(label8);
            Controls.Add(txtRead);
            Controls.Add(btnWrite);
            Controls.Add(label7);
            Controls.Add(txtWrite);
            Controls.Add(btnRenameFile);
            Controls.Add(txtRenameFile);
            Controls.Add(label6);
            Controls.Add(btnOpenFile);
            Controls.Add(txtSelectFile);
            Controls.Add(label5);
            Controls.Add(btnNewFile);
            Controls.Add(txtNewFile);
            Controls.Add(label4);
            Controls.Add(panel1);
            Controls.Add(btnShowDirectoryFiles);
            Controls.Add(cboDirectoryFiles);
            Controls.Add(lblShowDirectory);
            Controls.Add(btnSubDirectory);
            Controls.Add(txtNewSubDirectory);
            Controls.Add(lblSubDirectory);
            Controls.Add(btnCreateDirectory);
            Controls.Add(txtNewDirectory);
            Controls.Add(lblNewDirectory);
            Controls.Add(cboSystemDrives);
            Controls.Add(txtSystemDetail);
            Name = "Form1";
            Text = "FileHandler";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtSystemDetail;
        private ComboBox cboSystemDrives;
        private Label lblNewDirectory;
        private TextBox txtNewDirectory;
        private Button btnCreateDirectory;
        private Button btnSubDirectory;
        private TextBox txtNewSubDirectory;
        private Label lblSubDirectory;
        private Label lblShowDirectory;
        private ComboBox cboDirectoryFiles;
        private Button btnShowDirectoryFiles;
        private Panel panel1;
        private Label label1;
        private Button btnCopyDirectory;
        private TextBox txtCopyDirectoryDestination;
        private TextBox txtCopyDirectorySource;
        private Label label3;
        private Label label2;
        private Button btnNewFile;
        private TextBox txtNewFile;
        private Label label4;
        private Button btnOpenFile;
        private TextBox txtSelectFile;
        private Label label5;
        private OpenFileDialog openFileDialog1;
        private Button btnRenameFile;
        private TextBox txtRenameFile;
        private Label label6;
        private TextBox txtWrite;
        private Label label7;
        private Button btnWrite;
        private Button btnRead;
        private Label label8;
        private TextBox txtRead;
        private Button btnSearch;
        private Label label9;
        private TextBox txtFind;
        private Button btnUpdate;
        private Label label10;
        private TextBox txtUpdate;
    }
}