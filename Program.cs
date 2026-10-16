using Teste.Easy;

namespace Teste;

public partial class Program
{
    static void Main(string[] args)
    {
        int[] nums = [0, 1, 2, 2, 3, 0, 4, 2];
        int val = 2;
        int k = Remove_Element.RemoveElement(nums, val);

        Console.WriteLine($"Expected Output: 5, nums = [0, 1, 4, 0, 3, _, _, _]\nk: {k}, nums: {string.Join(", ", nums)}");
    }
}
