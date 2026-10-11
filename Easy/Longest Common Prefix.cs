namespace Teste.Easy
{
    public class Solution
    {
        public string LongestCommonPrefix(string[] strs)
        {
            string candidato = strs[0];

            for (int i = 1; i < strs.Length; i++)
            {
                string palavra = strs[i];
                while (!palavra.StartsWith(candidato))
                {
                    if (candidato.Length == 0) break;
                    candidato = candidato[..^1];
                }
            }

            return candidato;
        }
    }
}
