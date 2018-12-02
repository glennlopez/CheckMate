namespace CheckMate
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.textBoxFileChecksum = new System.Windows.Forms.TextBox();
            this.textBoxCompareWith = new System.Windows.Forms.TextBox();
            this.groupBoxCompare = new System.Windows.Forms.GroupBox();
            this.buttonSaveHash = new System.Windows.Forms.Button();
            this.comboBoxHashMode = new System.Windows.Forms.ComboBox();
            this.buttonTXTBrowser = new System.Windows.Forms.Button();
            this.labelResultContext = new System.Windows.Forms.Label();
            this.buttonCheck = new System.Windows.Forms.Button();
            this.labelResult = new System.Windows.Forms.Label();
            this.labelCompareTo = new System.Windows.Forms.Label();
            this.groupBoxFile = new System.Windows.Forms.GroupBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.buttonFileBrowse = new System.Windows.Forms.Button();
            this.textBoxFileBrowser = new System.Windows.Forms.TextBox();
            this.buttonCalculateChecksum = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBoxCompare.SuspendLayout();
            this.groupBoxFile.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxFileChecksum
            // 
            this.textBoxFileChecksum.Enabled = false;
            this.textBoxFileChecksum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFileChecksum.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBoxFileChecksum.Location = new System.Drawing.Point(220, 53);
            this.textBoxFileChecksum.Name = "textBoxFileChecksum";
            this.textBoxFileChecksum.Size = new System.Drawing.Size(521, 35);
            this.textBoxFileChecksum.TabIndex = 0;
            this.textBoxFileChecksum.Click += new System.EventHandler(this.textBoxGeneratedOnClick);
            this.textBoxFileChecksum.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBoxFileChecksum.DoubleClick += new System.EventHandler(this.textBoxGeneratedOnClick);
            // 
            // textBoxCompareWith
            // 
            this.textBoxCompareWith.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCompareWith.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBoxCompareWith.Location = new System.Drawing.Point(220, 100);
            this.textBoxCompareWith.Name = "textBoxCompareWith";
            this.textBoxCompareWith.Size = new System.Drawing.Size(521, 35);
            this.textBoxCompareWith.TabIndex = 1;
            // 
            // groupBoxCompare
            // 
            this.groupBoxCompare.Controls.Add(this.buttonSaveHash);
            this.groupBoxCompare.Controls.Add(this.comboBoxHashMode);
            this.groupBoxCompare.Controls.Add(this.buttonTXTBrowser);
            this.groupBoxCompare.Controls.Add(this.labelResultContext);
            this.groupBoxCompare.Controls.Add(this.buttonCheck);
            this.groupBoxCompare.Controls.Add(this.labelResult);
            this.groupBoxCompare.Controls.Add(this.labelCompareTo);
            this.groupBoxCompare.Controls.Add(this.textBoxFileChecksum);
            this.groupBoxCompare.Controls.Add(this.textBoxCompareWith);
            this.groupBoxCompare.Location = new System.Drawing.Point(12, 158);
            this.groupBoxCompare.Name = "groupBoxCompare";
            this.groupBoxCompare.Size = new System.Drawing.Size(860, 222);
            this.groupBoxCompare.TabIndex = 3;
            this.groupBoxCompare.TabStop = false;
            this.groupBoxCompare.Text = "File Integrity verifier";
            // 
            // buttonSaveHash
            // 
            this.buttonSaveHash.Font = new System.Drawing.Font("Wingdings", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.buttonSaveHash.Location = new System.Drawing.Point(747, 52);
            this.buttonSaveHash.Name = "buttonSaveHash";
            this.buttonSaveHash.Size = new System.Drawing.Size(83, 45);
            this.buttonSaveHash.TabIndex = 9;
            this.buttonSaveHash.Text = "<";
            this.buttonSaveHash.UseVisualStyleBackColor = true;
            this.buttonSaveHash.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // comboBoxHashMode
            // 
            this.comboBoxHashMode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxHashMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxHashMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxHashMode.FormattingEnabled = true;
            this.comboBoxHashMode.Items.AddRange(new object[] {
            "MD5",
            "SHA-256",
            "TIGER-192",
            "WHIRLPOOL"});
            this.comboBoxHashMode.Location = new System.Drawing.Point(41, 53);
            this.comboBoxHashMode.Name = "comboBoxHashMode";
            this.comboBoxHashMode.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comboBoxHashMode.Size = new System.Drawing.Size(163, 33);
            this.comboBoxHashMode.TabIndex = 8;
            this.comboBoxHashMode.SelectedIndexChanged += new System.EventHandler(this.comboBoxHashMode_SelectedIndexChanged);
            // 
            // buttonTXTBrowser
            // 
            this.buttonTXTBrowser.Location = new System.Drawing.Point(747, 99);
            this.buttonTXTBrowser.Name = "buttonTXTBrowser";
            this.buttonTXTBrowser.Size = new System.Drawing.Size(83, 45);
            this.buttonTXTBrowser.TabIndex = 6;
            this.buttonTXTBrowser.Text = "...";
            this.buttonTXTBrowser.UseVisualStyleBackColor = true;
            this.buttonTXTBrowser.Click += new System.EventHandler(this.buttonTXTBrowser_Click);
            // 
            // labelResultContext
            // 
            this.labelResultContext.AutoSize = true;
            this.labelResultContext.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResultContext.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelResultContext.Location = new System.Drawing.Point(221, 163);
            this.labelResultContext.Name = "labelResultContext";
            this.labelResultContext.Size = new System.Drawing.Size(318, 32);
            this.labelResultContext.TabIndex = 5;
            this.labelResultContext.Text = "Click \"Validate\" to compare...";
            // 
            // buttonCheck
            // 
            this.buttonCheck.Location = new System.Drawing.Point(41, 156);
            this.buttonCheck.Name = "buttonCheck";
            this.buttonCheck.Size = new System.Drawing.Size(132, 43);
            this.buttonCheck.TabIndex = 4;
            this.buttonCheck.Text = "Validate";
            this.buttonCheck.UseVisualStyleBackColor = true;
            this.buttonCheck.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Font = new System.Drawing.Font("Wingdings", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.labelResult.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.labelResult.Location = new System.Drawing.Point(161, 150);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(72, 58);
            this.labelResult.TabIndex = 4;
            this.labelResult.Text = "o";
            // 
            // labelCompareTo
            // 
            this.labelCompareTo.AutoSize = true;
            this.labelCompareTo.Location = new System.Drawing.Point(71, 108);
            this.labelCompareTo.Name = "labelCompareTo";
            this.labelCompareTo.Size = new System.Drawing.Size(143, 25);
            this.labelCompareTo.TabIndex = 3;
            this.labelCompareTo.Text = "Compare with";
            // 
            // groupBoxFile
            // 
            this.groupBoxFile.Controls.Add(this.progressBar1);
            this.groupBoxFile.Controls.Add(this.buttonFileBrowse);
            this.groupBoxFile.Controls.Add(this.textBoxFileBrowser);
            this.groupBoxFile.Controls.Add(this.buttonCalculateChecksum);
            this.groupBoxFile.Location = new System.Drawing.Point(12, 12);
            this.groupBoxFile.Name = "groupBoxFile";
            this.groupBoxFile.Size = new System.Drawing.Size(860, 140);
            this.groupBoxFile.TabIndex = 4;
            this.groupBoxFile.TabStop = false;
            this.groupBoxFile.Text = "Checksum Generator";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(41, 105);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(789, 12);
            this.progressBar1.TabIndex = 5;
            // 
            // buttonFileBrowse
            // 
            this.buttonFileBrowse.Location = new System.Drawing.Point(747, 48);
            this.buttonFileBrowse.Name = "buttonFileBrowse";
            this.buttonFileBrowse.Size = new System.Drawing.Size(83, 45);
            this.buttonFileBrowse.TabIndex = 4;
            this.buttonFileBrowse.Text = "...";
            this.buttonFileBrowse.UseVisualStyleBackColor = true;
            this.buttonFileBrowse.Click += new System.EventHandler(this.buttonFileBrowse_Click);
            // 
            // textBoxFileBrowser
            // 
            this.textBoxFileBrowser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFileBrowser.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBoxFileBrowser.Location = new System.Drawing.Point(182, 50);
            this.textBoxFileBrowser.Name = "textBoxFileBrowser";
            this.textBoxFileBrowser.Size = new System.Drawing.Size(559, 35);
            this.textBoxFileBrowser.TabIndex = 3;
            this.textBoxFileBrowser.Click += new System.EventHandler(this.fileBrowserOnClick);
            // 
            // buttonCalculateChecksum
            // 
            this.buttonCalculateChecksum.Location = new System.Drawing.Point(41, 49);
            this.buttonCalculateChecksum.Name = "buttonCalculateChecksum";
            this.buttonCalculateChecksum.Size = new System.Drawing.Size(135, 45);
            this.buttonCalculateChecksum.TabIndex = 0;
            this.buttonCalculateChecksum.Text = "Generate";
            this.buttonCalculateChecksum.UseVisualStyleBackColor = true;
            this.buttonCalculateChecksum.Click += new System.EventHandler(this.buttonCalculateChecksum_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 392);
            this.Controls.Add(this.groupBoxFile);
            this.Controls.Add(this.groupBoxCompare);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Lakeside CheckMate";
            this.groupBoxCompare.ResumeLayout(false);
            this.groupBoxCompare.PerformLayout();
            this.groupBoxFile.ResumeLayout(false);
            this.groupBoxFile.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxFileChecksum;
        private System.Windows.Forms.TextBox textBoxCompareWith;
        private System.Windows.Forms.GroupBox groupBoxCompare;
        private System.Windows.Forms.GroupBox groupBoxFile;
        private System.Windows.Forms.Button buttonCalculateChecksum;
        private System.Windows.Forms.TextBox textBoxFileBrowser;
        private System.Windows.Forms.Label labelCompareTo;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Button buttonCheck;
        private System.Windows.Forms.Label labelResultContext;
        private System.Windows.Forms.Button buttonFileBrowse;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button buttonTXTBrowser;
        private System.Windows.Forms.ComboBox comboBoxHashMode;
        private System.Windows.Forms.Button buttonSaveHash;
    }
}

