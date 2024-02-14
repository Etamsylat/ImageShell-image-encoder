namespace Shuffle
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.fileGetBtn = new System.Windows.Forms.Button();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.fkItUpBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.unfkBtn = new System.Windows.Forms.Button();
            this.seedTxt = new System.Windows.Forms.TextBox();
            this.encryptionLevelTxt = new System.Windows.Forms.TextBox();
            this.unfkSequenceBtn = new System.Windows.Forms.Button();
            this.sqncTxt = new System.Windows.Forms.TextBox();
            this.copyBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(189, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(996, 588);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // fileGetBtn
            // 
            this.fileGetBtn.Location = new System.Drawing.Point(33, 281);
            this.fileGetBtn.Name = "fileGetBtn";
            this.fileGetBtn.Size = new System.Drawing.Size(89, 29);
            this.fileGetBtn.TabIndex = 1;
            this.fileGetBtn.Text = "Get file";
            this.fileGetBtn.UseVisualStyleBackColor = true;
            this.fileGetBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // fkItUpBtn
            // 
            this.fkItUpBtn.Location = new System.Drawing.Point(33, 363);
            this.fkItUpBtn.Name = "fkItUpBtn";
            this.fkItUpBtn.Size = new System.Drawing.Size(89, 45);
            this.fkItUpBtn.TabIndex = 2;
            this.fkItUpBtn.Text = "F**K THIS SHIT UP";
            this.fkItUpBtn.UseVisualStyleBackColor = true;
            this.fkItUpBtn.Click += new System.EventHandler(this.fkItUpBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(33, 465);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(89, 35);
            this.saveBtn.TabIndex = 3;
            this.saveBtn.Text = "Save this s**t to file";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // unfkBtn
            // 
            this.unfkBtn.Location = new System.Drawing.Point(33, 414);
            this.unfkBtn.Name = "unfkBtn";
            this.unfkBtn.Size = new System.Drawing.Size(89, 45);
            this.unfkBtn.TabIndex = 4;
            this.unfkBtn.Text = "Unf**k this shit";
            this.unfkBtn.UseVisualStyleBackColor = true;
            this.unfkBtn.Click += new System.EventHandler(this.unfkBtn_Click);
            // 
            // seedTxt
            // 
            this.seedTxt.Location = new System.Drawing.Point(33, 70);
            this.seedTxt.Name = "seedTxt";
            this.seedTxt.Size = new System.Drawing.Size(100, 20);
            this.seedTxt.TabIndex = 5;
            // 
            // encryptionLevelTxt
            // 
            this.encryptionLevelTxt.Location = new System.Drawing.Point(33, 123);
            this.encryptionLevelTxt.Name = "encryptionLevelTxt";
            this.encryptionLevelTxt.Size = new System.Drawing.Size(100, 20);
            this.encryptionLevelTxt.TabIndex = 6;
            // 
            // unfkSequenceBtn
            // 
            this.unfkSequenceBtn.Location = new System.Drawing.Point(33, 316);
            this.unfkSequenceBtn.Name = "unfkSequenceBtn";
            this.unfkSequenceBtn.Size = new System.Drawing.Size(89, 41);
            this.unfkSequenceBtn.TabIndex = 9;
            this.unfkSequenceBtn.Text = "Execute sequence";
            this.unfkSequenceBtn.UseVisualStyleBackColor = true;
            this.unfkSequenceBtn.Click += new System.EventHandler(this.unfkSequenceBtn_Click);
            // 
            // sqncTxt
            // 
            this.sqncTxt.Location = new System.Drawing.Point(33, 187);
            this.sqncTxt.Name = "sqncTxt";
            this.sqncTxt.Size = new System.Drawing.Size(100, 20);
            this.sqncTxt.TabIndex = 11;
            // 
            // copyBtn
            // 
            this.copyBtn.Location = new System.Drawing.Point(33, 507);
            this.copyBtn.Name = "copyBtn";
            this.copyBtn.Size = new System.Drawing.Size(89, 31);
            this.copyBtn.TabIndex = 12;
            this.copyBtn.Text = "Copy Image";
            this.copyBtn.UseVisualStyleBackColor = true;
            this.copyBtn.Click += new System.EventHandler(this.copyBtn_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1192, 614);
            this.Controls.Add(this.copyBtn);
            this.Controls.Add(this.sqncTxt);
            this.Controls.Add(this.unfkSequenceBtn);
            this.Controls.Add(this.encryptionLevelTxt);
            this.Controls.Add(this.seedTxt);
            this.Controls.Add(this.unfkBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.fkItUpBtn);
            this.Controls.Add(this.fileGetBtn);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "Image Encoder";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button fileGetBtn;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Button fkItUpBtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button unfkBtn;
        private System.Windows.Forms.TextBox seedTxt;
        private System.Windows.Forms.TextBox encryptionLevelTxt;
        private System.Windows.Forms.Button unfkSequenceBtn;
        private System.Windows.Forms.TextBox sqncTxt;
        private System.Windows.Forms.Button copyBtn;
    }
}

