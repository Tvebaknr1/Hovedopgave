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
        
        public static void Main(string[] args)
        {
            //testspeedRainbowTablevsNonRainbowTable();
            IAttackMethod attackmethod = new DictinaryAttack();
            IHashFunction hashfunction = new sha256();
            DateTime start = DateTime.Now;
            Console.WriteLine(attackmethod.attack("12345678"));
            Console.WriteLine((DateTime.Now - start).TotalMilliseconds);
            //Console.WriteLine(str + " = " + attackmethod.attack(str));

            // Keep the console window open in debug mode.
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
        public static void testspeedRainbowTablevsNonRainbowTable()
        {
            IAttackMethod attackmethod = new DictinaryAttackWithCommonPasswords();
            IAttackMethod attackmethod1 = new rainbowTable();
            IHashFunction hashfunction = new sha256();
            DateTime start = DateTime.Now;
            foreach (string str in new Fileloader().getTargetFile())
            {
                Console.WriteLine(str + " = " + attackmethod.attackhash(str, hashfunction.hash));
            }
            Console.WriteLine((DateTime.Now - start).TotalMilliseconds);
            start = DateTime.Now;
            foreach (string str in new Fileloader().getTargetFile())
            {
                Console.WriteLine(str + " = " + attackmethod1.attack(str));
            }
            Console.WriteLine((DateTime.Now - start).TotalMilliseconds);

            // Keep the console window open in debug mode.
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
        public static int attack(string[] passwords, IAttackMethod attackmethod)
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
        public static int attackhash(string[] passwords, IAttackMethod attackmethod, Func<string, string> hashfunction)
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
    }
}
