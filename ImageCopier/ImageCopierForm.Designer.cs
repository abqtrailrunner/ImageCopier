namespace ImageCopier
{
    partial class ImageCopierForm
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
            this.mSourceButton = new System.Windows.Forms.Button();
            this.mSelectedSourceFolder = new System.Windows.Forms.TextBox();
            this.mFolderBrowse = new System.Windows.Forms.FolderBrowserDialog();
            this.mSelectedDestinationFolder = new System.Windows.Forms.TextBox();
            this.mDestinationButton = new System.Windows.Forms.Button();
            this.mFindFilesButton = new System.Windows.Forms.Button();
            this.mFoundImages = new System.Windows.Forms.ListBox();
            this.mImageCount = new System.Windows.Forms.TextBox();
            this.mErrorsFound = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.mCopyImages = new System.Windows.Forms.Button();
            this.mCopiedImages = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.mDupesTextBox = new System.Windows.Forms.TextBox();
            this.mProgressBar = new System.Windows.Forms.ProgressBar();
            this.mCopyWorker = new System.ComponentModel.BackgroundWorker();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // mSourceButton
            // 
            this.mSourceButton.Location = new System.Drawing.Point(3, 3);
            this.mSourceButton.Name = "mSourceButton";
            this.mSourceButton.Size = new System.Drawing.Size(102, 23);
            this.mSourceButton.TabIndex = 0;
            this.mSourceButton.Text = "Pick Source...";
            this.mSourceButton.UseVisualStyleBackColor = true;
            this.mSourceButton.Click += new System.EventHandler(this.mBrowseButton_Click);
            // 
            // mSelectedSourceFolder
            // 
            this.mSelectedSourceFolder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mSelectedSourceFolder.Location = new System.Drawing.Point(221, 3);
            this.mSelectedSourceFolder.Name = "mSelectedSourceFolder";
            this.mSelectedSourceFolder.ReadOnly = true;
            this.mSelectedSourceFolder.Size = new System.Drawing.Size(416, 20);
            this.mSelectedSourceFolder.TabIndex = 1;
            // 
            // mSelectedDestinationFolder
            // 
            this.mSelectedDestinationFolder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mSelectedDestinationFolder.Location = new System.Drawing.Point(224, 3);
            this.mSelectedDestinationFolder.Name = "mSelectedDestinationFolder";
            this.mSelectedDestinationFolder.ReadOnly = true;
            this.mSelectedDestinationFolder.Size = new System.Drawing.Size(413, 20);
            this.mSelectedDestinationFolder.TabIndex = 3;
            // 
            // mDestinationButton
            // 
            this.mDestinationButton.Location = new System.Drawing.Point(3, 3);
            this.mDestinationButton.Name = "mDestinationButton";
            this.mDestinationButton.Size = new System.Drawing.Size(102, 23);
            this.mDestinationButton.TabIndex = 2;
            this.mDestinationButton.Text = "Pick Destination...";
            this.mDestinationButton.UseVisualStyleBackColor = true;
            this.mDestinationButton.Click += new System.EventHandler(this.mDestinationButton_Click);
            // 
            // mFindFilesButton
            // 
            this.mFindFilesButton.Enabled = false;
            this.mFindFilesButton.Location = new System.Drawing.Point(6, 17);
            this.mFindFilesButton.Name = "mFindFilesButton";
            this.mFindFilesButton.Size = new System.Drawing.Size(75, 23);
            this.mFindFilesButton.TabIndex = 4;
            this.mFindFilesButton.Text = "Find Images";
            this.mFindFilesButton.UseVisualStyleBackColor = true;
            this.mFindFilesButton.Click += new System.EventHandler(this.mFindFilesButton_Click);
            // 
            // mFoundImages
            // 
            this.mFoundImages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mFoundImages.FormattingEnabled = true;
            this.mFoundImages.HorizontalScrollbar = true;
            this.mFoundImages.Location = new System.Drawing.Point(221, 32);
            this.mFoundImages.Name = "mFoundImages";
            this.mFoundImages.Size = new System.Drawing.Size(416, 90);
            this.mFoundImages.TabIndex = 5;
            // 
            // mImageCount
            // 
            this.mImageCount.Location = new System.Drawing.Point(112, 24);
            this.mImageCount.Name = "mImageCount";
            this.mImageCount.ReadOnly = true;
            this.mImageCount.Size = new System.Drawing.Size(100, 20);
            this.mImageCount.TabIndex = 6;
            this.mImageCount.Text = "0";
            // 
            // mErrorsFound
            // 
            this.mErrorsFound.Location = new System.Drawing.Point(112, 63);
            this.mErrorsFound.Name = "mErrorsFound";
            this.mErrorsFound.ReadOnly = true;
            this.mErrorsFound.Size = new System.Drawing.Size(100, 20);
            this.mErrorsFound.TabIndex = 7;
            this.mErrorsFound.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(109, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Errors:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.mSourceButton, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.mSelectedSourceFolder, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.mFoundImages, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(640, 125);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.mDupesTextBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.mFindFilesButton);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.mImageCount);
            this.groupBox1.Controls.Add(this.mErrorsFound);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(0, 29);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(218, 96);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(109, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Image Count:";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.groupBox2, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.mCopiedImages, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.mDestinationButton, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.mSelectedDestinationFolder, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.mProgressBar, 0, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 125);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(640, 241);
            this.tableLayoutPanel2.TabIndex = 10;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.mCopyImages);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 32);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(215, 186);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            // 
            // mCopyImages
            // 
            this.mCopyImages.Enabled = false;
            this.mCopyImages.Location = new System.Drawing.Point(3, 9);
            this.mCopyImages.Name = "mCopyImages";
            this.mCopyImages.Size = new System.Drawing.Size(102, 23);
            this.mCopyImages.TabIndex = 9;
            this.mCopyImages.Text = "Copy Images";
            this.mCopyImages.UseVisualStyleBackColor = true;
            this.mCopyImages.Click += new System.EventHandler(this.mCopyImages_Click);
            // 
            // mCopiedImages
            // 
            this.mCopiedImages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mCopiedImages.FormattingEnabled = true;
            this.mCopiedImages.HorizontalScrollbar = true;
            this.mCopiedImages.Location = new System.Drawing.Point(224, 32);
            this.mCopiedImages.Name = "mCopiedImages";
            this.mCopiedImages.Size = new System.Drawing.Size(413, 186);
            this.mCopiedImages.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Duplicates:";
            // 
            // mDupesTextBox
            // 
            this.mDupesTextBox.Location = new System.Drawing.Point(6, 63);
            this.mDupesTextBox.Name = "mDupesTextBox";
            this.mDupesTextBox.ReadOnly = true;
            this.mDupesTextBox.Size = new System.Drawing.Size(100, 20);
            this.mDupesTextBox.TabIndex = 11;
            this.mDupesTextBox.Text = "0";
            // 
            // mProgressBar
            // 
            this.mProgressBar.Location = new System.Drawing.Point(3, 224);
            this.mProgressBar.Name = "mProgressBar";
            this.mProgressBar.Size = new System.Drawing.Size(215, 14);
            this.mProgressBar.Step = 1;
            this.mProgressBar.TabIndex = 12;
            // 
            // mCopyWorker
            // 
            this.mCopyWorker.WorkerReportsProgress = true;
            this.mCopyWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.mCopyWorker_DoWork);
            this.mCopyWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.mCopyWorker_ProgressChanged);
            this.mCopyWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.mCopyWorker_RunWorkerCompleted);
            // 
            // ImageCopierForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 366);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ImageCopierForm";
            this.Text = "Image Copier";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button mSourceButton;
        private System.Windows.Forms.TextBox mSelectedSourceFolder;
        private System.Windows.Forms.FolderBrowserDialog mFolderBrowse;
        private System.Windows.Forms.TextBox mSelectedDestinationFolder;
        private System.Windows.Forms.Button mDestinationButton;
        private System.Windows.Forms.Button mFindFilesButton;
        private System.Windows.Forms.ListBox mFoundImages;
        private System.Windows.Forms.TextBox mImageCount;
        private System.Windows.Forms.TextBox mErrorsFound;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button mCopyImages;
        private System.Windows.Forms.ListBox mCopiedImages;
        private System.Windows.Forms.TextBox mDupesTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ProgressBar mProgressBar;
        private System.ComponentModel.BackgroundWorker mCopyWorker;
    }
}

