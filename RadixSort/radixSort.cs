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


        private int[] CountSort(int[] nums)
        {
            return nums;
        }
    }
}
