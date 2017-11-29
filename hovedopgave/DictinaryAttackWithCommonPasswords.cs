using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hovedopgave
{
    class DictinaryAttackWithCommonPasswords : IAttackMethod
    {
        string[] passwords;
        public DictinaryAttackWithCommonPasswords()
        {
            //fill dictinary
            passwords = new Fileloader().getPasswordFile();
        }
        public string attack(string password)
        {
            foreach (string str in passwords)
            {
                if (str.Equals(password))
                    return str;
            }
            return "";
        }

        public string attackhash(string HashedPassword, Func<string, string> hash)
        {
            foreach (string str in passwords)
            {
                if (hash(str).Equals(HashedPassword))
                    return str;
            }
            return "";
        }
    }
}
