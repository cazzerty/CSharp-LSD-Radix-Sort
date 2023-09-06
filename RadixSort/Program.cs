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
        

        Console.WriteLine("_____________________________________________");
        int[] radixArray = arrayManager.newRandomIntArray(100, 1, 999999);

        radixArray = arrayManager.CreateAscendingArray(999);
        radixArray = arrayManager.ShuffleArray(radixArray);

        //Console.WriteLine(arrayManager.ArrayToString(radixArray));


        radixArray = radixSort.Lsd_RadixSort(radixArray);
        //Console.WriteLine(arrayManager.ArrayToString(radixArray));
        Console.WriteLine("Array Sorted?: " + arrayManager.CheckIfSorted(radixArray));
        
    }
}
