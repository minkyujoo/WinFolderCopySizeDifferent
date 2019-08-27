namespace WinFolderCopySizeDifferent
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSourceDir = new System.Windows.Forms.Button();
            this.btnDestinationDir = new System.Windows.Forms.Button();
            this.btnCopy = new System.Windows.Forms.Button();
            this.txtSourceDir = new System.Windows.Forms.TextBox();
            this.txtDestinationDir = new System.Windows.Forms.TextBox();
            this.rtxtResult = new System.Windows.Forms.RichTextBox();
            this.folderBrowserDialogSource = new System.Windows.Forms.FolderBrowserDialog();
            this.folderBrowserDialogDestination = new System.Windows.Forms.FolderBrowserDialog();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSourceDir
            // 
            this.btnSourceDir.Location = new System.Drawing.Point(545, 15);
            this.btnSourceDir.Name = "btnSourceDir";
            this.btnSourceDir.Size = new System.Drawing.Size(118, 23);
            this.btnSourceDir.TabIndex = 0;
            this.btnSourceDir.Text = "SourceFolder";
            this.btnSourceDir.UseVisualStyleBackColor = true;
            this.btnSourceDir.Click += new System.EventHandler(this.btnSourceDir_Click);
            // 
            // btnDestinationDir
            // 
            this.btnDestinationDir.Location = new System.Drawing.Point(545, 47);
            this.btnDestinationDir.Name = "btnDestinationDir";
            this.btnDestinationDir.Size = new System.Drawing.Size(118, 23);
            this.btnDestinationDir.TabIndex = 1;
            this.btnDestinationDir.Text = "DestinationFolder";
            this.btnDestinationDir.UseVisualStyleBackColor = true;
            this.btnDestinationDir.Click += new System.EventHandler(this.btnDestinationDir_Click);
            // 
            // btnCopy
            // 
            this.btnCopy.Location = new System.Drawing.Point(583, 444);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(80, 23);
            this.btnCopy.TabIndex = 2;
            this.btnCopy.Text = "Copy";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // txtSourceDir
            // 
            this.txtSourceDir.Location = new System.Drawing.Point(12, 15);
            this.txtSourceDir.Name = "txtSourceDir";
            this.txtSourceDir.Size = new System.Drawing.Size(527, 21);
            this.txtSourceDir.TabIndex = 3;
            // 
            // txtDestinationDir
            // 
            this.txtDestinationDir.Location = new System.Drawing.Point(12, 48);
            this.txtDestinationDir.Name = "txtDestinationDir";
            this.txtDestinationDir.Size = new System.Drawing.Size(527, 21);
            this.txtDestinationDir.TabIndex = 4;
            // 
            // rtxtResult
            // 
            this.rtxtResult.Location = new System.Drawing.Point(12, 81);
            this.rtxtResult.Name = "rtxtResult";
            this.rtxtResult.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtxtResult.Size = new System.Drawing.Size(651, 357);
            this.rtxtResult.TabIndex = 5;
            this.rtxtResult.Text = "";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(12, 444);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 479);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.rtxtResult);
            this.Controls.Add(this.txtDestinationDir);
            this.Controls.Add(this.txtSourceDir);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.btnDestinationDir);
            this.Controls.Add(this.btnSourceDir);
            this.Name = "Form1";
            this.Text = "CopyFolderWithDiffernect";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSourceDir;
        private System.Windows.Forms.Button btnDestinationDir;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.TextBox txtSourceDir;
        private System.Windows.Forms.TextBox txtDestinationDir;
        private System.Windows.Forms.RichTextBox rtxtResult;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialogSource;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialogDestination;
        private System.Windows.Forms.Button btnClear;
    }
}

