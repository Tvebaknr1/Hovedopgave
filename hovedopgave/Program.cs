using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace hovedopgave
{
    public class Program
    {
        public static string dictinaryfile = @"I:\passwords\dictinary.txt";
        
        public static string passwordfile = @"I:\passwords\10-million-combosnew.txt";
        private static string Rainbowfile = "";
        public static void Main(string[] args)
        {
            int got=0;
            string passwords = "900150983cd24fb0d6963f7d28e17f72";
            attackMethod attackmethod = new bruteforce();
            hashfunction hashfunction = new md5();
            //Console.WriteLine(attackmethod.attack(passwords));
            Console.WriteLine(attackmethod.attackhash(passwords,hashfunction.hash));
            Console.WriteLine("cacked "+got+" passwords:");
            // Keep the console window open in debug mode.
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
            
        }
        public static int attack(string[] passwords, attackMethod attackmethod)
        {
            int got = 0;
            foreach (string password in passwords)
            {
                string str = attackmethod.attack(password);
                if (!str.Equals(""))
                    got++;
            }
            return got;
        }
        public static int attackhash(string[] passwords, attackMethod attackmethod,Func<string,string> hashfunction)
        {
            int got = 0;
            foreach (string password in passwords)
            {
                string str = attackmethod.attackhash(password, hashfunction);
                if (!str.Equals(""))
                    got++;
            }
            return got;
        }

        internal static string[] getdictinaryfile()
        {
            return System.IO.File.ReadAllLines(dictinaryfile);
        }
        internal static string[] getPasswordFile()
        {
            return System.IO.File.ReadAllLines(passwordfile);
        }
        internal static List<KeyValuePair<string, string>> getRainbowfile()
        {
            string[] list = System.IO.File.ReadAllLines(Rainbowfile);
            List<KeyValuePair<string, string>> res = new List<KeyValuePair<string, string>>();
            foreach(string str in list)
            {
                res.Add(new KeyValuePair<string, string>(str.Split('\u0009')[0], str.Split('\u0009')[1]));
            }
            return res;
        }
    }
}
