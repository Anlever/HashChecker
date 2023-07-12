using System.Windows.Forms;

namespace HashChecker.Interface
{
    internal interface IRepository
    {
        bool FileExists(string path);
        string[] OpenExplorerAndGetFilePath();
        int CountSelectedFiles(string[] selectedFiles);
        string[] GetFileNames(string[] filePaths);
    }
}
