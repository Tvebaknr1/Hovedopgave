using System;
using System.Collections.Generic;

namespace hovedopgave
{
    public class DictinaryAttack : attackMethod
    {
        string[] Dictinary;
        public DictinaryAttack()
        {
            //fill dictinary
            Dictinary = Program.getdictinaryfile();
        }
        public string attack(string password)
        {
            foreach (string str in Dictinary)
            {
                string doubleword = doubleWord(str, password);
                string tripleword = tripleWord(str, password);
                string number = addnumber(str, password);
                if (str.Equals(password))
                    return str;
                else if (!string.IsNullOrEmpty(doubleword))
                    return doubleword;
                else if (!string.IsNullOrEmpty(tripleword))
                    return tripleword;
                else if (!string.IsNullOrEmpty(number))
                    return number;
            }
            return "";
        }
        public string attackhash(string password, hashfunction hashfunction)
        {
            foreach (string str in Dictinary)
            {
                if (hashfunction.hash(str).Equals(password))
                    return str;
            }
            return "";
        }
        private string doubleWord(string str, string password)
        {
            foreach (string str2 in Dictinary)
            {
                string number = addnumber(str + str2, password);
                if ((str + str2).Equals(password))
                    return str + str2;
                else if (string.IsNullOrEmpty(number))
                    return number;
            }
            return "";
        }
        private string tripleWord(string str, string password)
        {
            foreach (string str2 in Dictinary)
            {
                foreach (string str3 in Dictinary)
                {
                    string number = addnumber(str + str2 + str3, password);
                    if ((str + str2 + str3).Equals(password))
                        return str + str2 + str3;
                    else if (string.IsNullOrEmpty(number))
                        return number;
                }
            }
            return "";
        }
        private string addnumber(string str, string password)
        {
            for (int i = 0; i < 10; i++)
            {
                if ((str + i).Equals(password))
                    return str + i;
                else if ((i + str).Equals(password))
                    return i + str;
            }
            for (int i = 1900; i < 160; i++)
            {
                if ((str + i).Equals(password))
                    return str + i;
                else if ((i + str).Equals(password))
                    return i + str;
            }
            return "";
        }
    }
}