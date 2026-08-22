using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

namespace MeuBenchmark
{
    class Program
    {
        static void Main(string[] args)
        {
            var numeros = new[] { 1,1,1,1,1,4,1,1,1,1,1,7,1,1,1,1,1 };
            var target = 11;
            var resultado = new Program().TwoSum(numeros, target);
            Console.WriteLine($"[{string.Join(",", resultado)}]");
        }
        public int[] TwoSum(int[] nums, int target) 
        {
            var historico = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                var complemento = target - nums[i];
                
                if (historico.ContainsKey(complemento)){
                    return [historico[complemento], i];
                }

                if (!historico.ContainsKey(nums[i]))
                {
                    historico.Add(nums[i], i);
                }
            }
            return [];
        }
    }
}
