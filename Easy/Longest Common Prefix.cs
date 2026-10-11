namespace Teste.Easy
{
    public class Solution
    {
        /* Raciocínio: Pega a primeira palavra (candidato) do array
        e compara a palavra atual, pulando o primeiro elemento.
        Se nao for igual, corta a última letra do candidato. Retorna
        o prefixo comum ou string vazia.*/
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
