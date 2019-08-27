using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFolderCopySizeDifferent
{
    public partial class Form1 : Form
    {
        FileInfo sourceFile;
        FileInfo targetFile;
        DirectoryInfo dirInfo;

        string sourceDir = String.Empty;
        string targetDir = String.Empty;
        int sleepTime = 500;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            //CopyOverwriteWithDifferentSize(sourceDir);
            Thread t1 = new Thread(new ThreadStart(ThreadWorker));
            t1.Start();
            //ThreadWorker();
        }

        #region "Utility"
        private void Log(string txtLog)
        {
            //rtxtLoginMessage.Select(0, 0);
            //rtxtLoginMessage.SelectedText = line + Environment.NewLine;
            if (rtxtResult.InvokeRequired)
            {
                rtxtResult.BeginInvoke(new Action(() => rtxtResult.Select(0, 0)));
                rtxtResult.BeginInvoke(new Action(() => rtxtResult.SelectedText = txtLog + "\r\n"));
            }
            else
            {
                rtxtResult.Select(0, 0);
                rtxtResult.SelectedText = txtLog + "\r\n";
            }
            //this.Refresh();
        }
        #endregion

        #region "main oeperation"

        private void ThreadWorker()
        {
            CopyOverwriteWithDifferentSize(sourceDir);
        }

        private void CopyOverwriteWithDifferentSize(string dirParent)
        {
            foreach (var dir in Directory.GetDirectories(dirParent))
            {
                dirInfo = new DirectoryInfo(dir);
                // files
                foreach (var file in Directory.GetFiles(dir))
                {
                    sourceFile = new FileInfo(file);
                    if (sourceFile.Length > 0)
                    {
                        targetFile = new FileInfo(Path.Combine(Path.GetDirectoryName(sourceFile.FullName).Replace(sourceDir, targetDir), Path.GetFileName(file)));
                        if (targetFile.Exists)
                        {
                            if (sourceFile.Length < targetFile.Length)
                            {
                                File.Copy(file, targetFile.FullName, true);
                                //Console.WriteLine(targetFile.FullName);
                                Log(targetFile.FullName);
                                Thread.Sleep(sleepTime);
                            }
                        }
                        else
                        {
                            string targetDirName = Path.GetDirectoryName(targetFile.FullName);
                            DirectoryInfo di = new DirectoryInfo(targetDirName);

                            if (!di.Exists)
                                Directory.CreateDirectory(targetDirName);

                            File.Copy(file, targetFile.FullName, true);
                            //Console.WriteLine(targetFile.FullName);
                            Log(targetFile.FullName);
                            Thread.Sleep(sleepTime);
                        }
                    }
                }
                // sub directories
                if (dirInfo.GetDirectories().Length > 0)
                    CopyOverwriteWithDifferentSize(dirInfo.FullName);

                //this.Refresh();
            }
            Log("END - " + dirParent);
        }
        #endregion

    }
}
