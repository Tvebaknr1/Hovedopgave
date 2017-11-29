using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hovedopgave
{
    public class Fileloader : IDataLoader
    {
        public static string dictinaryfile = @"I:\passwords\dictinary.txt";

        public static string passwordfile = @"I:\passwords\10-million-combosnew.txt";
        public static string RainbowfileSha1 = @"I:\passwords\rainbowSHA1.txt";
        public static string RainbowfileSha256 = @"I:\passwords\rainbowSHA256.txt";
        public static string RainbowfileSha512 = @"I:\passwords\rainbowSHA512.txt";
        public static string RainbowfileMD5 = @"I:\passwords\rainbowMD5.txt";
        public static string attackTarget = @"I:\passwords\target.txt";
        public string[] getdictinaryfile()
        {
            return System.IO.File.ReadAllLines(dictinaryfile);
        }
        public string[] getPasswordFile()
        {
            return System.IO.File.ReadAllLines(passwordfile);
        }
        public string[] getTargetFile()
        {
            return System.IO.File.ReadAllLines(attackTarget);
        }
        public List<KeyValuePair<string, string>> getRainbowfileMD5()
        {
            string[] list = System.IO.File.ReadAllLines(RainbowfileMD5);
            string[] templist;
            List<KeyValuePair<string, string>> res = new List<KeyValuePair<string, string>>();
            foreach (string str in list)
            {
                templist = str.Split('\u0009');
                res.Add(new KeyValuePair<string, string>(templist[0], templist[1]));
            }
            return res;
        }
        public List<KeyValuePair<string, string>> getRainbowfileSHA1()
        {
            string[] list = System.IO.File.ReadAllLines(RainbowfileSha1);
            string[] templist;
            List<KeyValuePair<string, string>> res = new List<KeyValuePair<string, string>>();
            foreach (string str in list)
            {
                templist = str.Split('\u0009');
                res.Add(new KeyValuePair<string, string>(templist[0], templist[1]));
            }
            return res;
        }
        public List<KeyValuePair<string, string>> getRainbowfileSHA256()
        {
            string[] list = System.IO.File.ReadAllLines(RainbowfileSha256);
            string[] templist;
            List<KeyValuePair<string, string>> res = new List<KeyValuePair<string, string>>();
            foreach (string str in list)
            {
                templist = str.Split('\u0009');
                res.Add(new KeyValuePair<string, string>(templist[0], templist[1]));
            }
            return res;
        }
        public List<KeyValuePair<string, string>> getRainbowfileSHA512()
        {
            string[] list = System.IO.File.ReadAllLines(RainbowfileSha512);
            string[] templist;
            List<KeyValuePair<string, string>> res = new List<KeyValuePair<string, string>>();
            foreach (string str in list)
            {
                templist = str.Split('\u0009');
                res.Add(new KeyValuePair<string, string>(templist[0], templist[1]));
            }
            return res;
        }
    }
}
