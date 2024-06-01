using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace EBookLib01.Services
{
    public class HashManager
    {
        public static string GetHash(string passw)
        {
            //string result = string.Empty;
            MD5 md5 = MD5.Create();

            byte[] data = Encoding.UTF8.GetBytes(passw);
            byte[] hash = md5.ComputeHash(data);

            StringBuilder sb = new StringBuilder();
            foreach (byte b in hash)
            {
                sb.Append(b.ToString("x2"));
            }
            return sb.ToString();

        }
    }
}
