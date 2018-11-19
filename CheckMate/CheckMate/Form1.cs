using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckMate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

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
            if (textBoxCompareWith.Text == textBoxFileChecksum.Text)
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
            textBoxCompareWith.Text = "";
            textBoxCompareWith.ForeColor = Color.Black;
        }

        private void textBoxGeneratedOnClick(object sender, EventArgs e)
        {
            textBoxFileChecksum.Text = "";
            textBoxFileChecksum.ForeColor = Color.Black;
        }

        private void fileBrowserOnClick(object sender, EventArgs e)
        {
            textBoxFileBrowser.Text = "";
            textBoxFileBrowser.ForeColor = Color.Black;
        }
    }
}
