namespace Teste.Easy;

public static class FindFirstIndex
{
    // Cheating way for Leet Code
    public static int StrStr(string haystack, string needle)
    {
        Span<char> haystackSpan = stackalloc char[haystack.Length];
        Span<char> needleSpan = stackalloc char[needle.Length];
        haystack.CopyTo(haystackSpan);
        needle.CopyTo(needleSpan);
        return haystackSpan.IndexOf(needleSpan);
    }

    public static int StrStr2(string haystack, string needle)
    {
        int res = -1;
        Span<char> haystackSpan = stackalloc char[haystack.Length];
        Span<char> needleSpan = stackalloc char[needle.Length];
        haystack.CopyTo(haystackSpan);
        int match = 0;
        int firstIndex = 0;
        for (int i = 0; i < haystackSpan.Length; i++)
        {
            bool isMatch = haystackSpan[i] == needle[match];
            if (isMatch)
            {
                if (match == 0) firstIndex = i;
                needleSpan[match] = haystackSpan[i];
                if (++match == needle.Length)
                {
                    res = firstIndex;
                    break;
                }
            }
            else if (!isMatch && match > 0)
            {
                match = 0;
                i = firstIndex;
                continue;
            }
        }

        return res;
    }
}