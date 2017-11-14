using System;
using System.Collections;
using System.Collections.Generic;

namespace hovedopgave
{
    internal class rainbowTable : attackMethod
    {
        List<KeyValuePair<string, string>> Hashmap = new List<KeyValuePair<string,string>>();
        rainbowTable()
        {
            Hashmap.AddRange(Program.getRainbowfile());
        }
        public string attack(string hash)
        {
            foreach(KeyValuePair<string,string> str in Hashmap)
            {
                if (str.Key.Equals(hash))
                    return str.Value;
            }
            return "";
        }

        public string attackhash(string password, Func<string, string> hash)
        {
            throw new NotImplementedException();
        }
    }
}