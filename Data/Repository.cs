using HashChecker.Interface;
using System.Drawing;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HashChecker.Data
{
    internal class Repository : IRepository
    {
        public bool FileExists(string path)
        {
            return File.Exists(path);
        }

        public string[] OpenExplorerAndGetFilePath()
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "All Files (*.*)|*.*";
                openFileDialog.Multiselect = true;
                openFileDialog.RestoreDirectory = true;
                openFileDialog.ShowDialog();

                return openFileDialog.FileNames;
            }
        }
        public string[] GetFileNames(string[] filePaths) {
            string[] fileNames = new string[filePaths.Length];
            for (int i = 0; i < fileNames.Length; i++)
            {
                fileNames[i] = Path.GetFileName(filePaths[i]);
            }
            return fileNames;
        }
        public int CountSelectedFiles(string[] selectedFiles){
            return selectedFiles.Length;
        }

        public bool HashCheck(RichTextBox richTextBox4)
        {
            bool TextCheck = false;
            string text = richTextBox4.Text;

            // Сбрасываем цвет фона для всего текста
            richTextBox4.SelectAll();
            richTextBox4.SelectionBackColor = richTextBox4.BackColor;

            // Определяем паттерн регулярного выражения
            string pattern = "[^A-Za-z0-9]";

            // Применяем регулярное выражение к тексту
            MatchCollection matches = Regex.Matches(text, pattern);
            if (matches.Count > 0) { 
                TextCheck = true;
            }

            // Проходимся по каждому совпадению
            foreach (Match match in matches)
            {
                int startIndex = match.Index;
                int length = match.Length;

                richTextBox4.Select(startIndex, length); // Выделяем символы для форматирования
                richTextBox4.SelectionBackColor = Color.Red; // Устанавливаем красный цвет фона
            }

            // Снимаем выделение
            richTextBox4.Select(richTextBox4.Text.Length, 0);
            richTextBox4.SelectionBackColor = Color.White; // Устанавливаем красный цвет фона

            return TextCheck;
        }
    }
}
