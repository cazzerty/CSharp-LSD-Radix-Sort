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

        Console.WriteLine("_____________________________________________");
        int[] radixArray = arrayManager.newRandomIntArray(1000000, 1, 999999);
        
        radixArray = arrayManager.CreateAscendingArray(99999);
        radixArray = arrayManager.ShuffleArray(radixArray);
        radixArray = arrayManager.ShuffleArray(radixArray);
        Console.WriteLine("Array Sorted?: " + arrayManager.CheckIfSorted(radixArray));
        
        
        watch.Start();
        
        

        //Console.WriteLine(arrayManager.ArrayToString(radixArray));


        radixArray = radixSort.Lsd_RadixSort(radixArray);
        watch.Stop();

        Console.WriteLine($"Execution Time: {watch.ElapsedMilliseconds} ms");
        //Console.WriteLine(arrayManager.ArrayToString(radixArray));
        Console.WriteLine("Array Sorted?: " + arrayManager.CheckIfSorted(radixArray));
        
    }
}
