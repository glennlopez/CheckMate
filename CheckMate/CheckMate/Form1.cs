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

/* Tutorials used:
 *  MD5 - https://www.youtube.com/watch?v=9MJAUL7G49w
 *  SHA - http://peterkellner.net/2010/11/24/efficiently-generating-sha256-checksum-for-files-using-csharp/
 */

namespace CheckMate
{
    public partial class MainForm : Form
    {
        // File Dialogs
        OpenFileDialog ofd_fileForChecksum = new OpenFileDialog();
        OpenFileDialog ofd_fileForCompare = new OpenFileDialog();

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
                labelResultContext.Text = "dude... you're not comparing anything v_v'";
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

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            string filePath = e.Argument.ToString();

            byte[] buffer;              // Read parts of the file to buffer and hash those parts
            int bytesRead;              // Keeps track of the bytes read every time we enter the loop
            long size;                  // Holds the size of the file we are hashing
            long totalBytesRead = 0;    // Keeps track of the total bytes read so far

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

        }

        //helper method for converting byte array
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
            textBoxFileChecksum.Text = e.Result.ToString();
            progressBar1.Value = 0;
        }

        // Calculate Checksum
        private void buttonCalculateChecksum_Click(object sender, EventArgs e)
        {
            // TODO: check if there is a filename.md5 or filename.sha
            // if it exists in the same dir, paste the hash string to textBoxCompareWith
            // and calculate the file's checksum, then auto "Valudate" for the user

            // NOTE: alert the user that a filename.md5 or filename.sha was found
            // and that the program will auto-validate the file after the checksum is calculated
            // "Checksum file found!"
            // "A checksum file for (FILE NAME) already exists in the same directory, would you like to auto-validate
            // (FILE NAME)'s integrity?" 

            textBoxFileChecksum.Enabled = false;
            ofd_fileForChecksum.Title = "Calculate Checksum";

            // Open the file dialog for the user if textbox is empty
            if (textBoxFileBrowser.Text == "")
            {
                if (ofd_fileForChecksum.ShowDialog() == DialogResult.OK)
                {
                    textBoxFileBrowser.Text = ofd_fileForChecksum.FileName;
                }
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
            //TODO: read file content and place it in "textBoxCompareWith"
            

            if (comboBoxHashMode.Text == "MD5")
            {
                ofd_fileForCompare.Title = "Open MD5 hash file";
                ofd_fileForCompare.Filter = "MD5|*.md5";
            }
            else if (comboBoxHashMode.Text == "SHA-256")
            {
                ofd_fileForCompare.Title = "Open SHA-256 hash file";
                ofd_fileForCompare.Filter = "SHA-256|*.sha2";
            }
            else if (comboBoxHashMode.Text == "TIGER-192")
            {
                ofd_fileForCompare.Title = "Open TIGER-192 hash file";
                ofd_fileForCompare.Filter = "TIGER-192|*.tiger";
            }
            else if (comboBoxHashMode.Text == "WHIRLPOOL")
            {
                ofd_fileForCompare.Title = "Open WHIRLPOOL hash file";
                ofd_fileForCompare.Filter = "WHIRLPOOL|*.wpool";
            }

            if (ofd_fileForCompare.ShowDialog() == DialogResult.OK)
            {
                // debug - replace this with what ever text is in the .md5 or .txt
                textBoxCompareWith.Text = ofd_fileForCompare.FileName;

            }
            
            
        }

        // Saving hash
        private void button1_Click_1(object sender, EventArgs e)
        {
            string filePathDir = Path.GetDirectoryName(textBoxFileBrowser.Text);
            string fileName = Path.GetFileNameWithoutExtension(textBoxFileBrowser.Text);

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
            else if (comboBoxHashMode.Text == "TIGER-192")
            {
                sfd_saveHash.Title = "Save TIGER-192 hash";
                sfd_saveHash.Filter = "TIGER-192|*.tiger";
            }
            else if (comboBoxHashMode.Text == "WHIRLPOOL")
            {
                sfd_saveHash.Title = "Save WHIRLPOOL hash";
                sfd_saveHash.Filter = "WHIRLPOOL|*.wpool";
            }

            sfd_saveHash.FileName = fileName;
            sfd_saveHash.InitialDirectory = filePathDir;

            // Save File Dialog
            if (sfd_saveHash.ShowDialog() == DialogResult.OK)
            {
                using (Stream s = File.Open(sfd_saveHash.FileName, FileMode.CreateNew))
                using (StreamWriter sw = new StreamWriter(s))
                {
                    sw.Write(textBoxFileChecksum.Text);
                }
            }

            
           
        }

        // Combobox selection
        private void comboBoxHashMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            // TODO: anytime a selection is made, the textBoxFileBrowser, and textBoxFileChecksum need to be empty

            if (comboBoxHashMode.SelectedIndex == 2)
            {
                MessageBox.Show("Sorry, the " + comboBoxHashMode.Text + 
                    " hash function is not ready.", "Oops! That's not supported yet.");
            }
            else if (comboBoxHashMode.SelectedIndex == 3)
            {
                MessageBox.Show("Sorry, the " + comboBoxHashMode.Text +
                    " hash function is not ready.", "Oops! That's not supported yet.");
            }
        }
    }
}
