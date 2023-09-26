using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadixSort
{
    internal class RadixSort
    {
        /// <summary>
        /// Sorts an array of ints using by sorting digits individually, starting at the least significant digit.
        /// </summary>
        /// <param name="nums"></param>
        /// <returns>int[]</returns>
        public int[] Lsd_RadixSort(int[] nums)
        {
            if (nums.Length < 2) return nums;
            //Find the element with most digits in the array
            int largest = Math.Abs(nums[0]);
            for (int i = 1; i < nums.Length; i++)
            {
                if (Math.Abs(nums[i]) > largest) { largest = Math.Abs(nums[i]); }
            }

            int numberOfDigits = GetNumberOfDigits(largest);

            //CountSort for each digit
            for (int i = 1; i < numberOfDigits + 1; i++)
            {
                nums = CountSort(nums, i);
            }
            
            //CountSort based on whether number is positive or negative
            nums = CountSortSign(nums);
            return nums;
        }

        /// <summary>
        /// Sorts an Array of ints based on the digit at a particular position
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="digitPos"></param>
        /// <returns>int[]</returns>
        private int[] CountSort(int[] nums, int digitPos)
        {
            //Built for base 10
            int[] digitCount = new int[10];

            Debug.WriteLine("Num Length: " + nums.Length);

            for (int i = 0; i < nums.Length; i++)
            {
                digitCount[GetDigitAtPos(nums[i], digitPos)]++;
            }

            //Have running sum across array
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
            
            int[] sortedNums = new int[nums.Length];
            
            //Add each element to new list based on index in digit bucket
            for (int i = 0; i < nums.Length; i++)
            {
                int digit = GetDigitAtPos(nums[i], digitPos);
                sortedNums[digitCount[digit]++] = nums[i];
            }
            
            return sortedNums;
        }

        /// <summary>
        /// Performs a count sort based on the sign of each element.
        /// </summary>
        /// <param name="nums"></param>
        /// <returns>int[]</returns>
        private int[] CountSortSign(int[] nums)
        {
            int[] signCount = new int[2];
            signCount[0] = 0;
            signCount[1] = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                signCount[1] += Convert.ToInt32(nums[i] < 0);
            }
            
            int[] sortedNums = new int[nums.Length];
            for (int i = 0; i < nums.Length; i++)
            {
                int sign = Convert.ToInt16(nums[i] >= 0);
                sortedNums[signCount[sign]++] = nums[i];
            }

            sortedNums = ReverseArraySegment(sortedNums, 0, signCount[0] - 1);
            
            return sortedNums;
        }
        
        private int[] ReverseArraySegment(int[] nums, int startIndex, int endIndex )
        {
            while (startIndex < endIndex)
            {
                (nums[startIndex], nums[endIndex]) = (nums[endIndex], nums[startIndex]);
                startIndex++;
                endIndex--;
            }
            return nums;
        }

        private static int GetDigitAtPos(int num, int place)
        {
            double tempNum = Math.Abs(num);
            tempNum = tempNum % Math.Pow(10, place);
            tempNum = tempNum / Math.Pow(10, place - 1);
            num = (int)tempNum;

            return num;
        }

        private int GetNumberOfDigits(int num)
        {
            int count = 0;
            while (Math.Abs(num) > 0)
            {
                num = num / 10;
                count++;
            }
            return count;
        }
    }
}
