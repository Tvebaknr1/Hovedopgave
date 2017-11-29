namespace hovedopgave
{
    public interface IHashFunction
    {
        string hash(string str);
        string hash32(string str);
        string hashASCII(string str);
    }
}