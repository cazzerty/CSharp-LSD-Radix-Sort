namespace RadixSort;
class Program
{
    static void Main(string[] args)
    {
        ArrayManager arrayManager = new ArrayManager();

        int[] intArray = arrayManager.newRandomIntArray(10, 0, 200);
        Console.WriteLine(arrayManager.ArrayToString(intArray));

        intArray = arrayManager.CreateAscendingArray(25);
        intArray = arrayManager.ReverseArray(intArray);
        Console.WriteLine(arrayManager.ArrayToString(intArray));
    }
}
