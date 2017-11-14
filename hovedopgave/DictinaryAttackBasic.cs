using System;

namespace hovedopgave
{
    public class DictinaryAttackBasic : attackMethod
    {
        string[] Dictinary;
        hashfunction hashfunction;
        public DictinaryAttackBasic()
        {
            //fill dictinary
            Dictinary = Program.getdictinaryfile();
        }
        public string attack(string password)
        {
            foreach (string str in Dictinary)
            {
                if (str.Equals(password))
                    return str;
            }
            return "";
        }

        public string attackhash(string HashedPassword, Func<string, string> hash)
        {
            foreach (string str in Dictinary)
            {
                if (hash(str).Equals(HashedPassword))
                    return str;
            }
            return "";
        }
    }
}