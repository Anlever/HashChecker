using HashChecker.Interface;
using System;
using System.IO;
using System.Security.Cryptography;

namespace HashChecker.Calculating
{
    internal class Calculating : ICalculating
    {
        public bool FileExists(string path)
        {
            return File.Exists(path);
        }

        public string ComputeMD5Checksum(string path)
        {
            using (FileStream fs = File.OpenRead(path))
            using (MD5 md5 = MD5.Create())
            {
                byte[] checkSum = md5.ComputeHash(fs);
                string result = BitConverter.ToString(checkSum).Replace("-", String.Empty);
                return result;
            }
        }

        public string ComputeSHA1Checksum(string path)
        {
            using (FileStream fs = File.OpenRead(path))
            using (SHA1 sha1 = SHA1.Create())
            {
                byte[] checkSum = sha1.ComputeHash(fs);
                string result = BitConverter.ToString(checkSum).Replace("-", String.Empty);
                return result;
            }
        }

        public string ComputeSHA256Checksum(string path)
        {
            using (FileStream fs = File.OpenRead(path))
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] checkSum = sha256.ComputeHash(fs);
                string result = BitConverter.ToString(checkSum).Replace("-", String.Empty);
                return result;
            }
        }
    }
}