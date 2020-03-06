using System;
using System.Collections.Generic;

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] test = { 2, 3, 1 };
            int[] test2 = { 3, 2, 1 };
            // removeDuplicates("Hello I I I am am am Chris");
            //bubbleSort(test);
            bubble2(test2);
        }

  

      

        public static void bubble2(int[] nums)
        {
            int temp = 0;
            for(int i = 0; i<nums.Length; i++)
            {
                for(int j = i+1; j<nums.Length; j++)
                {
                    if(nums[i] > nums[j])
                    {
                        temp = nums[i];
                        nums[i] = nums[j];
                        nums[j] = temp;
                    }
                }
            }
            foreach(var n in nums)
            {
                Console.WriteLine(n);
            }
        }
    }
}
