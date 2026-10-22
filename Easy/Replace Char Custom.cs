namespace Teste.Easy;

public class Replace_Char_Custom
{
    public static string ReplaceChar(string text, char newChar, HashSet<char> oldChars)
    {
        ArgumentException.ThrowIfNullOrEmpty(text);

        if (oldChars is null or { Count: 0 })
            throw new ArgumentException($"{oldChars} deve conter um valor!", nameof(oldChars));

        HashSet<char> hash = oldChars;
        Span<char> chars = stackalloc char[text.Length];
        text.CopyTo(chars);

        for (int i = 0; i < text.Length; i++)
        {
            char c = text[i];
            if (hash.Contains(c))
                chars[i] = newChar;
        }

        return new string(chars);
    }
}
