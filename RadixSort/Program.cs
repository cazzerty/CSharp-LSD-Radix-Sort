namespace RadixSort;
class Program
{
    static void Main(string[] args)
    {
        RandomArray randomArray = new RandomArray();

        int[] intArray = randomArray.newRandomIntArray(10, 0, 200);
        Console.WriteLine(randomArray.ArrayToString(intArray));
    }
}
