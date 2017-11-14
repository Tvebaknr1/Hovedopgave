using System.Security.Cryptography;
using System.Text;

namespace hovedopgave
{
    internal class sha512 : hashfunction
    {
        private SHA512 mySHA512;
        internal sha512()
        {
            mySHA512 = SHA512Managed.Create();
        }
        public string hash(string str)
        {
            return Encoding.UTF8.GetString(mySHA512.ComputeHash(Encoding.UTF8.GetBytes(str)));
        }

        public string hash32(string str)
        {
            return Encoding.UTF32.GetString(mySHA512.ComputeHash(Encoding.UTF32.GetBytes(str)));
        }

        public string hashASCII(string str)
        {
            return Encoding.ASCII.GetString(mySHA512.ComputeHash(Encoding.ASCII.GetBytes(str)));
        }
    }
}