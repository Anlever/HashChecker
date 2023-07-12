using System.Windows.Forms;

namespace HashChecker.Interface
{
    internal interface IRepository
    {
        bool HashCheck(RichTextBox richTextBox4);
        bool FileExists(string path);
        string[] OpenExplorerAndGetFilePath();
        string LastElementDelete(string HashSums);
        int CountSelectedFiles(string[] selectedFiles);
        string[] GetFileNames(string[] filePaths);
    }
}
