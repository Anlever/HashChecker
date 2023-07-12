using HashChecker.Data;
using HashChecker.Interface;
using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HashChecker.Calculating
{
    internal class Calculating : ICalculating
    {
        
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
        public string ComputeHashSumsFiles(string[] FilePaths, string TypeHash){
            List<string> HashSumsList = new List<string>();
            for (int i = 0; i < FilePaths.Length; i++)
            {
                switch (TypeHash)
                {
                    case "MD5":
                        HashSumsList.Add(ComputeMD5Checksum(FilePaths[i])); break;
                    case "SHA-1":
                        HashSumsList.Add(ComputeSHA1Checksum(FilePaths[i])); break;
                    case "SHA-256":
                        HashSumsList.Add(ComputeSHA256Checksum(FilePaths[i])); break;
                }
            }
            string HashSums = string.Join("\n", HashSumsList);
            return HashSums;
        }
    }
}