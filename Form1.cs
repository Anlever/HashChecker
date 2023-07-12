using HashChecker.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HashChecker
{
    public partial class Form1 : Form
    {
        private ICalculating calculating;

        public Form1()
        {
            InitializeComponent();
            calculating = new Calculating.Calculating();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string filePath = textBox1.Text;
            if (calculating.FileExists(filePath))
            {
                try
                {
                    string hashSum = calculating.ComputeMD5Checksum(filePath);
                    richTextBox1.Text = hashSum;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error calculating hash: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("File does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
