using Teste.Easy;

namespace Teste;

public partial class Program
{
    static void Main(string[] args)
    {
        var now = DateTime.Now.ToString("dd:MM:yyyy HH:mm:ss.ffff");
        var replace = Replace_Char_Custom.ReplaceChar(now, '_', [' ', '/', ':']);
        Console.WriteLine(replace);
    }
}
