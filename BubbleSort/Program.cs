using System;

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[]test = {5,4,3,1,2,9,7,10,6};
            BubbleSort(test);
        }

        static int[] BubbleSort(int[]nums)
        {

            int temp;

            for(int i = 0; i < nums.Length; i++){
                for(int j = 0; j < nums.Length -1; j++){
                    if(nums[j] > nums[j+1]){
                        temp = nums[j];
                        nums[j] = nums[j+1];
                        nums[j+1] = temp;
                    }
                }
            }
            foreach (var item in nums)
            {  
                System.Console.WriteLine( item);
                
            }
            return nums;
        }
    }
}
