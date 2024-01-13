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
            this.sequencerBtn = new System.Windows.Forms.Button();
            this.unfkSequenceBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
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
            this.fileGetBtn.Location = new System.Drawing.Point(33, 213);
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
            // fkItUpBtn
            // 
            this.fkItUpBtn.Location = new System.Drawing.Point(33, 402);
            this.fkItUpBtn.Name = "fkItUpBtn";
            this.fkItUpBtn.Size = new System.Drawing.Size(89, 45);
            this.fkItUpBtn.TabIndex = 2;
            this.fkItUpBtn.Text = "F**K THIS SHIT UP";
            this.fkItUpBtn.UseVisualStyleBackColor = true;
            this.fkItUpBtn.Click += new System.EventHandler(this.fkItUpBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(33, 513);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(89, 53);
            this.saveBtn.TabIndex = 3;
            this.saveBtn.Text = "Save this s**t to file";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // unfkBtn
            // 
            this.unfkBtn.Location = new System.Drawing.Point(33, 462);
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
            // sequencerBtn
            // 
            this.sequencerBtn.Location = new System.Drawing.Point(33, 286);
            this.sequencerBtn.Name = "sequencerBtn";
            this.sequencerBtn.Size = new System.Drawing.Size(89, 42);
            this.sequencerBtn.TabIndex = 7;
            this.sequencerBtn.Text = "Add to sequencer";
            this.sequencerBtn.UseVisualStyleBackColor = true;
            this.sequencerBtn.Click += new System.EventHandler(this.sequencerBtn_Click);
            // 
            // unfkSequenceBtn
            // 
            this.unfkSequenceBtn.Location = new System.Drawing.Point(33, 348);
            this.unfkSequenceBtn.Name = "unfkSequenceBtn";
            this.unfkSequenceBtn.Size = new System.Drawing.Size(89, 42);
            this.unfkSequenceBtn.TabIndex = 9;
            this.unfkSequenceBtn.Text = "Execute sequence";
            this.unfkSequenceBtn.UseVisualStyleBackColor = true;
            this.unfkSequenceBtn.Click += new System.EventHandler(this.unfkSequenceBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(691, 348);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "label1";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1192, 614);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.unfkSequenceBtn);
            this.Controls.Add(this.sequencerBtn);
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
        private System.Windows.Forms.Button sequencerBtn;
        private System.Windows.Forms.Button unfkSequenceBtn;
        private System.Windows.Forms.Label label1;
    }
}

