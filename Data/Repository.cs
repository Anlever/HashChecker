using HashChecker.Interface;
using System.IO;
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
    }
}
