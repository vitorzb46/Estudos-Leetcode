namespace Teste.Easy;

public class Remove_Duplicates_from_Sorted_Array
{
    public static int RemoveDuplicates(int[] nums)
    {
        int write = 0;

        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] != nums[write])
            {
                write++;
                nums[write] = nums[i];
            }
        }

        int k = write + 1;

        return k;
    }
}
