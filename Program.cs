using Teste.Easy;

namespace Teste;

public partial class Program
{
    static void Main(string[] args)
    {
        string haystack = "mississippi", needle = "issip";

        Log($"First index: {FindFirstIndex.StrStr(haystack, needle)}\nExpected output: 4");
    }

    static void Log(string msg) => Console.WriteLine(msg);
}
