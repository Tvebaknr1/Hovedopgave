using System;
using System.Collections;
using System.Collections.Generic;

namespace hovedopgave
{
    internal class rainbowTable : IAttackMethod
    {
        List<KeyValuePair<string, string>> Hashmap = new List<KeyValuePair<string,string>>();
        internal rainbowTable()
        {
            Hashmap.AddRange(new Fileloader().getRainbowfileMD5());
        }
        public string attack(string hash)
        {
            foreach(KeyValuePair<string,string> str in Hashmap)
            {
                if (str.Key.Equals(hash))
                    return str.Value;
            }
            return "?";
        }

        public string attackhash(string password, Func<string, string> hash)
        {
            throw new NotImplementedException();
        }
    }
}