using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hovedopgave
{
    public class RainbowTableGenerator
    {
        public static void generateRainbow(string path, string newPath, IHashFunction hash)
        {
            string[] list = System.IO.File.ReadAllLines(path);
            using (System.IO.StreamWriter file =
            new System.IO.StreamWriter(newPath))
            {
                foreach (string str in list)
                {
                    file.WriteLine(hash.hashASCII(str)+'\u0009'+ str);
                }
            }
        }
    }
}
