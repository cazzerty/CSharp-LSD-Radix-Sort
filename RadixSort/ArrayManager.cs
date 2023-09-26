using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadixSort
{
    public class ArrayManager
    {
        // Generate arrays
        public int[] newRandomIntArray(int size, int min, int max)
        {
            int[] intArray = new int[size];
            Random rnd = new Random();
            for (int i = 0; i < intArray.Length; i++)
            {
                intArray[i] = rnd.Next(min, max);
            }
            return intArray;
        }

        public int[] CreateAscendingArray(int size)
        {
            int[] array = new int[size];
            for(int i = 0; i < array.Length; i++)
            {
                array[i] = i + 1;
            }
            return array;
        }
        
        public int[] CreateAscendingArray(int size, int start)
        {
            int[] array = new int[size];
            for(int i = 0; i < array.Length; i++)
            {
                array[i] = ++start;
            }
            return array;
        }

        //Array tools
        public String ArrayToString(int[] array)
        {
            String arrayString = "";

            for (int i = 0; i < array.Length; i++)
            {
                if (i > 0) { arrayString = arrayString + ", "; }
                arrayString = arrayString + array[i];
            }

            return arrayString;
        }

        public int[] ReverseArray(int[] array)
        {
            int lIndex = 0;
            int rIndex = array.Length - 1;
            while(lIndex < rIndex && lIndex != rIndex) 
            {
                (array[lIndex], array[rIndex]) = (array[rIndex], array[lIndex]);

                lIndex++;
                rIndex--;
            }
            return array;
        }

        public int[] ShuffleArray(int[] array)
        {
            Random rnd = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                int rndInt = rnd.Next(0, array.Length - 1);
                (array[i], array[rndInt]) = (array[rndInt], array[i]);
            }
            return array;
        }

        public bool CheckIfSorted(int[] array)
        {
            if (array.Length < 2) return true;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < array[i - 1]) { return false; }
            }
            return true;
        }
    }
}
