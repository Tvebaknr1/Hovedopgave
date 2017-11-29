using System;
using System.Collections.Generic;

namespace hovedopgave
{
    public class DictinaryAttack : IAttackMethod
    {
        string[] Dictinary;
        public DictinaryAttack()
        {
            //fill dictinary
            Dictinary = new Fileloader().getdictinaryfile();
        }
        
        public string attack(string password)
        {
            foreach (string str in Dictinary)
            {
                //string doubleword = doubleWord(nonhashfunction,str, password);
                //string tripleword = tripleWord(nonhashfunction, str, password);
                string number = addnumber(nonhashfunction, str, password);
                if (str.Equals(password))
                    return str;
                //else if (!string.IsNullOrEmpty(doubleword))
                //return doubleword;
                //else if (!string.IsNullOrEmpty(tripleword))
                //return tripleword;
                else if (!string.IsNullOrEmpty(number))
                    return number;
            }
            return "";
        }
        public string attackhash(string HashedPassword, Func<string,string> hashfunction)
        {
            foreach (string str in Dictinary)
            {
                //string doubleword = doubleWord(hashfunction, str, HashedPassword);
                //string tripleword = tripleWord(hashfunction, str, HashedPassword);
                string number = addnumber(hashfunction, str, HashedPassword);
                if (str.Equals(HashedPassword))
                    return str;
                //else if (!string.IsNullOrEmpty(doubleword))
                    //return doubleword;
                //else if (!string.IsNullOrEmpty(tripleword))
                    //return tripleword;
                else if (!string.IsNullOrEmpty(number))
                    return number;
            }
            return "";
        }
        private bool Equals(string str,string str1)
        {
            return str.Equals(str1);
        }
        private string nonhashfunction(string str)
        {
            return str;
        }
        private bool HashedEquals(Func<string,string> hashfunction,string nonhashed, string hashed)
        {
            return hashed.Equals(hashfunction(nonhashed));
        }

        private string doubleWord(Func<string,string>hash,string str, string password)
        {
            foreach (string str2 in Dictinary)
            {
                string number = addnumber(hash,str + str2, password);
                if (hash((str + str2)).Equals(password))
                    return str + str2;
                else if (!string.IsNullOrEmpty(number))
                    return number;
            }
            return "";
        }
        private string tripleWord(Func<string, string> hash, string str, string password)
        {
            foreach (string str2 in Dictinary)
            {
                foreach (string str3 in Dictinary)
                {
                    string number = addnumber(hash,str + str2 + str3, password);
                    if (hash(str + str2 + str3).Equals(password))
                        return str + str2 + str3;
                    else if (!string.IsNullOrEmpty(number))
                        return number;
                }
            }
            return "";
        }
        private string addnumber(Func<string, string> hash, string str, string password)
        {
            for (int i = 0; i < 10; i++)
            {
                if (hash((str + i)).Equals(password))
                    return str + i;
                else if (hash((i + str)).Equals(password))
                    return i + str;
            }
            for (int i = 1900; i < 2100; i++)
            {
                if (hash((str + i)).Equals(password))
                    return str + i;
                else if (hash((i + str)).Equals(password))
                    return i + str;
            }
            return "";
        }
        
    }
}