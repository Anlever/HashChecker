namespace HashChecker.Interface
{
    internal interface ICalculating
    {
        bool FileExists(string path);
        string ComputeMD5Checksum(string path);
        string ComputeSHA1Checksum(string path);
        string ComputeSHA256Checksum(string path);
    }
}
