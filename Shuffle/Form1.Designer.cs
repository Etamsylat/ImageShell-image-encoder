namespace Shuffle
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.fileGetBtn = new System.Windows.Forms.Button();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.fuckItUpBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.unfuckBtn = new System.Windows.Forms.Button();
            this.seedTxt = new System.Windows.Forms.TextBox();
            this.encryptionLevelTxt = new System.Windows.Forms.TextBox();
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
            this.fileGetBtn.Location = new System.Drawing.Point(33, 217);
            this.fileGetBtn.Name = "fileGetBtn";
            this.fileGetBtn.Size = new System.Drawing.Size(89, 57);
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
            // fuckItUpBtn
            // 
            this.fuckItUpBtn.Location = new System.Drawing.Point(33, 310);
            this.fuckItUpBtn.Name = "fuckItUpBtn";
            this.fuckItUpBtn.Size = new System.Drawing.Size(89, 45);
            this.fuckItUpBtn.TabIndex = 2;
            this.fuckItUpBtn.Text = "FUCK THIS SHIT UP";
            this.fuckItUpBtn.UseVisualStyleBackColor = true;
            this.fuckItUpBtn.Click += new System.EventHandler(this.fuckItUpBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(33, 474);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(89, 53);
            this.saveBtn.TabIndex = 3;
            this.saveBtn.Text = "Save this shit to file";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // unfuckBtn
            // 
            this.unfuckBtn.Location = new System.Drawing.Point(33, 383);
            this.unfuckBtn.Name = "unfuckBtn";
            this.unfuckBtn.Size = new System.Drawing.Size(89, 45);
            this.unfuckBtn.TabIndex = 4;
            this.unfuckBtn.Text = "Unfuck this shit";
            this.unfuckBtn.UseVisualStyleBackColor = true;
            this.unfuckBtn.Click += new System.EventHandler(this.unfuckBtn_Click);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1192, 742);
            this.Controls.Add(this.encryptionLevelTxt);
            this.Controls.Add(this.seedTxt);
            this.Controls.Add(this.unfuckBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.fuckItUpBtn);
            this.Controls.Add(this.fileGetBtn);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
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
        private System.Windows.Forms.Button fuckItUpBtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button unfuckBtn;
        private System.Windows.Forms.TextBox seedTxt;
        private System.Windows.Forms.TextBox encryptionLevelTxt;
    }
}

