
namespace DownloadFile
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
            this.urls = new System.Windows.Forms.TextBox();
            this.FN = new System.Windows.Forms.TextBox();
            this.Url = new System.Windows.Forms.Label();
            this.FileName = new System.Windows.Forms.Label();
            this.DNB = new System.Windows.Forms.Button();
            this.Progress = new System.Windows.Forms.ProgressBar();
            this.percent = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // urls
            // 
            this.urls.Location = new System.Drawing.Point(131, 49);
            this.urls.Name = "urls";
            this.urls.Size = new System.Drawing.Size(302, 20);
            this.urls.TabIndex = 0;
            this.urls.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // FN
            // 
            this.FN.Location = new System.Drawing.Point(131, 90);
            this.FN.Name = "FN";
            this.FN.Size = new System.Drawing.Size(302, 20);
            this.FN.TabIndex = 1;
            // 
            // Url
            // 
            this.Url.AutoSize = true;
            this.Url.Location = new System.Drawing.Point(58, 56);
            this.Url.Name = "Url";
            this.Url.Size = new System.Drawing.Size(29, 13);
            this.Url.TabIndex = 2;
            this.Url.Text = "URL";
            // 
            // FileName
            // 
            this.FileName.AutoSize = true;
            this.FileName.Location = new System.Drawing.Point(58, 93);
            this.FileName.Name = "FileName";
            this.FileName.Size = new System.Drawing.Size(54, 13);
            this.FileName.TabIndex = 3;
            this.FileName.Text = "File Name";
            // 
            // DNB
            // 
            this.DNB.Location = new System.Drawing.Point(61, 137);
            this.DNB.Name = "DNB";
            this.DNB.Size = new System.Drawing.Size(69, 23);
            this.DNB.TabIndex = 4;
            this.DNB.Text = "Dowload";
            this.DNB.UseVisualStyleBackColor = true;
            this.DNB.Click += new System.EventHandler(this.DNB_Click);
            // 
            // Progress
            // 
            this.Progress.Location = new System.Drawing.Point(136, 137);
            this.Progress.Name = "Progress";
            this.Progress.Size = new System.Drawing.Size(271, 23);
            this.Progress.TabIndex = 5;
            // 
            // percent
            // 
            this.percent.AutoSize = true;
            this.percent.Location = new System.Drawing.Point(413, 142);
            this.percent.Name = "percent";
            this.percent.Size = new System.Drawing.Size(21, 13);
            this.percent.TabIndex = 6;
            this.percent.Text = "0%";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 291);
            this.Controls.Add(this.percent);
            this.Controls.Add(this.Progress);
            this.Controls.Add(this.DNB);
            this.Controls.Add(this.FileName);
            this.Controls.Add(this.Url);
            this.Controls.Add(this.FN);
            this.Controls.Add(this.urls);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox urls;
        private System.Windows.Forms.TextBox FN;
        private System.Windows.Forms.Label Url;
        private System.Windows.Forms.Label FileName;
        private System.Windows.Forms.Button DNB;
        private System.Windows.Forms.ProgressBar Progress;
        private System.Windows.Forms.Label percent;
    }
}

