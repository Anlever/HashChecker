using HashChecker.Data;
using HashChecker.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Text.RegularExpressions;
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
                if (comboBox1.SelectedIndex != -1)
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
                    MessageBox.Show("Выберите тип шифрования", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            FileLength.Text = (countFilePaths == 1 ? "Загружен " : "Загружено ") + countFilePaths.ToString() + ( countFilePaths == 1 ? " файл" : countFilePaths <= 4 ? " файла" : " файлов");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            filePaths = repository.OpenExplorerAndGetFilePath();
            string[] fileNames = repository.GetFileNames(filePaths);
            richTextBox3.Text = string.Join("\n", fileNames);
            int countFilePaths = repository.CountSelectedFiles(filePaths);
            label5.Text = (countFilePaths == 1 ? "Загружен " : "Загружено ") + countFilePaths.ToString() + (countFilePaths == 1 ? " файл" : countFilePaths <= 4 ? " файла" : " файлов");
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            bool TextCheck = repository.HashCheck(richTextBox4);
            if (TextCheck == true)
            {
                label8.Text = "Введены некорректные символы в хэш сумму";
                return;
            }
            else
            {
                label8.Text = string.Empty;
            }

            string hashsums = "";
            if (filePaths != null)
            {

                if (comboBox2.SelectedIndex != -1)
                {
                    try
                    {
                        hashsums = calculating.ComputeHashSumsFiles(filePaths, comboBox2.Text);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Не получилось вычислить хэш сумму: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Выберите тип шифрования", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Файлы не выбраны", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (richTextBox4.Text == hashsums)
            {
                MessageBox.Show("Хэш суммы равны", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                MessageBox.Show("Хэш суммы неравны", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            

        }

        private void richTextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
