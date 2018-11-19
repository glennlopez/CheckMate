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
            this.textBoxFileChecksum = new System.Windows.Forms.TextBox();
            this.textBoxCompareWith = new System.Windows.Forms.TextBox();
            this.labelGeneratedChecksum = new System.Windows.Forms.Label();
            this.groupBoxCompare = new System.Windows.Forms.GroupBox();
            this.groupBoxFile = new System.Windows.Forms.GroupBox();
            this.buttonCalculateChecksum = new System.Windows.Forms.Button();
            this.buttonFileBrowser = new System.Windows.Forms.Button();
            this.textBoxFileBrowser = new System.Windows.Forms.TextBox();
            this.labelCompareTo = new System.Windows.Forms.Label();
            this.labelResult = new System.Windows.Forms.Label();
            this.buttonCheck = new System.Windows.Forms.Button();
            this.groupBoxCompare.SuspendLayout();
            this.groupBoxFile.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxFileChecksum
            // 
            this.textBoxFileChecksum.Location = new System.Drawing.Point(207, 108);
            this.textBoxFileChecksum.Name = "textBoxFileChecksum";
            this.textBoxFileChecksum.Size = new System.Drawing.Size(452, 31);
            this.textBoxFileChecksum.TabIndex = 0;
            this.textBoxFileChecksum.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBoxCompareWith
            // 
            this.textBoxCompareWith.Location = new System.Drawing.Point(207, 174);
            this.textBoxCompareWith.Name = "textBoxCompareWith";
            this.textBoxCompareWith.Size = new System.Drawing.Size(452, 31);
            this.textBoxCompareWith.TabIndex = 1;
            // 
            // labelGeneratedChecksum
            // 
            this.labelGeneratedChecksum.AutoSize = true;
            this.labelGeneratedChecksum.Location = new System.Drawing.Point(19, 111);
            this.labelGeneratedChecksum.Name = "labelGeneratedChecksum";
            this.labelGeneratedChecksum.Size = new System.Drawing.Size(154, 25);
            this.labelGeneratedChecksum.TabIndex = 2;
            this.labelGeneratedChecksum.Text = "File Checksum";
            this.labelGeneratedChecksum.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBoxCompare
            // 
            this.groupBoxCompare.Controls.Add(this.buttonCheck);
            this.groupBoxCompare.Controls.Add(this.labelResult);
            this.groupBoxCompare.Controls.Add(this.labelCompareTo);
            this.groupBoxCompare.Controls.Add(this.textBoxFileChecksum);
            this.groupBoxCompare.Controls.Add(this.labelGeneratedChecksum);
            this.groupBoxCompare.Controls.Add(this.textBoxCompareWith);
            this.groupBoxCompare.Location = new System.Drawing.Point(129, 210);
            this.groupBoxCompare.Name = "groupBoxCompare";
            this.groupBoxCompare.Size = new System.Drawing.Size(876, 306);
            this.groupBoxCompare.TabIndex = 3;
            this.groupBoxCompare.TabStop = false;
            this.groupBoxCompare.Text = "Compare Checksums";
            // 
            // groupBoxFile
            // 
            this.groupBoxFile.Controls.Add(this.textBoxFileBrowser);
            this.groupBoxFile.Controls.Add(this.buttonFileBrowser);
            this.groupBoxFile.Controls.Add(this.buttonCalculateChecksum);
            this.groupBoxFile.Location = new System.Drawing.Point(129, 44);
            this.groupBoxFile.Name = "groupBoxFile";
            this.groupBoxFile.Size = new System.Drawing.Size(860, 120);
            this.groupBoxFile.TabIndex = 4;
            this.groupBoxFile.TabStop = false;
            this.groupBoxFile.Text = "Target File";
            // 
            // buttonCalculateChecksum
            // 
            this.buttonCalculateChecksum.Location = new System.Drawing.Point(588, 48);
            this.buttonCalculateChecksum.Name = "buttonCalculateChecksum";
            this.buttonCalculateChecksum.Size = new System.Drawing.Size(232, 43);
            this.buttonCalculateChecksum.TabIndex = 0;
            this.buttonCalculateChecksum.Text = "Generate Checksum";
            this.buttonCalculateChecksum.UseVisualStyleBackColor = true;
            // 
            // buttonFileBrowser
            // 
            this.buttonFileBrowser.Location = new System.Drawing.Point(450, 48);
            this.buttonFileBrowser.Name = "buttonFileBrowser";
            this.buttonFileBrowser.Size = new System.Drawing.Size(132, 43);
            this.buttonFileBrowser.TabIndex = 1;
            this.buttonFileBrowser.Text = "Browse";
            this.buttonFileBrowser.UseVisualStyleBackColor = true;
            // 
            // textBoxFileBrowser
            // 
            this.textBoxFileBrowser.Location = new System.Drawing.Point(68, 54);
            this.textBoxFileBrowser.Name = "textBoxFileBrowser";
            this.textBoxFileBrowser.Size = new System.Drawing.Size(376, 31);
            this.textBoxFileBrowser.TabIndex = 3;
            // 
            // labelCompareTo
            // 
            this.labelCompareTo.AutoSize = true;
            this.labelCompareTo.Location = new System.Drawing.Point(19, 180);
            this.labelCompareTo.Name = "labelCompareTo";
            this.labelCompareTo.Size = new System.Drawing.Size(148, 25);
            this.labelCompareTo.TabIndex = 3;
            this.labelCompareTo.Text = "Compare With";
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Font = new System.Drawing.Font("Wingdings", 25.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.labelResult.Location = new System.Drawing.Point(725, 128);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(95, 77);
            this.labelResult.TabIndex = 4;
            this.labelResult.Text = "ý";
            this.labelResult.Click += new System.EventHandler(this.labelResult_Click);
            // 
            // buttonCheck
            // 
            this.buttonCheck.Location = new System.Drawing.Point(370, 239);
            this.buttonCheck.Name = "buttonCheck";
            this.buttonCheck.Size = new System.Drawing.Size(132, 43);
            this.buttonCheck.TabIndex = 4;
            this.buttonCheck.Text = "Compare";
            this.buttonCheck.UseVisualStyleBackColor = true;
            this.buttonCheck.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 552);
            this.Controls.Add(this.groupBoxFile);
            this.Controls.Add(this.groupBoxCompare);
            this.Name = "Form1";
            this.Text = "CheckMate";
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
        private System.Windows.Forms.Button buttonFileBrowser;
        private System.Windows.Forms.TextBox textBoxFileBrowser;
        private System.Windows.Forms.Label labelCompareTo;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.Button buttonCheck;
    }
}

