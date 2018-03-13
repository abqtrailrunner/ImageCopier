using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Windows.Media.Imaging;

namespace ImageCopier
{
    public partial class ImageCopierForm : Form
    {
        private SortedSet<ImageData> mImageFiles = new SortedSet<ImageData>();
        private int mErrorCount = 0;
        private int mDuplicateFilesFound = 0;
        private List<String> mCopiedImageNames = new List<string>();
        private string mFileType = ".jpg";

        public ImageCopierForm()
        {
            InitializeComponent();
        }

        private void mBrowseButton_Click(object sender, EventArgs e)
        {
            if (mFolderBrowse.ShowDialog() == DialogResult.OK)
            {
                mSelectedSourceFolder.Text = mFolderBrowse.SelectedPath;
                mFindFilesButton.Enabled = true;
            }
        }

        private void mDestinationButton_Click(object sender, EventArgs e)
        {
            if (mFolderBrowse.ShowDialog() == DialogResult.OK)
            {
                mSelectedDestinationFolder.Text = mFolderBrowse.SelectedPath;
                mCopyImages.Enabled = true;
            }
        }

        private void mFindFilesButton_Click(object sender, EventArgs e)
        {
            mErrorCount = 0;
            mDuplicateFilesFound = 0;
            mImageFiles.Clear();

            Cursor.Current = Cursors.WaitCursor;
            FindFiles(mSelectedSourceFolder.Text);
            Cursor.Current = Cursors.Default;

            foreach (ImageData imageData in mImageFiles)
            {
                mFoundImages.Items.Add(imageData.OriginalPath);
            }

            mImageCount.Text = string.Format("{0}", mImageFiles.Count);
            mErrorsFound.Text = string.Format("{0}", mErrorCount);
            mDupesTextBox.Text = string.Format("{0}", mDuplicateFilesFound);
        }

        private void FindFiles(string currentPath)
        {
            // Find any images in the current directory.
            try
            {
                string[] files = Directory.GetFiles(currentPath);
                foreach (string file in files)
                {
                    string extension = System.IO.Path.GetExtension(file);
                    if (extension.ToLower().Equals(mFileType))
                    {
                        long length = new System.IO.FileInfo(file).Length;
                        string dateTaken = RetrieveMetadata(file);
                        bool added = mImageFiles.Add(new ImageData(file, dateTaken, length));
                        if (!added)
                            ++mDuplicateFilesFound;
                    }
                }
            }
            catch (Exception)
            {
                ++mErrorCount;
            }

            // Now continue to recurse deeper into the tree.
            try
            {
                string[] subdirs = System.IO.Directory.GetDirectories(currentPath);
                foreach (string subdir in subdirs)
                {
                    FindFiles(subdir);
                }
            }
            catch (Exception)
            {
                ++mErrorCount;
            }
        }

        public string RetrieveMetadata(string path)
        {
            using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.Read))
            {
                BitmapSource img = BitmapFrame.Create(fs);
                BitmapMetadata md = (BitmapMetadata)img.Metadata;
                if (md != null)
                {
                    return md.DateTaken;
                }
                return "unset";
            }
        }

        private void mCopyImages_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            mCopiedImages.Items.Clear();
            mProgressBar.Value = 0;
            mCopyWorker.RunWorkerAsync();
            Cursor.Current = Cursors.Default;
        }

        private void mCopyWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            mCopiedImageNames.Clear();
            int totalImageCount = mImageFiles.Count;
            int imagesDone = 0;
            foreach (ImageData imageData in mImageFiles)
            {
                ++imagesDone;
                DateTime dateTime = imageData.DateTaken;
                string directoryName = mSelectedDestinationFolder.Text + "/" + dateTime.Year + "-" + dateTime.Month;
                DirectoryInfo dirInfo;
                try
                {
                    dirInfo = System.IO.Directory.CreateDirectory(directoryName);
                }
                catch (Exception)
                {
                    MessageBox.Show("Failed to create directory: " + directoryName);
                    continue;
                }

                string imageBaseName = dateTime.ToString("MMMM") + dateTime.Day + "-" + dateTime.Hour + "_" + dateTime.Minute + "_" + dateTime.Second;
                string imageName = imageBaseName + mFileType;
                string fullPath = Path.Combine(directoryName, imageName);
                int index = 0;
                while (File.Exists(directoryName + "/" + imageName) && index < 100)
                {
                    string addIndex = imageBaseName + index.ToString();
                    imageName = imageBaseName + mFileType;
                    fullPath = Path.Combine(directoryName, imageName);
                    ++index;
                }

                if (index < 100)
                {
                    File.Copy(imageData.OriginalPath, fullPath);
                    mCopiedImageNames.Add(fullPath);
                }

                mCopyWorker.ReportProgress((imagesDone * 100 / totalImageCount));
            }
        }

        private void mCopyWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            mProgressBar.Value = e.ProgressPercentage;
        }

        private void mCopyWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            foreach (string copiedPath in mCopiedImageNames)
                mCopiedImages.Items.Add(copiedPath);
        }
    }
}
