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
        public static void Main(string[] args)
        {
            string test = "password" + "password";
            
            int got=0;
            string passwords = "passwordpassword";
            Console.WriteLine(test.Equals(passwords));
            attackMethod attackmethod = new DictinaryAttackBasic();
            Console.WriteLine(attackmethod.attack(passwords));
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

        internal static string[] getdictinaryfile()
        {
            return System.IO.File.ReadAllLines(dictinaryfile);
        }
        internal static string[] getPasswordFile()
        {
            return System.IO.File.ReadAllLines(passwordfile);
        }
    }
}
