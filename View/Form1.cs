using HashChecker.Data;
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
        private IRepository repository;
        string[] filePaths;

        public Form1()
        {
            InitializeComponent();
            calculating = new Calculating.Calculating();
            repository = new Repository();
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
            if (filePaths != null)
            {                
                    try
                    {
                        richTextBox1.Text = calculating.ComputeHashSumsFiles(filePaths, comboBox1.Text);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Не получилось вычислить хэш сумму: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                
            }
            else
            {
                MessageBox.Show("Файлы не выбраны", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
             
        }
        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            filePaths = repository.OpenExplorerAndGetFilePath();
            string[] fileNames = repository.GetFileNames(filePaths);
            richTextBox2.Text = string.Join("\n", fileNames);
            int countFilePaths = repository.CountSelectedFiles(filePaths);
            label2.Text = "Загружено " + countFilePaths.ToString() + ( countFilePaths == 1 ? " файл" : countFilePaths <= 4 ? " файла" : " файлов");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
