using Teste.Easy;

namespace Teste;

public partial class Program
{
    static void Main(string[] args)
    {
        int[] nums = [1, 1, 2];
        int k = Remove_Duplicates_from_Sorted_Array.RemoveDuplicates(nums);

        Console.WriteLine($"Total de elementos únicos: {k}");
    }
}
