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
            this.displayBox = new System.Windows.Forms.PictureBox();
            this.fileGetBtn = new System.Windows.Forms.Button();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.saveBtn = new System.Windows.Forms.Button();
            this.unfkSequenceBtn = new System.Windows.Forms.Button();
            this.sqncTxt = new System.Windows.Forms.TextBox();
            this.copyBtn = new System.Windows.Forms.Button();
            this.encodeBtn = new System.Windows.Forms.Button();
            this.pasteBtn = new System.Windows.Forms.Button();
            this.infoLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.displayBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // displayBox
            // 
            this.displayBox.BackColor = System.Drawing.Color.Transparent;
            this.displayBox.Image = ((System.Drawing.Image)(resources.GetObject("displayBox.Image")));
            this.displayBox.Location = new System.Drawing.Point(295, 12);
            this.displayBox.Name = "displayBox";
            this.displayBox.Size = new System.Drawing.Size(960, 540);
            this.displayBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.displayBox.TabIndex = 0;
            this.displayBox.TabStop = false;
            // 
            // fileGetBtn
            // 
            this.fileGetBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("fileGetBtn.BackgroundImage")));
            this.fileGetBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.fileGetBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.fileGetBtn.FlatAppearance.BorderSize = 0;
            this.fileGetBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.fileGetBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.fileGetBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.fileGetBtn.Font = new System.Drawing.Font("Falling Sky", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.fileGetBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.fileGetBtn.Location = new System.Drawing.Point(44, 156);
            this.fileGetBtn.Name = "fileGetBtn";
            this.fileGetBtn.Size = new System.Drawing.Size(202, 57);
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
            // saveBtn
            // 
            this.saveBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("saveBtn.BackgroundImage")));
            this.saveBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.saveBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.saveBtn.FlatAppearance.BorderSize = 0;
            this.saveBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.saveBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.saveBtn.Font = new System.Drawing.Font("Falling Sky", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.saveBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.saveBtn.Location = new System.Drawing.Point(43, 471);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(202, 57);
            this.saveBtn.TabIndex = 3;
            this.saveBtn.Text = "Save Image To File";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // unfkSequenceBtn
            // 
            this.unfkSequenceBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("unfkSequenceBtn.BackgroundImage")));
            this.unfkSequenceBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.unfkSequenceBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.unfkSequenceBtn.FlatAppearance.BorderSize = 0;
            this.unfkSequenceBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.unfkSequenceBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.unfkSequenceBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.unfkSequenceBtn.Font = new System.Drawing.Font("Falling Sky", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.unfkSequenceBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.unfkSequenceBtn.Location = new System.Drawing.Point(44, 282);
            this.unfkSequenceBtn.Name = "unfkSequenceBtn";
            this.unfkSequenceBtn.Size = new System.Drawing.Size(202, 57);
            this.unfkSequenceBtn.TabIndex = 9;
            this.unfkSequenceBtn.Text = "Decode";
            this.unfkSequenceBtn.UseVisualStyleBackColor = true;
            this.unfkSequenceBtn.Click += new System.EventHandler(this.unfkSequenceBtn_Click);
            // 
            // sqncTxt
            // 
            this.sqncTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sqncTxt.Font = new System.Drawing.Font("Falling Sky", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.sqncTxt.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.sqncTxt.Location = new System.Drawing.Point(44, 63);
            this.sqncTxt.Name = "sqncTxt";
            this.sqncTxt.Size = new System.Drawing.Size(201, 34);
            this.sqncTxt.TabIndex = 11;
            this.sqncTxt.Text = "Enter seed...";
            this.sqncTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.sqncTxt.Enter += new System.EventHandler(this.sqncTxt_Enter);
            this.sqncTxt.Leave += new System.EventHandler(this.sqncTxt_Leave);
            // 
            // copyBtn
            // 
            this.copyBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("copyBtn.BackgroundImage")));
            this.copyBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.copyBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.copyBtn.FlatAppearance.BorderSize = 0;
            this.copyBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.copyBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.copyBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.copyBtn.Font = new System.Drawing.Font("Falling Sky", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.copyBtn.ForeColor = System.Drawing.Color.White;
            this.copyBtn.Location = new System.Drawing.Point(44, 345);
            this.copyBtn.Name = "copyBtn";
            this.copyBtn.Size = new System.Drawing.Size(202, 57);
            this.copyBtn.TabIndex = 12;
            this.copyBtn.Text = "Copy Current Image";
            this.copyBtn.UseVisualStyleBackColor = true;
            this.copyBtn.Click += new System.EventHandler(this.copyBtn_Click);
            // 
            // encodeBtn
            // 
            this.encodeBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("encodeBtn.BackgroundImage")));
            this.encodeBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.encodeBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.encodeBtn.FlatAppearance.BorderSize = 0;
            this.encodeBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.encodeBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.encodeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.encodeBtn.Font = new System.Drawing.Font("Falling Sky", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.encodeBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.encodeBtn.Location = new System.Drawing.Point(44, 219);
            this.encodeBtn.Name = "encodeBtn";
            this.encodeBtn.Size = new System.Drawing.Size(202, 57);
            this.encodeBtn.TabIndex = 13;
            this.encodeBtn.Text = "Encode";
            this.encodeBtn.UseVisualStyleBackColor = true;
            this.encodeBtn.Click += new System.EventHandler(this.encodeBtn_Click);
            // 
            // pasteBtn
            // 
            this.pasteBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pasteBtn.BackgroundImage")));
            this.pasteBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pasteBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.pasteBtn.FlatAppearance.BorderSize = 0;
            this.pasteBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.pasteBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.pasteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.pasteBtn.Font = new System.Drawing.Font("Falling Sky", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pasteBtn.ForeColor = System.Drawing.Color.White;
            this.pasteBtn.Location = new System.Drawing.Point(43, 408);
            this.pasteBtn.Name = "pasteBtn";
            this.pasteBtn.Size = new System.Drawing.Size(202, 57);
            this.pasteBtn.TabIndex = 14;
            this.pasteBtn.Text = "Paste Image";
            this.pasteBtn.UseVisualStyleBackColor = true;
            this.pasteBtn.Click += new System.EventHandler(this.pasteBtn_Click);
            // 
            // infoLbl
            // 
            this.infoLbl.AutoSize = true;
            this.infoLbl.BackColor = System.Drawing.Color.Transparent;
            this.infoLbl.Font = new System.Drawing.Font("Falling Sky", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.infoLbl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.infoLbl.Location = new System.Drawing.Point(39, 111);
            this.infoLbl.Name = "infoLbl";
            this.infoLbl.Size = new System.Drawing.Size(0, 28);
            this.infoLbl.TabIndex = 15;
            // 
            // Main
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1284, 561);
            this.Controls.Add(this.infoLbl);
            this.Controls.Add(this.pasteBtn);
            this.Controls.Add(this.encodeBtn);
            this.Controls.Add(this.copyBtn);
            this.Controls.Add(this.sqncTxt);
            this.Controls.Add(this.unfkSequenceBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.fileGetBtn);
            this.Controls.Add(this.displayBox);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Text = "Image Shell";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Main_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.displayBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox displayBox;
        private System.Windows.Forms.Button fileGetBtn;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button unfkSequenceBtn;
        private System.Windows.Forms.TextBox sqncTxt;
        private System.Windows.Forms.Button copyBtn;
        private System.Windows.Forms.Button encodeBtn;
        private System.Windows.Forms.Button pasteBtn;
        private System.Windows.Forms.Label infoLbl;
    }
}

