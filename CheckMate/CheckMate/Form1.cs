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
    public partial class Form1 : Form
    {
        // File Dialogs
        OpenFileDialog ofd_fileForChecksum = new OpenFileDialog();
        OpenFileDialog ofd_fileForCompare = new OpenFileDialog();

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBoxFileChecksum.Enabled = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void labelResult_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // compare and show result to user
            if (textBoxCompareWith.Text == "" && textBoxFileChecksum.Text == "")
            {
                labelResult.Text = "o";
                labelResult.ForeColor = Color.Gray;
                labelResultContext.Text = "... you're not comparing anything?";
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

        private void suppliedTextBoxOnClick(object sender, EventArgs e)
        {

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
            textBoxFileChecksum.Enabled = false;

            // if textbox is empty, open the file dialog for the user
            if (textBoxFileBrowser.Text == "")
            {
                if (ofd_fileForChecksum.ShowDialog() == DialogResult.OK)
                {
                    textBoxFileBrowser.Text = ofd_fileForChecksum.FileName;
                }
            }

            // run the background worker for MD5 hashing
            backgroundWorker1.RunWorkerAsync(textBoxFileBrowser.Text);
        }


        private void buttonFileBrowse_Click(object sender, EventArgs e)
        {
            if (ofd_fileForChecksum.ShowDialog() == DialogResult.OK)
            {
                textBoxFileBrowser.Text = ofd_fileForChecksum.FileName;
            }
            
        }

        private void buttonTXTBrowser_Click(object sender, EventArgs e)
        {
            MessageBox.Show("For now, you can just copy-paste the hash string you'd like to compare " +
                "into the textbox area.", "Not yet supported!");

            /*
            ofd_fileForCompare.Filter = "MD5|*.md5|TXT|*.txt";
            if (ofd_fileForCompare.ShowDialog() == DialogResult.OK)
            {
                // debug - replace this with what ever text is in the .md5 or .txt
                textBoxCompareWith.Text = ofd_fileForCompare.FileName;

            }
            */
            
        }
    }
}
