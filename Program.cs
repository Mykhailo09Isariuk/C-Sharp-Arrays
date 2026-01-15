using System;

namespace masuv
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[10];

            nums[0] = 1;
            nums[1] = 2;
            nums[2] = 3;
            nums[3] = 4;
            nums[4] = 5;
            nums[5] = 6;
            nums[6] = 7;
            nums[7] = 8;
            nums[8] = 9;
            nums[9] = 10;

            for (int i = 0; i < nums.Length; i++) 
            {
                nums[i] = i + 1;
            }

            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine(nums[i]);
            }
        }
    }
}