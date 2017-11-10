namespace hovedopgave
{
    public class DictinaryAttackBasic : attackMethod
    {
        string[] Dictinary;
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

        public string attackhash(string password, hashfunction hashfunction)
        {
            foreach (string str in Dictinary)
            {
                if (hashfunction.hash(password).Equals(str))
                    return str;
            }
            return "";
        }
    }
}