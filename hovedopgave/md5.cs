using System;
using System.Security.Cryptography;
using System.Text;

namespace hovedopgave
{
    public class md5 : hashfunction
    {
        private MD5 myMD5;
        public md5()
        {
            myMD5 = MD5.Create();
        }
        public string hash(string str)
        {
            return Encoding.UTF8.GetString(myMD5.ComputeHash(Encoding.UTF8.GetBytes(str)));
        }

        public string hash32(string str)
        {
            return Encoding.UTF32.GetString(myMD5.ComputeHash(Encoding.UTF32.GetBytes(str)));
        }

        public string hashASCII(string str)
        {
            return Encoding.ASCII.GetString(myMD5.ComputeHash(Encoding.ASCII.GetBytes(str)));
        }
    }
}