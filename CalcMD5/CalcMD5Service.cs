using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Security.Cryptography;

namespace CalcMD5
{
    class CalcMD5Service
    {
        private const int READ_LIMIT = 4096;

        public static String GetMD5Hash(String filename)
        {
            var data = new List<byte>();
            using (BinaryReader br = new BinaryReader(File.OpenRead(filename)))
            {
                data.AddRange(br.ReadBytes(READ_LIMIT));
            }

            var md5CryptoServiceProvider = new MD5CryptoServiceProvider();
            var md5Hash = md5CryptoServiceProvider.ComputeHash(data.ToArray<byte>());

            var buff = new StringBuilder();
            for (int i = 0, size = md5Hash.Length; i < size; i++)
            {
                buff.Append(md5Hash[i].ToString("x2"));
            }

            return buff.ToString();
        }
    }
}
