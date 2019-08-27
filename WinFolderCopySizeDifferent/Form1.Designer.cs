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
            this.btnClear = new System.Windows.Forms.Button();
            this.rtxtResult = new System.Windows.Forms.RichTextBox();
            this.txtDestinationDir = new System.Windows.Forms.TextBox();
            this.txtSourceDir = new System.Windows.Forms.TextBox();
            this.btnCopy = new System.Windows.Forms.Button();
            this.btnDestinationDir = new System.Windows.Forms.Button();
            this.btnSourceDir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(75, 428);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 13;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // rtxtResult
            // 
            this.rtxtResult.Location = new System.Drawing.Point(75, 65);
            this.rtxtResult.Name = "rtxtResult";
            this.rtxtResult.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtxtResult.Size = new System.Drawing.Size(651, 357);
            this.rtxtResult.TabIndex = 12;
            this.rtxtResult.Text = "";
            // 
            // txtDestinationDir
            // 
            this.txtDestinationDir.Location = new System.Drawing.Point(75, 32);
            this.txtDestinationDir.Name = "txtDestinationDir";
            this.txtDestinationDir.Size = new System.Drawing.Size(527, 21);
            this.txtDestinationDir.TabIndex = 11;
            // 
            // txtSourceDir
            // 
            this.txtSourceDir.Location = new System.Drawing.Point(75, -1);
            this.txtSourceDir.Name = "txtSourceDir";
            this.txtSourceDir.Size = new System.Drawing.Size(527, 21);
            this.txtSourceDir.TabIndex = 10;
            // 
            // btnCopy
            // 
            this.btnCopy.Location = new System.Drawing.Point(646, 428);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(80, 23);
            this.btnCopy.TabIndex = 9;
            this.btnCopy.Text = "Copy";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // btnDestinationDir
            // 
            this.btnDestinationDir.Location = new System.Drawing.Point(608, 31);
            this.btnDestinationDir.Name = "btnDestinationDir";
            this.btnDestinationDir.Size = new System.Drawing.Size(118, 23);
            this.btnDestinationDir.TabIndex = 8;
            this.btnDestinationDir.Text = "DestinationFolder";
            this.btnDestinationDir.UseVisualStyleBackColor = true;
            // 
            // btnSourceDir
            // 
            this.btnSourceDir.Location = new System.Drawing.Point(608, -1);
            this.btnSourceDir.Name = "btnSourceDir";
            this.btnSourceDir.Size = new System.Drawing.Size(118, 23);
            this.btnSourceDir.TabIndex = 7;
            this.btnSourceDir.Text = "SourceFolder";
            this.btnSourceDir.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 496);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.rtxtResult);
            this.Controls.Add(this.txtDestinationDir);
            this.Controls.Add(this.txtSourceDir);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.btnDestinationDir);
            this.Controls.Add(this.btnSourceDir);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.RichTextBox rtxtResult;
        private System.Windows.Forms.TextBox txtDestinationDir;
        private System.Windows.Forms.TextBox txtSourceDir;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.Button btnDestinationDir;
        private System.Windows.Forms.Button btnSourceDir;
    }
}

