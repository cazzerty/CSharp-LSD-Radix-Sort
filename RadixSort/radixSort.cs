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

            int numberOfDigits = GetNumberOfDigits(largest);

            for (int i = 1; i < numberOfDigits + 1; i++)
            {
                nums = CountSort(nums, i);
            }

            return nums;
        }


        public int[] CountSort(int[] nums, int digitPos)
        {
            //Built for base 10
            int[] digitCount = new int[10];

            for (int i = 0; i < nums.Length; i++)
            {
                digitCount[GetDigitAtPos(nums[i], digitPos)]++;
            }

            //Have running sum accross array
            for(int i = 1; i < digitCount.Length; i++)
            {
                digitCount[i] = digitCount[i] + digitCount[i - 1];
            }

            //Move everything 1 to the right
            for (int i = digitCount.Length - 1; i > 0; i--)
            {
                digitCount[i] = digitCount[i - 1];
            }
            digitCount[0] = 0;

            //
            int[] sortedNums = new int[nums.Length];
            
            for (int i = 0; i < nums.Length; i++)
            {
                int digit = GetDigitAtPos(nums[i], digitPos);
                sortedNums[digitCount[digit]++] = nums[i];
            }
            
            return sortedNums;
        }

        private int GetDigitAtPos(int num, int place)
        {
            double tempNum = num;
            tempNum = num % Math.Pow(10, place);
            tempNum = tempNum / Math.Pow(10, place - 1);
            num = (int)tempNum;

            return num;
        }

        private int GetNumberOfDigits(int num)
        {
            int count = 0;
            while (num > 0)
            {
                num = num / 10;
                count++;
            }
            return count;
        }
    }
}
