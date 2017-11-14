using System;

namespace hovedopgave
{
    public interface attackMethod
    {
        string attack(string hash);
        string attackhash(string password, Func<string, string> hash);
    }
}