using System;

namespace hovedopgave
{
    public interface IAttackMethod
    {
        string attack(string clearText);
        string attackhash(string HashedPassword, Func<string, string> hash);
    }
}