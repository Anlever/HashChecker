using System.Windows.Forms;

namespace HashChecker.Interface
{
    internal interface IRepository
    {
        bool HashCheck(RichTextBox richTextBox4);
        bool FileExists(string path);
        string[] OpenExplorerAndGetFilePath();
        int CountSelectedFiles(string[] selectedFiles);
        string[] GetFileNames(string[] filePaths);
    }
}
