using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadixSort
{
    internal class RadixSort
    {
        public int[] Lsd_RadixSort(int[] nums)
        {
            if (nums.Length < 2) return nums;
            //Find the largest element in the array
            int largest = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] > largest) { largest = nums[i]; }
            }
            return nums;
        }


        public int[] CountSort(int[] nums)
        {
            int[] digitCount = new int[nums.Length];
            for (int i = 0; i < nums.length; i++){ 
                //digitcount[getDigit(nums[i])]++
            }

            int[] newNums = new int[nums.Length];
            return nums;
        }
    }
}
