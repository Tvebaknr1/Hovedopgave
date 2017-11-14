using System;
using System.Security.Cryptography;
using System.Text;

namespace hovedopgave
{
    internal class sha256 : hashfunction
    {
        private SHA256 mySHA256;
        internal sha256()
        {
            mySHA256 = SHA256Managed.Create();
        }
        public string hash(string str)
        {
            return Encoding.UTF8.GetString(mySHA256.ComputeHash(Encoding.UTF8.GetBytes(str)));
        }

        public string hash32(string str)
        {
            return Encoding.UTF32.GetString(mySHA256.ComputeHash(Encoding.UTF32.GetBytes(str)));
        }

        public string hashASCII(string str)
        {
            return Encoding.ASCII.GetString(mySHA256.ComputeHash(Encoding.ASCII.GetBytes(str)));
        }
    }
}