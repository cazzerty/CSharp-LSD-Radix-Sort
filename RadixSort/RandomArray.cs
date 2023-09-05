using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadixSort
{
    public class RandomArray
    {
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
    }
}
