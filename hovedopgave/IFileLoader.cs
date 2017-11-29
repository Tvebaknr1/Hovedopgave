using System.Collections.Generic;

namespace hovedopgave
{
    public interface IDataLoader
    {
        string[] getdictinaryfile();
        string[] getPasswordFile();
        string[] getTargetFile();
        List<KeyValuePair<string, string>> getRainbowfileMD5();
        List<KeyValuePair<string, string>> getRainbowfileSHA1();
        List<KeyValuePair<string, string>> getRainbowfileSHA256();
        List<KeyValuePair<string, string>> getRainbowfileSHA512();
    }
}