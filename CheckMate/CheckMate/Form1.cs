﻿using System;
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
            // compare generated checksum with supplied checksum
            if (textBoxCompareWith.Text == textBoxFileChecksum.Text)
            {
                labelResult.Text = "þ";
                labelResultContext.Text = "Checksum comparison passed!";
            }
            else
            {
                labelResult.Text = "ý";
                labelResultContext.Text = "WARNING: Checksum Failed!";
            }
        }
    }
}