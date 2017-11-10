using System;
using System.Collections.Generic;

namespace hovedopgave
{
    public class DictinaryAttack : attackMethod
    {
        string[] Dictinary ;
        public DictinaryAttack()
        {
            //fill dictinary
            Dictinary = Program.getdictinaryfile();
        }
        public string attack(string password)
        {
            foreach(string str in Dictinary)
            {
                if (str.Equals(password))
                    return str;
                else if (doubleword(str).Equals(password))
                    return str;
            }
            return "";
        }

        public string attackhash(string password, hashfunction hashfunction)
        {
            foreach (string str in Dictinary)
            {
                if (hashfunction.hash(password).Equals(str))
                    return str;
            }
            return "";
        }
        private string doubleword(string str)
        {
            return str + str;
        }
    }
}