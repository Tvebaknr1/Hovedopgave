﻿using System;

namespace hovedopgave
{
    public class DictinaryAttackBasic : IAttackMethod
    {
        string[] Dictinary;
        public DictinaryAttackBasic()
        {
            //fill dictinary
            Dictinary = new Fileloader().getdictinaryfile();
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