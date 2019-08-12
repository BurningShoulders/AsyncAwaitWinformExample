namespace AsyncAwaitWinformExample
{
    partial class Form1
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
            this.btnNotAsync = new System.Windows.Forms.Button();
            this.btnAsyncTask = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnAsyncDownloadMethod = new System.Windows.Forms.Button();
            this.btnClearPicturebox = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNotAsync
            // 
            this.btnNotAsync.Location = new System.Drawing.Point(12, 47);
            this.btnNotAsync.Name = "btnNotAsync";
            this.btnNotAsync.Size = new System.Drawing.Size(75, 23);
            this.btnNotAsync.TabIndex = 0;
            this.btnNotAsync.Text = "Not Async";
            this.btnNotAsync.UseVisualStyleBackColor = true;
            this.btnNotAsync.Click += new System.EventHandler(this.btnNotAsync_Click);
            // 
            // btnAsyncTask
            // 
            this.btnAsyncTask.Location = new System.Drawing.Point(93, 47);
            this.btnAsyncTask.Name = "btnAsyncTask";
            this.btnAsyncTask.Size = new System.Drawing.Size(75, 23);
            this.btnAsyncTask.TabIndex = 1;
            this.btnAsyncTask.Text = "Async Task";
            this.btnAsyncTask.UseVisualStyleBackColor = true;
            this.btnAsyncTask.Click += new System.EventHandler(this.btnAsyncTask_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 76);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(306, 173);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 286);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(306, 20);
            this.textBox1.TabIndex = 3;
            // 
            // btnAsyncDownloadMethod
            // 
            this.btnAsyncDownloadMethod.Location = new System.Drawing.Point(174, 47);
            this.btnAsyncDownloadMethod.Name = "btnAsyncDownloadMethod";
            this.btnAsyncDownloadMethod.Size = new System.Drawing.Size(144, 23);
            this.btnAsyncDownloadMethod.TabIndex = 4;
            this.btnAsyncDownloadMethod.Text = "Async Download Method";
            this.btnAsyncDownloadMethod.UseVisualStyleBackColor = true;
            this.btnAsyncDownloadMethod.Click += new System.EventHandler(this.btnAsyncDownloadMethod_Click);
            // 
            // btnClearPicturebox
            // 
            this.btnClearPicturebox.Location = new System.Drawing.Point(12, 257);
            this.btnClearPicturebox.Name = "btnClearPicturebox";
            this.btnClearPicturebox.Size = new System.Drawing.Size(306, 23);
            this.btnClearPicturebox.TabIndex = 5;
            this.btnClearPicturebox.Text = "Remove image";
            this.btnClearPicturebox.UseVisualStyleBackColor = true;
            this.btnClearPicturebox.Click += new System.EventHandler(this.btnClearPicturebox_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 354);
            this.Controls.Add(this.btnClearPicturebox);
            this.Controls.Add(this.btnAsyncDownloadMethod);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnAsyncTask);
            this.Controls.Add(this.btnNotAsync);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNotAsync;
        private System.Windows.Forms.Button btnAsyncTask;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnAsyncDownloadMethod;
        private System.Windows.Forms.Button btnClearPicturebox;
    }
}

