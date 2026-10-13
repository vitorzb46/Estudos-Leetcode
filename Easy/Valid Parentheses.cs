namespace Teste.Easy;

public class Valid_Parentheses
{
    /* Raciocínio: pega cada abertura de chave e coloca na stack.
    Para cada fechamento de chave, compara com um de abertura no topo.
    Se true remove da pilha, senão retorna false. Se a stack ficar vazia,
    retorna false.*/
    public bool IsValid(string s)
    {
        Stack<char> stack = new();

        foreach (char c in s)
        {
            if (c == '(' || c == '[' || c == '{')
                stack.Push(c);

            if (c == ')' || c == ']' || c == '}')
            {
                if (stack.Count == 0) return false;

                if (stack.Peek() == '(' && c == ')' ||
                    stack.Peek() == '[' && c == ']' ||
                    stack.Peek() == '{' && c == '}')
                {
                    stack.Pop();
                }
                else
                    return false;
            }
        }

        return stack.Count == 0;
    }
}
