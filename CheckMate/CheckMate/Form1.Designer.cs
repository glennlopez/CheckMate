namespace CheckMate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBoxFileChecksum = new System.Windows.Forms.TextBox();
            this.textBoxCompareWith = new System.Windows.Forms.TextBox();
            this.labelGeneratedChecksum = new System.Windows.Forms.Label();
            this.groupBoxCompare = new System.Windows.Forms.GroupBox();
            this.buttonCheck = new System.Windows.Forms.Button();
            this.labelResult = new System.Windows.Forms.Label();
            this.labelCompareTo = new System.Windows.Forms.Label();
            this.groupBoxFile = new System.Windows.Forms.GroupBox();
            this.textBoxFileBrowser = new System.Windows.Forms.TextBox();
            this.buttonCalculateChecksum = new System.Windows.Forms.Button();
            this.labelResultContext = new System.Windows.Forms.Label();
            this.buttonFileBrowse = new System.Windows.Forms.Button();
            this.groupBoxCompare.SuspendLayout();
            this.groupBoxFile.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxFileChecksum
            // 
            this.textBoxFileChecksum.Location = new System.Drawing.Point(179, 53);
            this.textBoxFileChecksum.Name = "textBoxFileChecksum";
            this.textBoxFileChecksum.Size = new System.Drawing.Size(562, 31);
            this.textBoxFileChecksum.TabIndex = 0;
            this.textBoxFileChecksum.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBoxCompareWith
            // 
            this.textBoxCompareWith.Location = new System.Drawing.Point(179, 100);
            this.textBoxCompareWith.Name = "textBoxCompareWith";
            this.textBoxCompareWith.Size = new System.Drawing.Size(562, 31);
            this.textBoxCompareWith.TabIndex = 1;
            // 
            // labelGeneratedChecksum
            // 
            this.labelGeneratedChecksum.AutoSize = true;
            this.labelGeneratedChecksum.Location = new System.Drawing.Point(60, 57);
            this.labelGeneratedChecksum.Name = "labelGeneratedChecksum";
            this.labelGeneratedChecksum.Size = new System.Drawing.Size(113, 25);
            this.labelGeneratedChecksum.TabIndex = 2;
            this.labelGeneratedChecksum.Text = "Generated";
            this.labelGeneratedChecksum.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBoxCompare
            // 
            this.groupBoxCompare.Controls.Add(this.labelResultContext);
            this.groupBoxCompare.Controls.Add(this.buttonCheck);
            this.groupBoxCompare.Controls.Add(this.labelResult);
            this.groupBoxCompare.Controls.Add(this.labelCompareTo);
            this.groupBoxCompare.Controls.Add(this.textBoxFileChecksum);
            this.groupBoxCompare.Controls.Add(this.labelGeneratedChecksum);
            this.groupBoxCompare.Controls.Add(this.textBoxCompareWith);
            this.groupBoxCompare.Location = new System.Drawing.Point(12, 162);
            this.groupBoxCompare.Name = "groupBoxCompare";
            this.groupBoxCompare.Size = new System.Drawing.Size(860, 222);
            this.groupBoxCompare.TabIndex = 3;
            this.groupBoxCompare.TabStop = false;
            this.groupBoxCompare.Text = "Compare Checksums";
            // 
            // buttonCheck
            // 
            this.buttonCheck.Location = new System.Drawing.Point(41, 156);
            this.buttonCheck.Name = "buttonCheck";
            this.buttonCheck.Size = new System.Drawing.Size(132, 43);
            this.buttonCheck.TabIndex = 4;
            this.buttonCheck.Text = "Compare";
            this.buttonCheck.UseVisualStyleBackColor = true;
            this.buttonCheck.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Font = new System.Drawing.Font("Wingdings", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.labelResult.Location = new System.Drawing.Point(169, 150);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(72, 58);
            this.labelResult.TabIndex = 4;
            this.labelResult.Text = "ý";
            this.labelResult.Click += new System.EventHandler(this.labelResult_Click);
            // 
            // labelCompareTo
            // 
            this.labelCompareTo.AutoSize = true;
            this.labelCompareTo.Location = new System.Drawing.Point(77, 106);
            this.labelCompareTo.Name = "labelCompareTo";
            this.labelCompareTo.Size = new System.Drawing.Size(96, 25);
            this.labelCompareTo.TabIndex = 3;
            this.labelCompareTo.Text = "Supplied";
            // 
            // groupBoxFile
            // 
            this.groupBoxFile.Controls.Add(this.buttonFileBrowse);
            this.groupBoxFile.Controls.Add(this.textBoxFileBrowser);
            this.groupBoxFile.Controls.Add(this.buttonCalculateChecksum);
            this.groupBoxFile.Location = new System.Drawing.Point(12, 12);
            this.groupBoxFile.Name = "groupBoxFile";
            this.groupBoxFile.Size = new System.Drawing.Size(860, 120);
            this.groupBoxFile.TabIndex = 4;
            this.groupBoxFile.TabStop = false;
            this.groupBoxFile.Text = "Calculate Target File Checksum";
            // 
            // textBoxFileBrowser
            // 
            this.textBoxFileBrowser.Location = new System.Drawing.Point(182, 48);
            this.textBoxFileBrowser.Name = "textBoxFileBrowser";
            this.textBoxFileBrowser.Size = new System.Drawing.Size(559, 31);
            this.textBoxFileBrowser.TabIndex = 3;
            // 
            // buttonCalculateChecksum
            // 
            this.buttonCalculateChecksum.Location = new System.Drawing.Point(41, 46);
            this.buttonCalculateChecksum.Name = "buttonCalculateChecksum";
            this.buttonCalculateChecksum.Size = new System.Drawing.Size(135, 43);
            this.buttonCalculateChecksum.TabIndex = 0;
            this.buttonCalculateChecksum.Text = "Generate";
            this.buttonCalculateChecksum.UseVisualStyleBackColor = true;
            // 
            // labelResultContext
            // 
            this.labelResultContext.AutoSize = true;
            this.labelResultContext.Location = new System.Drawing.Point(237, 166);
            this.labelResultContext.Name = "labelResultContext";
            this.labelResultContext.Size = new System.Drawing.Size(287, 25);
            this.labelResultContext.TabIndex = 5;
            this.labelResultContext.Text = "Click Compare when ready...";
            // 
            // buttonFileBrowse
            // 
            this.buttonFileBrowse.Location = new System.Drawing.Point(747, 46);
            this.buttonFileBrowse.Name = "buttonFileBrowse";
            this.buttonFileBrowse.Size = new System.Drawing.Size(59, 43);
            this.buttonFileBrowse.TabIndex = 4;
            this.buttonFileBrowse.Text = "...";
            this.buttonFileBrowse.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 416);
            this.Controls.Add(this.groupBoxFile);
            this.Controls.Add(this.groupBoxCompare);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Lakeside CheckMate (SHA-256)";
            this.groupBoxCompare.ResumeLayout(false);
            this.groupBoxCompare.PerformLayout();
            this.groupBoxFile.ResumeLayout(false);
            this.groupBoxFile.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxFileChecksum;
        private System.Windows.Forms.TextBox textBoxCompareWith;
        private System.Windows.Forms.Label labelGeneratedChecksum;
        private System.Windows.Forms.GroupBox groupBoxCompare;
        private System.Windows.Forms.GroupBox groupBoxFile;
        private System.Windows.Forms.Button buttonCalculateChecksum;
        private System.Windows.Forms.TextBox textBoxFileBrowser;
        private System.Windows.Forms.Label labelCompareTo;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Button buttonCheck;
        private System.Windows.Forms.Label labelResultContext;
        private System.Windows.Forms.Button buttonFileBrowse;
    }
}

