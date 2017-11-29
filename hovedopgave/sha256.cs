using System;
using System.Security.Cryptography;
using System.Text;

namespace hovedopgave
{
    public class sha256 : IHashFunction
    {
        private SHA256 mySHA256;
        public sha256()
        {
            mySHA256 = SHA256Managed.Create();
        }
        public string hash(string str)
        {
            byte[] data = mySHA256.ComputeHash(Encoding.UTF8.GetBytes(str));
            StringBuilder sBuilder = new StringBuilder();
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }
            return sBuilder.ToString();
            //return Encoding.UTF8.GetString(mySHA256.ComputeHash(Encoding.UTF8.GetBytes(str)));
        }

        public string hash32(string str)
        {
            byte[] data = mySHA256.ComputeHash(Encoding.UTF32.GetBytes(str));
            StringBuilder sBuilder = new StringBuilder();
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }
            return sBuilder.ToString();
            //return Encoding.UTF32.GetString(mySHA256.ComputeHash(Encoding.UTF32.GetBytes(str)));
        }

        public string hashASCII(string str)
        {
            byte[] data = mySHA256.ComputeHash(Encoding.ASCII.GetBytes(str));
            StringBuilder sBuilder = new StringBuilder();
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }
            return sBuilder.ToString();
            //return Encoding.ASCII.GetString(mySHA256.ComputeHash(Encoding.ASCII.GetBytes(str)));
        }
    }
}