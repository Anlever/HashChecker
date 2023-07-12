namespace HashChecker.Interface
{
    internal interface ICalculating
    {
        
        string ComputeMD5Checksum(string path);
        string ComputeSHA1Checksum(string path);
        string ComputeSHA256Checksum(string path);
        string ComputeHashSumsFiles(string[] FilePaths, string TypeHash);
    }
}
