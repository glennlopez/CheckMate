using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;
using System.Security.Cryptography;

namespace CheckMate
{
    public partial class MainForm : Form
    {
        // File Dialogs
        OpenFileDialog ofd_fileForChecksum = new OpenFileDialog();
        OpenFileDialog ofd_fileForCompare = new OpenFileDialog();
        string SHA256Hash = "";
        string MD5Hash = "";

        public MainForm()
        {
            InitializeComponent();

            // Default settings
            comboBoxHashMode.SelectedIndex = 1;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBoxFileChecksum.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // compare and show result to user
            if (textBoxCompareWith.Text == "" && textBoxFileChecksum.Text == "")
            {
                labelResult.Text = "o";
                labelResult.ForeColor = Color.Gray;
                labelResultContext.Text = "You're not comparing anything...";
                labelResultContext.ForeColor = Color.Gray;
            }
            else if (textBoxCompareWith.Text == "" || textBoxFileChecksum.Text == "")
            {
                labelResult.Text = "o";
                labelResult.ForeColor = Color.Gray;
                labelResultContext.Text = "Cannot validate hash. You're missing something.";
                labelResultContext.ForeColor = Color.Gray;
            }
            else if (textBoxCompareWith.Text == textBoxFileChecksum.Text)
            {
                labelResult.Text = "þ";
                labelResult.ForeColor = Color.Green;
                labelResultContext.Text = "Checksum comparison passed!";
                labelResultContext.ForeColor = Color.Green;
            }
            else if (textBoxCompareWith.Text == textBoxFileChecksum.Text.ToLower())
            {
                labelResult.Text = "þ";
                labelResult.ForeColor = Color.Green;
                labelResultContext.Text = "Checksum comparison passed!";
                labelResultContext.ForeColor = Color.Green;
            }
            else
            {
                labelResult.Text = "ý";
                labelResult.ForeColor = Color.Red;
                labelResultContext.Text = "WARNING: Checksum Failed!";
                labelResultContext.ForeColor = Color.Red;
            }
        }

        private void textBoxGeneratedOnClick(object sender, EventArgs e)
        {
            textBoxFileChecksum.Enabled = true;
        }

        private void fileBrowserOnClick(object sender, EventArgs e)
        {

        }

        // Hash function for generating SHA256 checksum
        private static string GetSHA256Checksum(Stream stream)
        {
            using (var bufferedStream = new BufferedStream(stream, 1024 * 32))
            {
                var sha = new SHA256Managed();
                byte[] checksum = sha.ComputeHash(bufferedStream);
                return BitConverter.ToString(checksum).Replace("-", String.Empty);
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            string filePath = e.Argument.ToString();

            byte[] buffer;              // Read parts of the file to buffer and hash those parts
            int bytesRead;              // Keeps track of the bytes read every time we enter the loop
            long size;                  // Holds the size of the file we are hashing
            long totalBytesRead = 0;    // Keeps track of the total bytes read so far


            // MD5 Work
            using (Stream file = File.OpenRead(filePath))
            {
                size = file.Length;     // Get the size of the file 

                // MD5 hashing method & progressbar
                using (HashAlgorithm MD5hasher = MD5.Create())
                {
                    do
                    {
                        // Md5 Hasher
                        buffer = new byte[4096];
                        bytesRead = file.Read(buffer,0, buffer.Length);
                        totalBytesRead += bytesRead;
                        MD5hasher.TransformBlock(buffer, 0, bytesRead, null, 0);

                        // Update the progressbar
                        backgroundWorker1.ReportProgress((int)((double)totalBytesRead / size * 100));
                    }
                    while (bytesRead != 0);

                    MD5hasher.TransformFinalBlock(buffer, 0, 0);
                    e.Result = MakeHashString(MD5hasher.Hash);
                }
            }

            // SHA256 Work
            var SHA256FileStream = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.Read);
            SHA256Hash = GetSHA256Checksum(SHA256FileStream);
        }

        // Helper method for converting byte array
        private static string MakeHashString(byte[] hashbytes)
        {
            StringBuilder hash = new StringBuilder(32); // 32 is the initial capacity for MD5

            foreach (byte b in hashbytes)
            {
                //hash.Append(b.ToString("X2").ToLower());
                hash.Append(b.ToString("X2"));
            }
            return hash.ToString();
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            // Update the progressbar
            progressBar1.Value = e.ProgressPercentage;
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            // Method to run after file has been hashed
            //MessageBox.Show(e.Result.ToString());
            //textBoxFileChecksum.Text = e.Result.ToString();

            // Store MD5 result to Global String
            MD5Hash = e.Result.ToString();

            // Update textBoxFileChecksum text
            if (comboBoxHashMode.SelectedIndex == 0)
            {
                textBoxFileChecksum.Text = MD5Hash;
            }
            if (comboBoxHashMode.SelectedIndex == 1)
            {
                textBoxFileChecksum.Text = SHA256Hash;
            }

            // Auto-validate hash file
            if (!(textBoxCompareWith.Text == "") && !(textBoxFileChecksum.Text == ""))
            {
                // Validate after hash file is loaded
                button1_Click(null, null);
            }
            else
            {
                // do nothing
            }

            // Set progress bar to 0 (background task is done)
            progressBar1.Value = 0;
        }

        // Calculate Checksum
        private void buttonCalculateChecksum_Click(object sender, EventArgs e)
        {

        //textBoxFileChecksum.Enabled = false;
        ofd_fileForChecksum.Title = "Calculate Checksum";

            // Open the file dialog for the user if textbox is emptyFileBrowser
            if (textBoxFileBrowser.Text == "")
            {
                if (ofd_fileForChecksum.ShowDialog() == DialogResult.OK)
                {
                    textBoxFileBrowser.Text = ofd_fileForChecksum.FileName;
                }
            }

            // Auto-validate: for MD5 file
            string HashFileDir = Path.GetDirectoryName(ofd_fileForChecksum.FileName);
            string HashFileName = Path.GetFileNameWithoutExtension(ofd_fileForChecksum.FileName);
            if (File.Exists(HashFileDir + @"\" + HashFileName + ".md5"))
            {
                DialogResult autovalidate = MessageBox.Show(HashFileName + ".md5 " + "was found in the same directory as " + Path.GetFileName(ofd_fileForChecksum.FileName) + "."
                    + " Would you like CheckMate to auto-validate " + Path.GetFileName(ofd_fileForChecksum.FileName) + "'s checksum" +
                    " using the existing MD5 hash-file?",
                    "Existing MD5 hash-file found!",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (autovalidate == System.Windows.Forms.DialogResult.Yes)
                {
                    comboBoxHashMode.SelectedIndex = 0;
                    textBoxCompareWith.Text = File.ReadAllText(HashFileDir + @"\" + HashFileName + ".md5");
                }
                else
                {
                    //debug - remove this after
                    MessageBox.Show("Selected: NO","debug msg");
                }
            }
            else
            {
                //debug - remove this after
                MessageBox.Show("HASH FILE NOT FOUND");
            }

            // Check if textbox is empty before running the checksum calculation
            if (!(textBoxFileBrowser.Text == ""))
            {
                // Run the background worker for MD5 hashing
                backgroundWorker1.RunWorkerAsync(textBoxFileBrowser.Text);
            }
            else
            {
                // Do Nothing...
                // Optional: alert user there is nothing in the text area
            }



        }

        private void buttonFileBrowse_Click(object sender, EventArgs e)
        {
            ofd_fileForChecksum.Title = "Calculate Checksum";
            if (ofd_fileForChecksum.ShowDialog() == DialogResult.OK)
            {
                textBoxFileBrowser.Text = ofd_fileForChecksum.FileName;
            }
            
        }

        private void buttonTXTBrowser_Click(object sender, EventArgs e)
        {

            if (comboBoxHashMode.Text == "MD5")
            {
                ofd_fileForCompare.Title = "Open MD5 hash file";
                ofd_fileForCompare.Filter = "MD5|*.md5";
            }
            if (comboBoxHashMode.Text == "SHA-256")
            {
                ofd_fileForCompare.Title = "Open SHA-256 hash file";
                ofd_fileForCompare.Filter = "SHA-256|*.sha2";
            }

            // Open File Dialog
            if (ofd_fileForCompare.ShowDialog() == DialogResult.OK)
            {
                // read file content and place it in "textBoxCompareWith"
                textBoxCompareWith.Text = File.ReadAllText(ofd_fileForCompare.FileName);

                // Auto-validate hash file
                if (!(textBoxCompareWith.Text == "") && !(textBoxFileChecksum.Text == ""))
                {
                    // Validate after hash file is loaded
                    button1_Click(null,null);
                }
                else
                {
                    // do nothing
                }
            }

        }

        // Saving hash
        private void button1_Click_1(object sender, EventArgs e)
        {
            string filePathDir = "";
            string fileName = "";
            if (!(textBoxFileBrowser.Text == ""))
            {
                filePathDir = Path.GetDirectoryName(textBoxFileBrowser.Text);
                fileName = Path.GetFileNameWithoutExtension(textBoxFileBrowser.Text);
            }
            else
            {
                // do this if textBoxFileBrowser.Text is empty
            }


            //Save File Dialog Settings
            SaveFileDialog sfd_saveHash = new SaveFileDialog();
            if (comboBoxHashMode.Text == "MD5")
            {
                sfd_saveHash.Title = "Save MD5 hash";
                sfd_saveHash.Filter = "MD5|*.md5";
            }
            else if(comboBoxHashMode.Text == "SHA-256")
            {
                sfd_saveHash.Title = "Save SHA-256 hash";
                sfd_saveHash.Filter = "SHA-256|*.sha2";
            }

            sfd_saveHash.FileName = fileName.ToString();
            sfd_saveHash.InitialDirectory = filePathDir;
            sfd_saveHash.OverwritePrompt = true;

            // Save File Dialog
            if (textBoxFileChecksum.Text == "")
            {
                MessageBox.Show("Error: Theres no checksum to save.");
            }
            else
            {
                if (sfd_saveHash.ShowDialog() == DialogResult.OK)
                {
                    using (StreamWriter newTask = new StreamWriter(sfd_saveHash.FileName, false))
                    {
                        newTask.Write(textBoxFileChecksum.Text);
                    }
                }
            }
        }

        // Combobox selection
        private void comboBoxHashMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            // MD5 Selected
            if (comboBoxHashMode.SelectedIndex == 0)
            {
                textBoxFileChecksum.Text = MD5Hash;
            }

            // SHA256 Selected
            if (comboBoxHashMode.SelectedIndex == 1)
            {
                textBoxFileChecksum.Text = SHA256Hash;
            }
        }
    }
}
