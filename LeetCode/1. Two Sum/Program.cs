// See https://aka.ms/new-console-template for more information
public class Program
{
    public static int[] TwoSum(int[] nums, int target)
    {
        int i = 0;
        int j = 0;

        for (i = 0; i < nums.Length; i++)
        {
            for (j = i + 1; j < nums.Length; j++)
            {
                if ((nums[i] + nums[j]) == target)
                {
                    Console.WriteLine(i);
                    Console.WriteLine(j);
                    return [i, j];
                }
            }
        }
        return [i, j];
    }

    public static void Main(String[] args)
    {
        int[] nums = { 2, 5, 5, 11 };
        int target = 10;
        TwoSum(nums, target);
    }
}