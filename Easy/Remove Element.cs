namespace Teste.Easy;

public class Remove_Element
{
    public static int RemoveElement(int[] nums, int val)
    {
        if (nums.Length == 0) return 0;

        int left = 0;
        int right = nums.Length - 1;

        while (left <= right)
        {
            if (nums[left] != val)
            {
                left++;
            }
            else
            {
                //nums[left] = nums[right]; // element copy
                (nums[left], nums[right]) = (nums[right], nums[left]); // element swap
                right--;
            }
        }

        return left;
    }
}
