namespace RadixSort;
class Program
{
    static void Main(string[] args)
    {
        ArrayManager arrayManager = new ArrayManager();
        RadixSort radixSort = new RadixSort();

        /*
        int[] intArray = arrayManager.newRandomIntArray(10, 0, 200);
        Console.WriteLine(arrayManager.ArrayToString(intArray));

        intArray = arrayManager.CreateAscendingArray(25);
        intArray = arrayManager.ReverseArray(intArray);
        Console.WriteLine(arrayManager.ArrayToString(intArray));
        */


        var watch = new System.Diagnostics.Stopwatch();
        bool repeat = true;
        int count = 1;
        int loops = 100;
        long watchCount = 0;
        while (repeat == true && count < loops)
        {
            Console.WriteLine("_____________________________________________");
            Console.WriteLine("Count: " + count);
            int[] radixArray = arrayManager.newRandomIntArray(999999, -10000000, 10000000);

            radixArray = arrayManager.CreateAscendingArray(999999, -5000);
            //radixArray[0] = 2147483647;
            
            
            radixArray = arrayManager.ShuffleArray(radixArray);
            radixArray = arrayManager.ShuffleArray(radixArray);
            //Console.WriteLine(arrayManager.ArrayToString(radixArray));
            Console.WriteLine("Array Sorted?: " + arrayManager.CheckIfSorted(radixArray));
            watch.Reset();
            watch.Start();
            radixArray = radixSort.Lsd_RadixSort(radixArray);
            watch.Stop();

            Console.WriteLine($"Execution Time: {watch.ElapsedMilliseconds} ms");
            watchCount += watch.ElapsedMilliseconds;
            //Console.WriteLine(arrayManager.ArrayToString(radixArray));
            repeat = arrayManager.CheckIfSorted(radixArray);
            Console.WriteLine("Array Sorted?: " + repeat);
            //Console.WriteLine(arrayManager.ArrayToString(radixArray));

            count++;
        }
        Console.WriteLine("_____________________________________________");
        Console.WriteLine("Average time: " + (watchCount = watchCount / loops));

    }
}
